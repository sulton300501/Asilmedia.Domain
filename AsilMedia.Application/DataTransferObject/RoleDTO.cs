using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsilMedia.Application.DataTransferObject
{
    public class RoleDTO
    {
        public string Name { get; set; }

        public List<long> Permissions { get; set; }
    }
}
