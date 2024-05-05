using System;
using BookShop.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BookShop.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole, string>
    {
        public DbSet<ApplicationModel> ApplicationModels { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<JobListingModel> JobListingModels { get; set; }
        public DbSet<Category> Categories { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Remove 'AspNet' prefix from table names
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                var tableName = entityType.GetTableName();
                if (tableName.StartsWith("AspNet"))
                {
                    entityType.SetTableName(tableName[6..]);
                }
            }

            // Set keys to be generated on add
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                foreach (var property in entityType.GetProperties())
                {
                    if (property.Name == "Id" || property.Name == $"{entityType.ClrType.Name}Id")
                    {
                        property.ValueGenerated = ValueGenerated.OnAdd;
                    }
                }
            }

            // Seed initial data
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Back-End Developer", Description = "A Back End Developer is responsible for server-side application logic and integration of the work front-end developers do." },
                new Category { CategoryId = 2, Name = "Front-End Developer", Description = "A Front End Developer is focused on the user interface and user experience of a website or application." },
                new Category { CategoryId = 3, Name = "Full Stack Developer", Description = "A Full Stack Developer is capable of working on both the front-end and back-end portions of an application." },
                new Category { CategoryId = 4, Name = "Mobile Apps Developer", Description = "A Mobile Apps Developer is specialized in creating applications for mobile devices, such as smartphones and tablets." }
            );

            modelBuilder.Entity<JobListingModel>().HasData(
                new JobListingModel
                {
                    JobListingId = 1,
                    Title = "C# Programming",
                    Description = "Hello",
                    ApplicationDeadline = DateTime.UtcNow.Date.AddDays(-5),
                    Location = "NY",
                    CategoryId = 1
                },
                new JobListingModel
                {
                    JobListingId = 2,
                    Title = "Advanced Programming",
                    Description = "Learning Harder",
                    ApplicationDeadline = DateTime.UtcNow.Date.AddDays(-5),
                    Location = "NY",
                    CategoryId = 2
                },
                new JobListingModel
                {
                    JobListingId = 3,
                    Title = "Java Programming",
                    Description = "Basic language",
                    ApplicationDeadline = DateTime.UtcNow.Date.AddDays(-5),
                    Location = "NY",
                    CategoryId = 3
                },
                new JobListingModel
                {
                    JobListingId = 4,
                    Title = "Data Structures",
                    Description = "Really not easy",
                    ApplicationDeadline = DateTime.UtcNow.Date.AddDays(-5),
                    Location = "NY",
                    CategoryId = 4
                }
            );
        }
    }
}
