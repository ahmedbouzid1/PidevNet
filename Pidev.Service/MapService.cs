using MyFinance.Data.Infrastructure;
using Pidev.Domain.Entities;
using Service.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pidev.Service
{
    public class MapService : Service<map>, IMapService
    {
        static IDataBaseFactory factory = new DataBaseFactory();
        static IUnitOfWork utk = new UnitOfWork(factory);
        public MapService() : base(utk)
        {

        }


        
    }
}
