using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace hospitalMSCA.Models
{
    public class Patient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PatientId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set;} 
        public int RoomId { get; set; } // foreign key
        public Room? Room { get; set; } // navigation property
        public int AppointmentId { get; set; } // foreign key
        public ICollection<Appointment>? Appointments { get; set; } // navigation property
    }
}