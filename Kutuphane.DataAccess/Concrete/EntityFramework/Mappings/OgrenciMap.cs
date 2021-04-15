using Kutuphane.Entities.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.DataAccess.Concrete.EntityFramework.Mappings
{
    class OgrenciMap:EntityTypeConfiguration<Ogrenci>
    {
        public OgrenciMap()
        {
            ToTable(@"Ogrenciler", "dbo");

            HasKey(x => x.Numarasi);

            Property(x => x.Numarasi).HasColumnName("ogrno");
            Property(x => x.Adi).HasColumnName("ograd");
            Property(x => x.Soyadi).HasColumnName("ogrsoyad");
            Property(x => x.Cinsiyet).HasColumnName("cinsiyet");
            Property(x => x.DogumTarihi).HasColumnName("dtarih");
            Property(x => x.Sinif).HasColumnName("sinif");
        }
    }
}
