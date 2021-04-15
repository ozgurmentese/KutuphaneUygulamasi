using Kutuphane.Entities.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.DataAccess.Concrete.EntityFramework.Mappings
{
    class KitapMap : EntityTypeConfiguration<Kitap>
    {
        public KitapMap()
        {
            ToTable(@"Kitaplar", "dbo");

            HasKey(x => x.KitapNumarasi);

            Property(x => x.KitapNumarasi).HasColumnName("kitapno");
            Property(x => x.Isbnno).HasColumnName("isbnno");
            Property(x => x.KitapAdi).HasColumnName("kitapadi");
            Property(x => x.YazarNumarasi).HasColumnName("yazarno");
            Property(x => x.TurNumarasi).HasColumnName("turno");
            Property(x => x.SayfaSayisi).HasColumnName("sayfasayisi");
            Property(x => x.Puan).HasColumnName("puan");
        }
    }
}
