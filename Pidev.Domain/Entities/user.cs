namespace Pidev.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("pidev.user")]
    public partial class user
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public user()
        {
            commentaire = new HashSet<commentaire>();
            contrat1 = new HashSet<contrat>();
            publication = new HashSet<publication>();
        }

        public int id { get; set; }

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

        [StringLength(255)]
        public string image { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<commentaire> commentaire { get; set; }

        public virtual contrat contrat { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<contrat> contrat1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<publication> publication { get; set; }
    }
}
