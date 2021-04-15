using Kutuphane.DataAccess.Concrete.EntityFramework.Mappings;
using Kutuphane.Entities.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.DataAccess.Concrete.EntityFramework
{
    public class KutuphaneContext : DbContext
    {
        public KutuphaneContext()
        {
            Database.SetInitializer<KutuphaneContext>(null);
        }

        public DbSet<Islem> Islemler { get; set; }
        public DbSet<Kitap> Kitaplar { get; set; }
        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<Yazar> Yazarlar { get; set; }
        public DbSet<Tur> Turler { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new IslemMap());
            modelBuilder.Configurations.Add(new KitapMap());
            modelBuilder.Configurations.Add(new OgrenciMap());
            modelBuilder.Configurations.Add(new YazarMap());
            modelBuilder.Configurations.Add(new TurMap());
        }
    }
}
