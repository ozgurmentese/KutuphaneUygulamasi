using Kutuphane.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.Entities.Entities.Concrete
{
    public class Islem:IEntity
    {
        public int Id { get; set; }
        public int OgrenciNumarasi { get; set; }
        public int KitapNumarasi { get; set; }
        public DateTime AlinanTarih { get; set; }
        public DateTime VerilenTarih { get; set; }
    }
}
