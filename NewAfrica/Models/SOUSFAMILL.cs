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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SOUSFAMILL()
        {
            ITEM = new HashSet<ITEM>();
        }

        [Key]
        public long idsf { get; set; }

        [StringLength(128)]
        public string cod { get; set; }

        public string libsf { get; set; }

        public int typsf { get; set; }

        public string detsf { get; set; }

        public int detsf2 { get; set; }

        public int ordresf { get; set; }

        public string imgsf { get; set; }

        public string imgsf2 { get; set; }

        [StringLength(512)]
        public string iconsf { get; set; }

        [StringLength(512)]
        public string iconsf2 { get; set; }

        public int param1 { get; set; }

        public int param2 { get; set; }

        public string param3 { get; set; }

        public short etatsf { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ITEM> ITEM { get; set; }
    }
}
