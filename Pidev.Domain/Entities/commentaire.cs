namespace Pidev.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("pidev.commentaire")]
    public partial class commentaire
    {
        public long id { get; set; }

        public DateTime? dateCreation { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        public long? id_pub { get; set; }

        public int? id_user { get; set; }

        public virtual user user { get; set; }

        public virtual publication publication { get; set; }
    }
}
