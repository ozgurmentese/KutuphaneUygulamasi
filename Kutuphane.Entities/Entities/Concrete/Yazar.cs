using Kutuphane.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.Entities.Entities.Concrete
{
    public class Yazar:IEntity
    {
        public int YazarNumarasi { get; set; }
        public string YazarAd { get; set; }
        public string YazarSoyad { get; set; }

    }
}
