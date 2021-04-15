﻿using Kutuphane.DataAccess.Abstract;
using Kutuphane.Entities.ComplexTypes;
using Kutuphane.Entities.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.DataAccess.Concrete.EntityFramework
{
    public class EfTurDal : EfEntityRepositoryBase<Tur, KutuphaneContext>, ITurDal
    {
        public List<KitapAdYazarTurGetir> TureGoreGetir2(int v)
        {
            using (KutuphaneContext context = new KutuphaneContext())
            {
                var result = from k in context.Kitaplar
                             join y in context.Yazarlar
                             on k.YazarNumarasi equals y.YazarNumarasi
                             join t in context.Turler
                             on k.TurNumarasi equals t.Id
                             where t.Id == v
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
