namespace Mwafk_BE.DTOS.Authentication
{
	public class AuthenticatedDTO
	{
		public string Token { get; set; }
		public string Username { get; set; }
		public int UserType { get; set; }
		public DateTime ExpiresOn { get; set; }
	}
}
