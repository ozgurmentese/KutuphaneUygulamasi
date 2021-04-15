using Kutuphane.Entities.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.DataAccess.Concrete.EntityFramework.Mappings
{
    public class TurMap:EntityTypeConfiguration<Tur>
    {
        public TurMap()
        {
            ToTable(@"Turler", @"dbo");

            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("turno");
            Property(x => x.TurAdi).HasColumnName("turadi");
        }
    }
}
