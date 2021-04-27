using BloggingPlatform.Dal.Database;
using Microsoft.EntityFrameworkCore;
using System;

namespace BloggingPlatform.Dal.Database
{
    public partial class BloggingPlatformDbContext
    {
        // Database seeding
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            #region Dodavanje postova
            modelBuilder.Entity<Post>().HasData(
                new Post
                {
                    Id = 1,
                    Slug = "augmented-reality-ios-application",
                    Title = "Augmented Reality iOS Application",
                    Description = "Rubicon Software Development and Gazzda furniture are proud to launch an augmented reality app.",
                    Body = "The app is simple to use, and will help you decide on your best furniture fit.",
                    Tag = Helper.Tag.IOS,
                    CreatedAt = DateTime.Now.AddDays(-4),
                    UpdatedAt = DateTime.Now.AddDays(-1)
                },
                 new Post
                 {
                     Id = 2,
                     Slug = "augmented-reality-ios-application 2",
                     Title = "Augmented Reality iOS Application 2",
                     Description = "Rubicon Software Development and Gazzda furniture are proud to launch an augmented reality app.",
                     Body = "The app is simple to use, and will help you decide on your best furniture fit.",
                     Tag = Helper.Tag.IOS,
                     CreatedAt = DateTime.Now.AddDays(-2),
                     UpdatedAt = DateTime.Now
                 }
            );

            #endregion
        }
    }
}
