using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedAllWebApplication.Models
{
    public class DoctorDTO
    {
        public DoctorDTO()
        {
            this.Patients = new HashSet<PatientDTO>();
            this.Rooms = new HashSet<RoomDTO>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Specialization { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PatientDTO> Patients { get; set; }
        public virtual AppointmentDTO Appointment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RoomDTO> Rooms { get; set; }
    }
}
