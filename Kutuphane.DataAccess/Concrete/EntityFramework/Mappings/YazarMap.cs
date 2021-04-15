using Kutuphane.Entities.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.DataAccess.Concrete.EntityFramework.Mappings
{
    public class YazarMap:EntityTypeConfiguration<Yazar>
    {
        public YazarMap()
        {
            ToTable(@"Yazarlar", @"dbo");

            HasKey(x => x.YazarNumarasi);
            Property(x => x.YazarNumarasi).HasColumnName("yazarno");
            Property(x => x.YazarAd).HasColumnName("yazarad");
            Property(x => x.YazarSoyad).HasColumnName("yazarsoyad");

        }
    }
}
