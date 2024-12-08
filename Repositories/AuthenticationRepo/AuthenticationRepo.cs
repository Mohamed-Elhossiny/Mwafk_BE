using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Mwafk_BE.DTOS.Authentication;
using Mwafk_BE.Models;
using Mwafk_BE.Utilities;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security;
using System.Text;
using Mwafk_BE.Utilities.Enum;

namespace Mwafk_BE.Repositories.AuthenticationRepo
{
	public class AuthenticationRepo : IAuthenticationRepo
	{
		private readonly JWT jwt;
		private readonly UserManager<ApplicationUser> userManager;
		private readonly RoleManager<ApplicationRole> roleManager;
		private readonly MwafkDbContext context;

		public AuthenticationRepo(IOptions<JWT> jwt, UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManager, MwafkDbContext context)
		{
			this.jwt = jwt.Value;
			this.userManager = userManager;
			this.roleManager = roleManager;
			this.context = context;
		}

		public async Task<AuthenticatedDTO> LoginAsync(LoginDTO dto)
		{
			var authDto = new AuthenticatedDTO();

			var user = await userManager.FindByNameAsync(dto.Username);
			
			if (user is null)
				throw new MwafkException(ExceptionMessage.UserNameOrPasswordIncorrect);

			if (!await userManager.CheckPasswordAsync(user, dto.Password))
				throw new MwafkException(ExceptionMessage.UserNameOrPasswordIncorrect);

			var jwtSecurityToken = await CreateToken(user);
			authDto.Token = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);
			authDto.ExpiresOn = jwtSecurityToken.ValidTo;
			authDto.Username = user.UserName;
			authDto.UserType = user.UserType;

			return authDto;
		}


		private async Task<JwtSecurityToken> CreateToken(ApplicationUser user)
		{
			// Get Roles and Create Claims to store in the Token
			var roles = await userManager.GetRolesAsync(user);
			var claims = new List<Claim>
				{
					new Claim(ClaimTypes.Name, user.UserName!),
					new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
					new Claim("UserId", user.Id.ToString()),
					new Claim("UserType", user.UserType.ToString())
				};

			// Create Security Key
			var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwt.Key));
			var signingCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

			// Create Token
			var token = new JwtSecurityToken(
				issuer: jwt.Issuer,
				audience: jwt.Audiance,
				claims: claims,
				expires: DateTime.UtcNow.AddDays(jwt.Duration),
				signingCredentials: signingCredentials
			);

			return token;
		}
	}
}
