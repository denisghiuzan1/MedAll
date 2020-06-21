using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedAllWebApplication.Models
{
    public class RoomDTO
    {
        public RoomDTO()
        {
            this.Doctors = new HashSet<DoctorDTO>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DoctorDTO> Doctors { get; set; }
        public virtual AppointmentDTO Appointment { get; set; }
    }
}
