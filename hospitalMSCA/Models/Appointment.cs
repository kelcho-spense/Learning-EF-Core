using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospitalMSCA.Models
{
    public class Appointment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]   
        public int AppointmentId { get; set; }
        public string? AppointmentDate { get; set; }
        public string? AppointmentTime { get; set; }
        public string? AppointmentReason { get; set; }
        public int PatientId { get; set; } // foreign key
        public Patient? Patient { get; set; } // navigation property
        public int DoctorId { get; set; } // foreign key
        public Doctor? Doctor { get; set; } // navigation property
    }
}
