using Kutuphane.Entities.ComplexTypes;
using Kutuphane.Entities.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.Business.Abstract
{
    public interface IOgrenciServis
    {
        //List<Ogrenci> GetAll();

        List<OgrenciIslemKitapTablolari> OgrenciAdSoyadKitapGetir();
        List<Ogrenci> OgrenciGetir(string text);
        void Add(Ogrenci ogrenci);
        void Delete(Ogrenci ogrenci);
        IList<Ogrenci> GetAll();
        void Update(Ogrenci ogrenci);
    }
}
