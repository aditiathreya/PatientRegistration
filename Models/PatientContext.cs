using Microsoft.EntityFrameworkCore;
namespace patient.Models
{
public class PatientContext :DbContext
    {
        
            public PatientContext(DbContextOptions<PatientContext> options) : base(options)
            {
            }
            public DbSet<Patient> patients { get; set; }
        
    }
}