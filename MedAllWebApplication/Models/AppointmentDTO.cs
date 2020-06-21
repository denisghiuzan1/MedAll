using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedAllWebApplication.Models
{
    public class AppointmentDTO
    {
        public int Id { get; set; }
        public string Date { get; set; }

        public virtual PatientDTO Patient { get; set; }
        public virtual DoctorDTO Doctor { get; set; }
        public virtual RoomDTO Room { get; set; }
    }
}
