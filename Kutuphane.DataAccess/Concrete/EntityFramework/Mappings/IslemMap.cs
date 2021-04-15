using Kutuphane.Entities.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.DataAccess.Concrete.EntityFramework.Mappings
{
   public class IslemMap: EntityTypeConfiguration<Islem>
    {
        public IslemMap()
        {
            ToTable(@"Islemler", "dbo");

            HasKey(x => x.Id);
            Property(x => x.Id).HasColumnName("islemno");
            Property(x => x.OgrenciNumarasi).HasColumnName("ogrno");
            Property(x => x.KitapNumarasi).HasColumnName("kitapno");
            Property(x => x.AlinanTarih).HasColumnName("atarih");
            Property(x => x.VerilenTarih).HasColumnName("vtarih");
        }
    }
}
