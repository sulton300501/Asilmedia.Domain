using Asilmedia.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsilMedia.Application.DataTransferObject
{
    public class FilmDTO
    {


        public string Title { get; set; }
        public string? Description { get; set; }
        public long FilmMakerId { get; set; }
        public int AgeRestriction { get; set; }
        public int PublishedYear { get; set; }

        public string PhotoPath { get; set; }
        public string VideoPath { get; set; }

       
        public List<long> Genres { get; set; }
        public List<long> Actors { get; set; }

    }
}
