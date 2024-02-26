using Microsoft.EntityFrameworkCore;

namespace My_FirstApp.Models
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions options) :
			base(options)
		{
		}
		public DbSet<Movie> movies { get; set; }

	}
}
