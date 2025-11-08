namespace NewAfrica.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("USER")]
    public partial class USER
    {
        [Key]
        public long iduser { get; set; }

        [StringLength(64)]
        public string coduser { get; set; }

        [StringLength(64)]
        public string titre { get; set; }

        [StringLength(128)]
        public string nomuser { get; set; }

        [StringLength(256)]
        public string prenomsuser { get; set; }

        [StringLength(512)]
        public string nomprenomsuser { get; set; }

        [StringLength(512)]
        public string nomsociete { get; set; }

        [StringLength(64)]
        public string suffixe { get; set; }
    }
}
