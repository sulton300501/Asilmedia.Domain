using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsilMedia.Application.DataTransferObject
{
    public class UserDTO
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string RefreshToken { get; set; }
        public DateTime ExpiredDate { get; set; } = DateTime.UtcNow;
        public long RoleId { get; set; }
    }
}
