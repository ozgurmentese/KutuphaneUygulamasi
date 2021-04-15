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
    public class KitapManager : IKitapServis
    {
        IKitapDal _kitapDal;
        public KitapManager(IKitapDal kitapDal)
        {
            _kitapDal = kitapDal;
        }
        public List<Kitap> GetAll()
        {
           return _kitapDal.GetAll();
        }

        public List<KitapAdYazarTurGetir> KitapYazarTurGetir()
        {
            return _kitapDal.KitapYazarTurGetir();
        }
    }
}
