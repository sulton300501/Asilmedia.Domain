using Asilmedia.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsilMedia.Application.DataTransferObject
{
    public class FilmMakerDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Description { get; set; }
        public Gender Gender { get; set; }
        public string PhotoPath { get; set; }
    }
}
