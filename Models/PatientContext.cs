using Microsoft.EntityFrameworkCore;
namespace patient.Models
{
public class PatientContext :DbContext
    {
        
            public PatientContext(DbContextOptions<PatientContext> options) : base(options)
            {
            }
          /*  protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Patient>().HasKey(c=>new{c.patient_id,c.email});
            }*/
            public DbSet<Patient> patients { get; set; }
        
    }
}