using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asilmedia.Domain.Exceptiona.Films
{
    public class FilmNotFoundExeption : Exception
    {

        public FilmNotFoundExeption() : base("Film Not Found") { }
        

    }
}
