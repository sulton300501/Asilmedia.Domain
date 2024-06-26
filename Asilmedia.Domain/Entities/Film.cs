﻿using Asilmedia.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asilmedia.Domain.Entities
{
    public class Film:AudiTable
    {
        public string Title { get; set; }
        public string? Description { get; set; }
        public long FilmMakerId { get; set; }
        public int AgeRestriction { get; set; }
        public int PublishedYear { get; set; }

        public string? PhotoPath { get; set; }
        public string? VideoPath { get; set; }

        public FilmMaker? FilmMaker { get; set; }

        public List<Genre> Genres { get; set; }
        public List<Actor> Actors { get; set; }

    }
}
