using Kutuphane.DataAccess.Abstract;
using Kutuphane.Entities.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.DataAccess.Concrete.EntityFramework
{
   public class EfIslemDal:EfEntityRepositoryBase<Islem,KutuphaneContext>,IIslemDal
    {
    }
}
