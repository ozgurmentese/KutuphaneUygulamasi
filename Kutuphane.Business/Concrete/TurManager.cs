using Kutuphane.Business.Abstract;
using Kutuphane.DataAccess.Abstract;
using Kutuphane.Entities.ComplexTypes;
using Kutuphane.Entities.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.Business.Concrete
{
    public class TurManager : ITurServis
    {
        ITurDal _turDal;
        public TurManager(ITurDal turDal)
        {
            _turDal = turDal;
        }
        public List<Tur> GetAll()
        {
            return _turDal.GetAll();
        }

        public List<KitapAdYazarTurGetir> TureGoreGetir2(int v)
        {
            return _turDal.TureGoreGetir2(v);
        }
    }
}
