using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

#nullable disable


namespace My_FirstApp.Migrations
{
	[DbContext(typeof(AppDbContext))]

	partial class AppDbContextModelSnapshot : ModelSnapshot
	{
		protected override void BuildModel(ModelBuilder modelBuilder)
		{
#pragma warning disable 612, 618
			modelBuilder.HasAnnotation("ProductVersion", "6.0.25");

			modelBuilder.Entity("FirstProject.DMWMB._2024.Models.Movie", b =>
			{
				b.Property<int>("Id")
					.ValueGeneratedOnAdd()
					.HasColumnType("INTEGER");

				b.Property<string>("Name")
					.IsRequired()
					.HasColumnType("TEXT");

				b.HasKey("Id");

				b.ToTable("movies");
			});
#pragma warning restore 612, 618
		}
	}
}
