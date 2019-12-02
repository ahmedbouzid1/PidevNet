using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Pidev.Presentation.Models
{

    public class User
    {
        [StringLength(255)]
        public string addresse { get; set; }

        [StringLength(255)]
        public string cin { get; set; }

        public DateTime? dat_naiss { get; set; }

        [StringLength(255)]
        public string email { get; set; }

        [StringLength(255)]
        public string login { get; set; }

        [StringLength(255)]
        public string nom { get; set; }

        [StringLength(255)]
        public string password { get; set; }

        [StringLength(255)]
        public string prenom { get; set; }

        [StringLength(255)]
        public string role { get; set; }

        public int? contrat_id { get; set; }

        public string ImageUrl { get; set; }

    }
}