using csharp_job_finder.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace csharp_job_finder.Data
{
    public class csharp_job_finderContext : DbContext
    {
        public csharp_job_finderContext (DbContextOptions<csharp_job_finderContext> options)
            : base(options)
        {           
        }

        public DbSet<csharp_job_finder.Models.Job> Job { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            

            builder.Entity<Job>().HasData
            (
                new Job
                {
                    Id = 1,
                    Title = "Front End",
                    Description = "O cadidato vai trabalhar com React",
                    Salary = 5000,
                    Company = "Beagle Developers",
                    Email = "beagle@gmail.com",
                    CreatedAt = DateTime.Now,
                    NewJob = false
                },

                new Job
                {
                    Id = 2,
                    Title = "ASP NET core MVC",
                    Description = "O cadidato vai trabalhar com Csharp",
                    Salary = 6000,
                    Company = "CodeLovers",
                    Email = "codelovers@gmail.com",
                    CreatedAt = DateTime.Now,
                    NewJob = false
                }
            );

        }
    }
}
