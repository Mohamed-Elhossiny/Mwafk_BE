using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Mwafk_BE.Models
{
	public class MwafkDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, long>
	{
		public MwafkDbContext() { }
		public MwafkDbContext(DbContextOptions<MwafkDbContext> options):base(options) { }

		#region Company
		public virtual DbSet<Company> Companies { get; set; }
		public virtual DbSet<CompanyUser> CompanyUsers { get; set; }
		#endregion

		#region Lookup
		public virtual DbSet<LK_Area> LK_Areas { get; set; }
		public virtual DbSet<LK_City> LK_Cities { get; set; }
		public virtual DbSet<LK_Gender> LK_Genders { get; set; }
		public virtual DbSet<LK_Nationality> LK_Nationalities { get; set; }

		#endregion

	}
}
