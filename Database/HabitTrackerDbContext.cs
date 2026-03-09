using HabitTracker.DataModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Net.NetworkInformation;
using System.Reflection.Emit;

namespace HabitTracker.Database
{
    public class HabitTrackerDbContext : IdentityDbContext
    {
        public HabitTrackerDbContext(DbContextOptions<HabitTrackerDbContext> options) : base(options) { }

        public DbSet<DailyStatistics> DailyStatistics { get; set; }
        public DbSet<WeeklyStatistics> WeeklyStatistics { get; set; }
        public DbSet<MonthlyStatistics> MonthlyStatistics { get; set; }
        public DbSet<EarlyStatistics> EarlyStatistics { get; set; }
        public DbSet<Habit> Habits { get; set; }
        public DbSet<HabitCompletion> HabitCompletions { get; set; }
        public DbSet<HabitSchedule> HabitSchedules { get; set; }
        public DbSet<Pomodoro> Pomodors { get; set; }
        public DbSet<DataModels.Task> Tasks { get; set; }
        public DbSet<TaskGroup> TaskGroups { get; set; }
        public DbSet<TaskGroupMember> TaskGroupMembers { get; set; }
        public DbSet<TaskProgressEvent> TaskProgressEvents { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Habit entity
            builder.Entity<Habit>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                     .HasDefaultValueSql("NEWID()");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.JobTitle)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(e => e.Status)
                    .WithMany(s => s.JobApplications)
                    .HasForeignKey(e => e.StatusId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.Property(e => e.ApplicationDate)
                    .IsRequired();

                entity.HasOne(e => e.ContractType)
                    .WithMany(ct => ct.JobApplications)
                    .HasForeignKey(e => e.ContractTypeId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.Property(e => e.CreatedAt)
                    .HasDefaultValueSql("GETUTCDATE()");

                entity.HasOne(e => e.FinancialInformation)
                    .WithMany(fi => fi.JobApplications)
                    .HasForeignKey(e => e.FinancialInformationId)
                    .OnDelete(DeleteBehavior.Restrict);
            });


            // Status entity
            modelBuilder.Entity<Status>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                //entity.Property(e => e.SortOrder)
                //.IsRequired();

                // Seed data 
                entity.HasData(
                    new Status { Id = Guid.NewGuid(), Name = "Wishlist" },
                    new Status { Id = Guid.NewGuid(), Name = "Applied" },
                    new Status { Id = Guid.NewGuid(), Name = "Interviewing" },
                    new Status { Id = Guid.NewGuid(), Name = "Offer" },
                    new Status { Id = Guid.NewGuid(), Name = "Rejected" }
                );

            });


            // interview entity
            modelBuilder.Entity<Interview>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(e => e.JobApplication)
                    .WithMany(ja => ja.Interviews)
                    .HasForeignKey(e => e.JobApplicationId)
                    .OnDelete(DeleteBehavior.Restrict);
            });


            // FinancialInformation entity
            modelBuilder.Entity<FinancialInformation>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Salary)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Currency)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.SalaryType)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.TypeOfEmployment)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            // ContractType entity
            modelBuilder.Entity<ContractType>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                // Seed data 
                entity.HasData(
                    new ContractType { Id = Guid.NewGuid(), Name = "Full-Time" },
                    new ContractType { Id = Guid.NewGuid(), Name = "Part-Time" },
                    new ContractType { Id = Guid.NewGuid(), Name = "Freelance" },
                    new ContractType { Id = Guid.NewGuid(), Name = "Internship" }
                );
            });


            // JobApplicationHistory entity
            modelBuilder.Entity<JobApplicationHistory>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.UpdatedAt)
                    .HasDefaultValueSql("GETUTCDATE()")
                    .IsRequired();

                entity.HasOne(e => e.JobApplication)
                    .WithMany()
                    .HasForeignKey(e => e.JobApplicationId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(e => e.Status)
                    .WithMany()
                    .HasForeignKey(e => e.StatusId)
                    .OnDelete(DeleteBehavior.Restrict);
            });


            // ApplicationUser configured by identity
            modelBuilder.Entity<ApplicationUser>(entity =>
            {
                entity.Property(u => u.FirstName).HasMaxLength(100);
                entity.Property(u => u.FullName).HasMaxLength(150);
            });
        }
    }
}
