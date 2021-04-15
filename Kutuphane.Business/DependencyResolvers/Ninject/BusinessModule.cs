using Kutuphane.Business.Abstract;
using Kutuphane.Business.Concrete;
using Kutuphane.DataAccess.Abstract;
using Kutuphane.DataAccess.Concrete.EntityFramework;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IIslemServis>().To<IslemManager>().InSingletonScope();
            Bind<IIslemDal>().To<EfIslemDal>().InSingletonScope();

            Bind<IKitapServis>().To<KitapManager>().InSingletonScope();
            Bind<IKitapDal>().To<EfKitapDal>().InSingletonScope();

            Bind<IOgrenciServis>().To<OgrenciManager>().InSingletonScope();
            Bind<IOgrenciDal>().To<EfOgrenciDal>().InSingletonScope();

            Bind<IYazarServis>().To<YazarManager>().InSingletonScope();
            Bind<IYazarDal>().To<EfYazarDal>().InSingletonScope();

            Bind<ITurServis>().To<TurManager>().InSingletonScope();
            Bind<ITurDal>().To<EfTurDal>().InSingletonScope();
        }
    }
}
