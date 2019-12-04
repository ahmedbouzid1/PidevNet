using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Pidev.Domain.Entities
{
    [Table("pidev.map")]
    public class map
    {
        public int MapId { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Lat { get; set; }
        public string Long { get; set; }
        
    }
}
