using Kutuphane.Entities.ComplexTypes;
using Kutuphane.Entities.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.DataAccess.Abstract
{
    public interface IYazarDal : IEntityRepository<Yazar>
    {
        List<KitapAdYazarTurGetir> YazaraGoreGetir2(int yazarId);
    }
}
