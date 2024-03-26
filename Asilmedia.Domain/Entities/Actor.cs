using Asilmedia.Domain.Common;
using Asilmedia.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asilmedia.Domain.Entities
{
    public class Actor:AudiTable
    {

        public string FirstName {  get; set; }
        public string LastName { get; set; }

        public string Description { get; set; }
        public Gender Gender { get; set; }

        public List<Film> Films { get; set; }


    }

}
