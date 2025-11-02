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
        public long iditem { get; set; }

        [StringLength(64)]
        public string coditem { get; set; }

        [StringLength(255)]
        public string designation { get; set; }

        [StringLength(255)]
        public string designdetails { get; set; }

        [StringLength(255)]
        public string designdetails2 { get; set; }

        public decimal prixitem { get; set; }

        public decimal prix1 { get; set; }

        public decimal prix2 { get; set; }

        public decimal prix3 { get; set; }

        public double tauxremiz { get; set; }

        [StringLength(10)]
        public string devise { get; set; }

        public int typeitem { get; set; }

        public int category { get; set; }

        public int nbgarantie { get; set; }

        public int typperiodgarantie { get; set; }

        [StringLength(255)]
        public string capacitappro { get; set; }

        [StringLength(255)]
        public string typeappro { get; set; }

        [StringLength(255)]
        public string detailslivraison { get; set; }

        public int etatitem { get; set; }

        public int etatitem2 { get; set; }

        public int etatitem3 { get; set; }

        public int ordre1 { get; set; }

        public int ordre2 { get; set; }

        public int typpublish { get; set; }

        public DateTime datpublish { get; set; }

        public DateTime datpromo1 { get; set; }

        public DateTime datpromo2 { get; set; }

        [StringLength(255)]
        public string numcontact { get; set; }

        public long payscontact { get; set; }

        [StringLength(255)]
        public string path1 { get; set; }

        [StringLength(255)]
        public string path2 { get; set; }

        [StringLength(255)]
        public string path3 { get; set; }

        public long? idsf { get; set; }

        public virtual SOUSFAMILL SOUSFAMILL { get; set; }
    }
}
