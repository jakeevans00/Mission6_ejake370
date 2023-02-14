using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6_ejake370.Models
{
    public class MovieSubmissionContext : DbContext
    {
        //Constructor
        public MovieSubmissionContext(DbContextOptions<MovieSubmissionContext> options) : base (options)
        {
            //Leave blank for now
        }
        
        public DbSet<Movie> movies { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Movie>().HasData(
                new Movie
                {
                    MovieId = 1,
                    category = "Action/Adventure",
                    title = "Batman Begins",
                    year = "2005",
                    director = "Christopher Nolan",
                    rating = "PG-13",
                    edited = true,
                    lentTo = "",
                    notes = "Amazing movie"
                },
                new Movie
                {
                    MovieId = 2,
                    category = "Action/Adventure",
                    title = "The Dark Knight",
                    year = "2008",
                    director = "Christopher Nolan",
                    rating = "PG-13",
                    edited = true,
                    lentTo = "",
                    notes = "eveeen better movie!"
                },
                new Movie
                {
                    MovieId = 3,
                    category = "Drama",
                    title = "Les Miserables",
                    year = "1998",
                    director = "Billie August",
                    rating = "PG-13",
                    edited = false,
                    lentTo = "Dave",
                    notes = "An honest tear-jerker"
                }
             );
        }
    }
}
