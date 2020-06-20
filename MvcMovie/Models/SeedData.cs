﻿using System;
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
                        Rating = "PG-13",
                        Price = 7.99M,
                        Image = "../../image/1_img.jpg"
                    },

                    new Movie
                    {
                        Title = "Johnny Lingo",
                        ReleaseDate = DateTime.Parse("2011-5-01"),
                        Genre = "Comedy",
                        Rating = "PG-13",
                        Price = 8.99M,
                        Image = "../../image/2_img.jpg"
                    },

                    new Movie
                    {
                        Title = "Joseph Smith: Prophet of the Restoration",
                        ReleaseDate = DateTime.Parse("2006-5-01"),
                        Genre = "Romantic",
                        Rating = "PG-10",
                        Price = 9.99M,
                        Image = "../../image/3_img.jpg"
                    },

                    new Movie
                    {
                        Title = "Man's Search for Happiness",
                        ReleaseDate = DateTime.Parse("2016-10-02"),
                        Genre = "Drama",
                        Rating = "PG-09",
                        Price = 3.99M,
                        Image = "../../image/4_img.jpg"
                    },
                     new Movie
                     {
                         Title = "Meet the Mormons",
                         ReleaseDate = DateTime.Parse("2015-05-01"),
                         Genre = "Romantic",
                         Rating = "PG-00",
                         Price = 3.99M,
                         Image = "../../image/5_img.jpg"
                     },
                     new Movie
                     {
                         Title = "On the Lord's Errand: The Life of Thomas S. Monson",
                         ReleaseDate = DateTime.Parse("2009-09-01"),
                         Genre = "Action",
                         Rating = "PG-04",
                         Price = 3.99M,
                         Image = "../../image/6_img.jpg"
                     },
                      new Movie
                      {
                          Title = "Only a Stonecutter",
                          ReleaseDate = DateTime.Parse("2010-07-01"),
                          Genre = "Action",
                          Rating = "PG-25",
                          Price = 3.99M,
                          Image = "../../image/7_img.jpg"
                      }
                );
                context.SaveChanges();
            }
        }
    }
}
