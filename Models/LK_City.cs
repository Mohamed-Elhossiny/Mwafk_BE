namespace Mwafk_BE.Models
{
	public class LK_City : ParentLookupModel
	{
		#region Virtual List
		public virtual List<LK_Area> Areas { get; set; } = new List<LK_Area>();
		#endregion
	}
}
