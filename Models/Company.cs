namespace Mwafk_BE.Models
{
	public class Company : ParentModel
	{
		public string NameAr { get; set; }
		public string NameEn { get; set; }
		public string Phone { get; set; }
		public string CommercialReg { get; set; }
		public string TaxReg { get; set; }

		#region Virtual List
		public virtual List<CompanyUser> CompanyUsers { get; set; } = new List<CompanyUser>();
		#endregion
	}
}
