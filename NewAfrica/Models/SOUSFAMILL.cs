namespace NewAfrica.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SOUSFAMILL")]
    public partial class SOUSFAMILL
    {
        [Key]
        [Column(Order = 0)]
        public long idsf { get; set; }

        [StringLength(128)]
        public string cod { get; set; }

        public string libsf { get; set; }

        public string detsf { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ordresf { get; set; }

        public string imgsf { get; set; }

        public string imgsf2 { get; set; }
    }
}
