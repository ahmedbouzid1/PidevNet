namespace Pidev.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("pidev.publication")]
    public partial class publication
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public publication()
        {
            commentaire = new HashSet<commentaire>();
        }

        public long id { get; set; }

        public DateTime? dateCreation { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        public int? user { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<commentaire> commentaire { get; set; }

        public virtual user user1 { get; set; }
    }
}
