using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace NewAfrica.Models
{
    public partial class AdminWebModel : DbContext
    {
        public AdminWebModel()
            : base("name=WebModel")
        {
        }

        public virtual DbSet<DATADECOMPTS> DATADECOMPTS { get; set; }
        public virtual DbSet<DECOMPTS> DECOMPTS { get; set; }
        public virtual DbSet<ITEM> ITEM { get; set; }
        public virtual DbSet<SOUSFAMILL> SOUSFAMILL { get; set; }
        public virtual DbSet<USER> USER { get; set; }
        public virtual DbSet<UTILIZ> UTILIZ { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DATADECOMPTS>()
                .Property(e => e.codelemen)
                .IsUnicode(false);

            modelBuilder.Entity<DATADECOMPTS>()
                .Property(e => e.nomelemen)
                .IsUnicode(false);

            modelBuilder.Entity<DATADECOMPTS>()
                .Property(e => e.descript)
                .IsUnicode(false);

            modelBuilder.Entity<DATADECOMPTS>()
                .Property(e => e.descript2)
                .IsUnicode(false);

            modelBuilder.Entity<DATADECOMPTS>()
                .Property(e => e.nomintern)
                .IsUnicode(false);

            modelBuilder.Entity<DATADECOMPTS>()
                .Property(e => e.pref1)
                .IsUnicode(false);

            modelBuilder.Entity<DATADECOMPTS>()
                .Property(e => e.pref2)
                .IsUnicode(false);

            modelBuilder.Entity<DATADECOMPTS>()
                .Property(e => e.descript4)
                .IsUnicode(false);

            modelBuilder.Entity<DATADECOMPTS>()
                .Property(e => e.pref3)
                .IsUnicode(false);

            modelBuilder.Entity<DECOMPTS>()
                .Property(e => e.codelemen)
                .IsUnicode(false);

            modelBuilder.Entity<DECOMPTS>()
                .Property(e => e.descript)
                .IsUnicode(false);

            modelBuilder.Entity<ITEM>()
                .Property(e => e.coditem)
                .IsUnicode(false);

            modelBuilder.Entity<ITEM>()
                .Property(e => e.designation)
                .IsUnicode(false);

            modelBuilder.Entity<ITEM>()
                .Property(e => e.designdetails)
                .IsUnicode(false);

            modelBuilder.Entity<ITEM>()
                .Property(e => e.designdetails2)
                .IsUnicode(false);

            modelBuilder.Entity<ITEM>()
                .Property(e => e.prixitem)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ITEM>()
                .Property(e => e.prix1)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ITEM>()
                .Property(e => e.prix2)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ITEM>()
                .Property(e => e.prix3)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ITEM>()
                .Property(e => e.devise)
                .IsUnicode(false);

            modelBuilder.Entity<ITEM>()
                .Property(e => e.capacitappro)
                .IsUnicode(false);

            modelBuilder.Entity<ITEM>()
                .Property(e => e.typeappro)
                .IsUnicode(false);

            modelBuilder.Entity<ITEM>()
                .Property(e => e.detailslivraison)
                .IsUnicode(false);

            modelBuilder.Entity<ITEM>()
                .Property(e => e.numcontact)
                .IsUnicode(false);

            modelBuilder.Entity<ITEM>()
                .Property(e => e.path1)
                .IsUnicode(false);

            modelBuilder.Entity<ITEM>()
                .Property(e => e.path2)
                .IsUnicode(false);

            modelBuilder.Entity<ITEM>()
                .Property(e => e.path3)
                .IsUnicode(false);

            modelBuilder.Entity<SOUSFAMILL>()
                .Property(e => e.cod)
                .IsUnicode(false);

            modelBuilder.Entity<SOUSFAMILL>()
                .Property(e => e.libsf)
                .IsUnicode(false);

            modelBuilder.Entity<SOUSFAMILL>()
                .Property(e => e.detsf)
                .IsUnicode(false);

            modelBuilder.Entity<SOUSFAMILL>()
                .Property(e => e.imgsf)
                .IsUnicode(false);

            modelBuilder.Entity<SOUSFAMILL>()
                .Property(e => e.imgsf2)
                .IsUnicode(false);

            modelBuilder.Entity<SOUSFAMILL>()
                .Property(e => e.iconsf)
                .IsUnicode(false);

            modelBuilder.Entity<SOUSFAMILL>()
                .Property(e => e.iconsf2)
                .IsUnicode(false);

            modelBuilder.Entity<SOUSFAMILL>()
                .Property(e => e.param3)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.coduser)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.titre)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.nomuser)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.prenomsuser)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.nomprenomsuser)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.nomsociete)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.suffixe)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.imaguser1)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.imaguser2)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.loginuser)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.passeuser)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.adressuser)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.depart)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.servic)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.poste)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.nomville)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.gpsuser)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.email1)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.email2)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.email3)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.indic1)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.indic2)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.indic3)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.indic4)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.indic5)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.tel1)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.tel2)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.tel3)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.tel4)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.tel5)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.social1)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.social2)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.social3)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.social4)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.social5)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.details1)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.details2)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.datalink)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.datalink2)
                .IsUnicode(false);

            modelBuilder.Entity<UTILIZ>()
                .Property(e => e.codutiliz)
                .IsUnicode(false);

            modelBuilder.Entity<UTILIZ>()
                .Property(e => e.codutiliz2)
                .IsUnicode(false);

            modelBuilder.Entity<UTILIZ>()
                .Property(e => e.nomutiliz)
                .IsUnicode(false);

            modelBuilder.Entity<UTILIZ>()
                .Property(e => e.prenutiliz)
                .IsUnicode(false);

            modelBuilder.Entity<UTILIZ>()
                .Property(e => e.loginutiliz)
                .IsUnicode(false);

            modelBuilder.Entity<UTILIZ>()
                .Property(e => e.passeutiliz)
                .IsUnicode(false);

            modelBuilder.Entity<UTILIZ>()
                .Property(e => e.nomprenutiliz)
                .IsUnicode(false);

            modelBuilder.Entity<UTILIZ>()
                .Property(e => e.libposte)
                .IsUnicode(false);

            modelBuilder.Entity<UTILIZ>()
                .Property(e => e.adress)
                .IsUnicode(false);

            modelBuilder.Entity<UTILIZ>()
                .Property(e => e.telephon1)
                .IsUnicode(false);

            modelBuilder.Entity<UTILIZ>()
                .Property(e => e.telephon2)
                .IsUnicode(false);

            modelBuilder.Entity<UTILIZ>()
                .Property(e => e.mail)
                .IsUnicode(false);

            modelBuilder.Entity<UTILIZ>()
                .Property(e => e.imgutiliz1)
                .IsUnicode(false);

            modelBuilder.Entity<UTILIZ>()
                .Property(e => e.imgutiliz2)
                .IsUnicode(false);

            modelBuilder.Entity<UTILIZ>()
                .Property(e => e.libville)
                .IsUnicode(false);
        }
    }
}
