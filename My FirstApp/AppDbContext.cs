using System;
using Microsoft.EntityFrameworkCore;
using My_FirstApp.Models;

namespace My_FirstApp
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions options) : base(options)
		{

		}
		public DbSet<Movie> movies { get; set; }
	}
}
