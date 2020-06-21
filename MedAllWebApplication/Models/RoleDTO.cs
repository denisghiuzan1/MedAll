using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedAllWebApplication.Models
{
    public class RoleDTO
    {
        public RoleDTO()
        {
            this.Users = new HashSet<UserDTO>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserDTO> Users { get; set; }
    }
}
