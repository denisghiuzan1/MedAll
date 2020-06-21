using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedAllWebApplication.Models
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }

        public virtual RoleDTO Role { get; set; }
    }
}
