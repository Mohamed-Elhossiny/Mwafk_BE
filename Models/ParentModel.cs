namespace Mwafk_BE.Models
{
	public class ParentModel
	{
		public int Id { get; set; }
		public int CreatedBy { get; set; } = 0;
		public int? UpdatedBy { get; set; }
		public int? DeletedBy { get; set; }
		public DateTime CreatedDate { get; set; } = DateTime.Now;
		public DateTime? UpdatedDate { get; set; }
		public DateTime? DeletedDate { get; set; }
		public bool IsDeleted { get; set; } = false;
	}
}
