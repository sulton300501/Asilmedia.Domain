using Asilmedia.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asilmedia.Domain.Entities
{
    public class User:AudiTable
    {

        public string Name { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string RefreshToken { get; set; }
        public DateTime ExpiredDate { get; set; }
        public long RoleId { get; set; }

        public Role Role { get; set; }



    }
}
