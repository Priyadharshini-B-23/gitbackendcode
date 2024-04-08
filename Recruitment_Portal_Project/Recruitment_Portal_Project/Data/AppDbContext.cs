using Microsoft.EntityFrameworkCore;
using Recruitment_Portal_Project.Models;

namespace Recruitment_Portal_Project.Data
{
   
        public class AppDbContext : DbContext
        {
            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }


            public DbSet<ProfileModel> Profile { get; set; }
            public DbSet<JobSeekerSignupModel> SeekerSignup { get; set;}


            public DbSet<JobProviderSignupModel> ProviderSignup { get; set; }


            public DbSet<JobDetailsModel> JobDetails { get; set; }


            public DbSet<ApplicationDetailsModel> ApplicationDetails { get; set; }

        public DbSet<PdfDocumentModel> PdfDocument { get; set; } = default!;
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<JobSeekerSignupModel>()
                .HasIndex(u => u.JobSeekerEmailId)
                .IsUnique();
            builder.Entity<JobProviderSignupModel>()
                .HasIndex(u=>u.JobProviderEmailId)
                .IsUnique();
            //builder.Entity<JobDetailsModel>()
            //    .HasIndex(u => u.Status)
            //    .IsUnique();
        }
    }
    }

