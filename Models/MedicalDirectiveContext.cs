using Microsoft.EntityFrameworkCore;

namespace MedicalDirectiveSystem.Models
{
    public class MedicalDirectiveContext : DbContext
    {
        public MedicalDirectiveContext(DbContextOptions<MedicalDirectiveContext> options)
            : base(options)
        {
        }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<AdvanceDirective> AdvanceDirectives { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Patient>().ToTable("Patient");
            modelBuilder.Entity<AdvanceDirective>().ToTable("AdvanceDirective");
        }
    }
}
