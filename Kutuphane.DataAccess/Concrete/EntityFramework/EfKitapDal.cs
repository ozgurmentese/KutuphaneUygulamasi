using Kutuphane.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kutuphane.Entities.Entities.Concrete;
using Kutuphane.Entities.ComplexTypes;

namespace Kutuphane.DataAccess.Concrete.EntityFramework
{
    public class EfKitapDal : EfEntityRepositoryBase<Kitap, KutuphaneContext>, IKitapDal
    {
        public List<KitapAdYazarTurGetir> KitapYazarTurGetir()
        {
            //select O.ograd,O.ogrsoyad,K.kitapadi
            //from Ogrenciler O join Islemler I
            //on O.ogrno = I.ogrno join Kitaplar K
            //on K.kitapno = I.kitapno
            using (KutuphaneContext context =new KutuphaneContext())
            {
                var result = from k in context.Kitaplar
                             join y in context.Yazarlar
                             on k.YazarNumarasi equals y.YazarNumarasi
                             join t in context.Turler
                             on k.TurNumarasi equals t.Id
                             select new KitapAdYazarTurGetir
                             {
                                 kitapadi = k.KitapAdi,
                                 yazaradi = y.YazarAd,
                                 turadi = t.TurAdi,
                                 turno = t.Id,
                                 yazarno = y.YazarNumarasi
                             };
                return result.ToList();
            }
        }
    }
}
