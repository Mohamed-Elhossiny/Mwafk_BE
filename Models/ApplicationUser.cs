using Microsoft.AspNetCore.Identity;

namespace Mwafk_BE.Models
{
	public class ApplicationUser : IdentityUser<long>
	{
		#region Props
		public string FullNameEn { get; set; }
		public string FullNameAr { get; set; }
		public int UserType { get; set; }    // UserTypeEnum
		public int CreatedBy { get; set; } = 0;
		public int? UpdatedBy { get; set; }
		public int? DeletedBy { get; set; }
		public DateTime CreatedDate { get; set; } = DateTime.Now;
		public DateTime? UpdatedDate { get; set; }
		public DateTime? DeletedDate { get; set; }
		public bool? IsDeleted { get; set; } = false;
		#endregion

		#region Virtual List
		public virtual List<CompanyUser> CompanyUsers { get; set; } = new List<CompanyUser>();
		#endregion
	}
}
