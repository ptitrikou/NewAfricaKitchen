namespace NewAfrica.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UTILIZ")]
    public partial class UTILIZ
    {
        [Key]
        public long idutiliz { get; set; }

        [StringLength(64)]
        public string codutiliz { get; set; }

        [StringLength(256)]
        public string codutiliz2 { get; set; }

        [StringLength(128)]
        public string nomutiliz { get; set; }

        [StringLength(128)]
        public string prenutiliz { get; set; }

        [StringLength(128)]
        public string loginutiliz { get; set; }

        [StringLength(128)]
        public string passeutiliz { get; set; }

        [StringLength(512)]
        public string nomprenutiliz { get; set; }
    }
}
