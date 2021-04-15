using Kutuphane.DataAccess.Concrete.EntityFramework.Mappings;
using Kutuphane.Entities.ComplexTypes;
using Kutuphane.Entities.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.Business.Abstract
{
    public interface IYazarServis
    {
        List<Yazar> GetAll();
        List<KitapAdYazarTurGetir> YazaraGoreGetir2(int v);
    }
}
