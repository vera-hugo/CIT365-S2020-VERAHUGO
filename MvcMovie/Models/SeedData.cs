using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace MvcMovie.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Finding Faith in Christ",
                        ReleaseDate = DateTime.Parse("2004-1-01"),
                        Genre = "Action",
                        Rating = "A",
                        Price = 7.99M
                    },

                    new Movie
                    {
                        Title = "Johnny Lingo",
                        ReleaseDate = DateTime.Parse("2011-5-01"),
                        Genre = "Comedy",
                        Rating = "B",
                        Price = 8.99M
                    },

                    new Movie
                    {
                        Title = "Joseph Smith: Prophet of the Restoration",
                        ReleaseDate = DateTime.Parse("2006-5-01"),
                        Genre = "Romantic",
                        Rating = "C",
                        Price = 9.99M
                    },

                    new Movie
                    {
                        Title = "Man's Search for Happiness",
                        ReleaseDate = DateTime.Parse("2016-10-02"),
                        Genre = "Drama",
                        Rating = "A",
                        Price = 3.99M
                    },
                     new Movie
                     {
                         Title = "Meet the Mormons",
                         ReleaseDate = DateTime.Parse("2015-05-01"),
                         Genre = "Romantic",
                         Rating = "B",
                         Price = 3.99M
                     },
                     new Movie
                     {
                         Title = "On the Lord's Errand: The Life of Thomas S. Monson",
                         ReleaseDate = DateTime.Parse("2009-09-01"),
                         Genre = "Action",
                         Rating = "C",
                         Price = 3.99M
                     },
                      new Movie
                      {
                          Title = "Only a Stonecutter",
                          ReleaseDate = DateTime.Parse("2010-07-01"),
                          Genre = "Action",
                          Rating = "C",
                          Price = 3.99M
                      }
                );
                context.SaveChanges();
            }
        }
    }
}
