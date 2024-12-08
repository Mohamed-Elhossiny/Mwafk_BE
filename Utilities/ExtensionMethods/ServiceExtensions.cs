using Mwafk_BE.Repositories.AuthenticationRepo;

namespace Mwafk_BE.Utilities.ExtensionMethods
{
	public static class ServiceExtensions
	{
		public static void RegisterApplicationsServices(this IServiceCollection services)
		{
			services.AddScoped<IAuthenticationRepo, AuthenticationRepo>();
		}
	}
}
