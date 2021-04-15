using Kutuphane.Business.Abstract;
using Kutuphane.DataAccess.Abstract;
using Kutuphane.DataAccess.Concrete.EntityFramework.Mappings;
using Kutuphane.Entities.ComplexTypes;
using Kutuphane.Entities.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.Business.Concrete
{
    public class YazarManager : IYazarServis
    {
        IYazarDal _yazarDal;
        public YazarManager(IYazarDal yazarDal)
        {
            _yazarDal = yazarDal;
        }
        public List<Yazar> GetAll()
        {
            return _yazarDal.GetAll();
        }

        public List<KitapAdYazarTurGetir> YazaraGoreGetir2(int v)
        {
            return _yazarDal.YazaraGoreGetir2(v);
        }
    }
}
