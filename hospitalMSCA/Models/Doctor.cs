using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace hospitalMSCA.Models
{
    public class Doctor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DoctorId { get; set; }
        public string? DoctorName { get; set; }
        public string? Speciality { get; set; }
        public int AppointmentId { get; set; }
        public ICollection<Appointment>? Appointment { get; set; }
    }
}