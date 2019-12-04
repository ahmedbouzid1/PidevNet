using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pidev.Presentation.Models
{
    public class MapModel
    {
        public int MapId { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Lat { get; set; }
        public string Long { get; set; }

    }
}