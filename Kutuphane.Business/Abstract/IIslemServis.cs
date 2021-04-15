using Kutuphane.Entities.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.Business.Abstract
{
    public interface IIslemServis
    {
        List<Islem> GetAll();
        void Add(Islem islem);
        void Update(Islem islem);
        void Delete(Islem islem);
    }
}
