using Pidev.data;
using Service.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pidev.Service
{
    public interface IUserService : IService<user>
    {

        
        IEnumerable<user> GetFilmByTitle(string nom);
    }
}
