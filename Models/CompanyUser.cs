namespace Mwafk_BE.Models
{
	public class CompanyUser : ParentModel
	{
		#region Props
		public string FullNameAr { get; set; }
		public string FullNameEn { get; set; }
		public DateTime? BirthDate { get; set; }
		public string Job { get; set; }
		public string IdNumber { get; set; }
		public string Phone { get; set; }
		public string Email { get; set; }
		public string Username { get; set; }
		public string EmployeeTag { get; set; }
		public int? CompanyUserType { get; set; }   // Enum =>  CompanyUser = 1 || CompanyEmployee = 2
		public int? GenderId { get; set; }
		public int? NationalityId { get; set; }
		public int? CityId { get; set; }
		public int? AreaId { get; set; }
		public long? AspNetUserId { get; set; }
		public int? CompanyId { get; set; }
		#endregion

		#region Virtual Props
		public virtual LK_Gender Gender { get; set; }
		public virtual LK_Nationality Nationality { get; set; }
		public virtual LK_City City { get; set; }
		public virtual LK_Area Area { get; set; }
		public virtual ApplicationUser AspNetUser { get; set; }
		public virtual Company Company { get; set; }
		#endregion
	}
}
