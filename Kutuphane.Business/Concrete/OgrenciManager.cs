using Kutuphane.Business.Abstract;
using Kutuphane.Business.Aspects.Postsharp;
using Kutuphane.Business.Utilities;
using Kutuphane.Business.ValidationRules.FluentValidation;
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
    public class OgrenciManager : IOgrenciServis
    {
        IOgrenciDal _ogrenciDal;
        public OgrenciManager(IOgrenciDal ogrenciDal)
        {
            _ogrenciDal = ogrenciDal;
        }

        [FluentValidationAspect(typeof(OgrenciValidator))]
        public void Add(Ogrenci ogrenci)
        {
            ValidationTools.Validate(new OgrenciValidator(),ogrenci);
            _ogrenciDal.Add(ogrenci);
        }

        public void Delete(Ogrenci ogrenci)
        {
            _ogrenciDal.Delete(ogrenci);
        }

        public IList<Ogrenci> GetAll()
        {
            return _ogrenciDal.GetAll();
        }

        public List<OgrenciIslemKitapTablolari> OgrenciAdSoyadKitapGetir()
        {
            return _ogrenciDal.OgrenciAdSoyadKitapGetir();
        }

        public List<Ogrenci> OgrenciGetir(string text)
        {
            return _ogrenciDal.GetAll(o=>o.Adi.ToLower().Contains(text.ToLower()));
        }

        [FluentValidationAspect(typeof(OgrenciValidator))]
        public void Update(Ogrenci ogrenci)
        {
            _ogrenciDal.Update(ogrenci);
        }
    }
}
