using Kutuphane.Entities.ComplexTypes;
using Kutuphane.Entities.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.DataAccess.Abstract
{
    public interface ITurDal : IEntityRepository<Tur>
    {
        List<KitapAdYazarTurGetir> TureGoreGetir2(int v);
    }
}
