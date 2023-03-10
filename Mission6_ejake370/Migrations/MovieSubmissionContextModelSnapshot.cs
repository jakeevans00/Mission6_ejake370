// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission6_ejake370.Models;

namespace Mission6_ejake370.Migrations
{
    [DbContext(typeof(MovieSubmissionContext))]
    partial class MovieSubmissionContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("Mission6_ejake370.Models.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("lentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<string>("rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("year")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MovieId");

                    b.ToTable("movies");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            category = "Action/Adventure",
                            director = "Christopher Nolan",
                            edited = true,
                            lentTo = "",
                            notes = "Amazing movie",
                            rating = "PG-13",
                            title = "Batman Begins",
                            year = "2005"
                        },
                        new
                        {
                            MovieId = 2,
                            category = "Action/Adventure",
                            director = "Christopher Nolan",
                            edited = true,
                            lentTo = "",
                            notes = "eveeen better movie!",
                            rating = "PG-13",
                            title = "The Dark Knight",
                            year = "2008"
                        },
                        new
                        {
                            MovieId = 3,
                            category = "Drama",
                            director = "Billie August",
                            edited = false,
                            lentTo = "Dave",
                            notes = "An honest tear-jerker",
                            rating = "PG-13",
                            title = "Les Miserables",
                            year = "1998"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
