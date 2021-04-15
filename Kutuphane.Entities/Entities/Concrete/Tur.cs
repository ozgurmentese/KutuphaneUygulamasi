using Kutuphane.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.Entities.Entities.Concrete
{
    public class Tur:IEntity
    {
        public int Id { get; set; }
        public string TurAdi { get; set; }
    }
}
