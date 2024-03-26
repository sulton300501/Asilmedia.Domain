using Asilmedia.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsilMedia.Application.Helpers
{
    public interface IJWTService
    {
        public string GenerateAccessToken(User user);
    }
}
