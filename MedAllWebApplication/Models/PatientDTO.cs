using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedAllWebApplication.Models
{
    public class PatientDTO
    {
        public PatientDTO()
        {
            this.Doctors = new HashSet<DoctorDTO>();
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumer { get; set; }
        public string Email { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DoctorDTO> Doctors { get; set; }
        public virtual AppointmentDTO Appointment { get; set; }
    }
}
