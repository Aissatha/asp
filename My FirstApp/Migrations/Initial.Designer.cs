using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;


#nullable disable


namespace My_FirstApp.Migrations
{

	[DbContext(typeof(AppDbContext))]
	[Migration("Initial")]
	partial class Initial
	{
		protected override void BuildTargetModel(ModelBuilder modelBuilder)
		{
#pragma warning disable 612, 618
			modelBuilder.HasAnnotation("ProductVersion", "6.0.25");

			modelBuilder.Entity("My_FirstApp.Models.Movie", b =>
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
