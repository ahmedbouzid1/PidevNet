using MyFinance.Data.Infrastructure;
using Service.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pidev.data;


namespace Pidev.Service
{
    public class UserService : Service<user>, IUserService
    {

        static IDataBaseFactory factory = new DataBaseFactory();
        static IUnitOfWork utk = new UnitOfWork(factory);
        public UserService() : base(utk)
        {

        }
        
       
        public IEnumerable<user> GetFilmByTitle(string nom)
        {
            return GetMany(f => f.nom.Contains(nom));
        }
    }
}

