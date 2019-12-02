namespace Pidev.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("pidev.contrat")]
    public partial class contrat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public contrat()
        {
            user = new HashSet<user>();
        }

        public int id { get; set; }

        [StringLength(255)]
        public string dateDebutC { get; set; }

        [StringLength(255)]
        public string dateFinC { get; set; }

        public int salaire { get; set; }

        public int? typeContrat { get; set; }

        public int? user_id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<user> user { get; set; }

        public virtual user user1 { get; set; }
    }
}
