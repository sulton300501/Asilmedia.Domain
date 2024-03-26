using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asilmedia.Domain.Exceptions.Films
{
    public class FilmMakerNotFound:Exception
    {
        public FilmMakerNotFound():base("FilmMaker Not Found") { }
    }
}
