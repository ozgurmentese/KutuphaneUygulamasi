using Kutuphane.Business.Abstract;
using Kutuphane.DataAccess.Abstract;
using Kutuphane.Entities.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.Business.Concrete
{
    public class IslemManager : IIslemServis
    {
        IIslemDal _islemServis;
        public IslemManager(IIslemDal islemServis)
        {
            _islemServis = islemServis;
        }
        public void Add(Islem islem)
        {
            _islemServis.Add(islem);
        }

        public void Delete(Islem islem)
        {
            _islemServis.Delete(islem);
        }

        public List<Islem> GetAll()
        {
            return _islemServis.GetAll();
        }

        public void Update(Islem islem)
        {
            _islemServis.Update(islem);
        }
    }
}
