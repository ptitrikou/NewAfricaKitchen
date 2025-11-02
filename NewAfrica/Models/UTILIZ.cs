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

        public long idstr { get; set; }

        [StringLength(128)]
        public string libposte { get; set; }

        [StringLength(255)]
        public string adress { get; set; }

        [StringLength(48)]
        public string telephon1 { get; set; }

        [StringLength(48)]
        public string telephon2 { get; set; }

        [StringLength(128)]
        public string mail { get; set; }

        [StringLength(256)]
        public string imgutiliz1 { get; set; }

        [StringLength(256)]
        public string imgutiliz2 { get; set; }

        public int typeutiliz { get; set; }

        public int typutiliz2 { get; set; }

        public int etatutiliz { get; set; }

        public long idville { get; set; }

        [StringLength(256)]
        public string libville { get; set; }

        public long idpays { get; set; }
    }
}
