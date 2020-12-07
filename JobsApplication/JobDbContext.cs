using Microsoft.EntityFrameworkCore;

namespace JobsApplication
{
    public class JobDbContext : DbContext
    {
        public DbSet<JobEntity> Jobs { get; set; }
        public DbSet<JobTitleEntity> JobTitles { get; set; }

        public JobDbContext(DbContextOptions<JobDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<JobEntity>().Property(m => m.DescriptionLength).IsRequired(false);
            modelBuilder.Entity<JobEntity>().Property(m => m.EducationLevel).IsRequired(false);
            modelBuilder.Entity<JobEntity>().Property(m => m.Clicks).IsRequired(false);
            base.OnModelCreating(modelBuilder);
        }
    }
}