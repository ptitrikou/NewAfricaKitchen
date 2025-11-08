using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace NewAfrica.Models
{
    public partial class AdminWebModel : DbContext
    {
        public AdminWebModel()
            : base("name=AdminWeb")
        {
        }

        public virtual DbSet<ITEM> ITEM { get; set; }
        public virtual DbSet<SOUSFAMILL> SOUSFAMILL { get; set; }
        public virtual DbSet<USER> USER { get; set; }
        public virtual DbSet<UTILIZ> UTILIZ { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
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
        }
    }
}
