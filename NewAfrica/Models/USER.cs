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

        public int sexeuser { get; set; }

        [StringLength(256)]
        public string imaguser1 { get; set; }

        [StringLength(256)]
        public string imaguser2 { get; set; }

        public bool statut { get; set; }

        public int statut2 { get; set; }

        [StringLength(128)]
        public string loginuser { get; set; }

        [StringLength(128)]
        public string passeuser { get; set; }

        public string adressuser { get; set; }

        public DateTime datecreat { get; set; }

        [StringLength(256)]
        public string depart { get; set; }

        [StringLength(256)]
        public string servic { get; set; }

        [StringLength(256)]
        public string poste { get; set; }

        public long idville { get; set; }

        [StringLength(256)]
        public string nomville { get; set; }

        public long idpays { get; set; }

        public int typuser { get; set; }

        public int typuser2 { get; set; }

        [StringLength(255)]
        public string gpsuser { get; set; }

        [StringLength(128)]
        public string email1 { get; set; }

        [StringLength(128)]
        public string email2 { get; set; }

        [StringLength(128)]
        public string email3 { get; set; }

        [StringLength(4)]
        public string indic1 { get; set; }

        [StringLength(4)]
        public string indic2 { get; set; }

        [StringLength(4)]
        public string indic3 { get; set; }

        [StringLength(4)]
        public string indic4 { get; set; }

        [StringLength(4)]
        public string indic5 { get; set; }

        [StringLength(128)]
        public string tel1 { get; set; }

        [StringLength(128)]
        public string tel2 { get; set; }

        [StringLength(128)]
        public string tel3 { get; set; }

        [StringLength(128)]
        public string tel4 { get; set; }

        [StringLength(128)]
        public string tel5 { get; set; }

        [StringLength(256)]
        public string social1 { get; set; }

        [StringLength(256)]
        public string social2 { get; set; }

        [StringLength(256)]
        public string social3 { get; set; }

        [StringLength(256)]
        public string social4 { get; set; }

        [StringLength(256)]
        public string social5 { get; set; }

        [StringLength(255)]
        public string details1 { get; set; }

        [StringLength(255)]
        public string details2 { get; set; }

        public int details3 { get; set; }

        public long idgroup { get; set; }

        public long idutiliz { get; set; }

        public string datalink { get; set; }

        public string datalink2 { get; set; }
    }
}
