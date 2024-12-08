namespace Mwafk_BE.Models
{
	public class LK_Area : ParentLookupModel
	{
		#region Props
		public double Lat { get; set; }
		public double Long { get; set; }
		public int? CityId { get; set; }
		#endregion

		#region Virtual Props
		public virtual LK_City City { get; set; }
		#endregion
	}
}
