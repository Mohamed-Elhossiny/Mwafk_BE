using Mwafk_BE.Utilities.Enum;

namespace Mwafk_BE.Utilities
{
	public class MwafkException :Exception
	{
		public string MwafkExceptionMessage { get; set; }
		public MwafkException(ExceptionMessage message) : base($"{(int)message}-{message}")
		{
			this.MwafkExceptionMessage = $"{(int)message}";
		}
		public MwafkException(string message) : base($"{message}")
		{
			this.MwafkExceptionMessage = $"{message}";
		}
	}
}
