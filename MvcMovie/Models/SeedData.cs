using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Intialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Looking for Movie
                if (context.Movie.Any())
                {
                    return; //DB has been seeded
                }

                context.Movie.AddRange(

                    new Movie
                    {
                        Title = "RRR",
                        ReleaseDate = DateTime.Parse("2024-02-12"),
                        Genre = "Action",
                        Price = 5.99M
                    },

                      new Movie
                      {
                          Title = "MyWorld",
                          ReleaseDate = DateTime.Parse("2024-02-24"),
                          Genre = "Horror",
                          Price = 5.99M
                      },

                      new Movie
                      {
                          Title = "Pissed Off",
                          ReleaseDate = DateTime.Parse("2024-01-12"),
                          Genre = "Action",
                          Price = 10.99M
                      },

                       new Movie
                       {
                           Title = "MyWorld 2",
                           ReleaseDate = DateTime.Parse("2024-03-12"),
                           Genre = "Adventure",
                           Price = 10.99M
                       }
                        

                    );
                    context.SaveChanges();
            }
        }
    }
}
