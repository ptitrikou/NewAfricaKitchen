namespace NewAfrica.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ITEM")]
    public partial class ITEM
    {
        [Key]
        [Column(Order = 0)]
        public long iditem { get; set; }

        [StringLength(64)]
        public string coditem { get; set; }

        [StringLength(255)]
        public string designation { get; set; }

        [StringLength(255)]
        public string designdetails { get; set; }

        [StringLength(255)]
        public string designdetails2 { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal prixitem { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal prix1 { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal prix2 { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal prix3 { get; set; }

        [Key]
        [Column(Order = 5)]
        public double tauxremiz { get; set; }

        [StringLength(10)]
        public string devise { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int etatitem { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ordre1 { get; set; }

        [StringLength(255)]
        public string path1 { get; set; }

        [StringLength(255)]
        public string path2 { get; set; }

        [StringLength(255)]
        public string path3 { get; set; }

        public long? idsf { get; set; }
    }
}
