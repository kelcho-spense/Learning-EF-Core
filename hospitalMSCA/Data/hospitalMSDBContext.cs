using hospitalMSCA.Models;
using Microsoft.EntityFrameworkCore;

namespace hospitalMSCA.Data
{
    public class hospitalMSDBContext : DbContext
    {
        public hospitalMSDBContext() { }

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=tcp:teach2giveserver.database.windows.net,1433;Initial Catalog=hospitaldb;Persist Security Info=False;User ID=teach2giveadmin;Password=YourStrong!Passw0rd;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }
    }
}
