using Kutuphane.Entities.ComplexTypes;
using Kutuphane.Entities.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.Business.Abstract
{
    public interface IKitapServis
    {
        List<Kitap> GetAll();
        List<KitapAdYazarTurGetir> KitapYazarTurGetir();
    }
}
