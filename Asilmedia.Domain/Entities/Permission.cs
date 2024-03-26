using Asilmedia.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asilmedia.Domain.Entities
{
    public class Permission:BaseEntity
    {
        public string Name { get; set; }
        public List<Role> Roles { get; set; }
    }
}
