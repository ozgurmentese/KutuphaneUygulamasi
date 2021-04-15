using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.Entities.ComplexTypes
{
    public class KitapAdYazarTurGetir
    {
        public string kitapadi { get; set; }
        public string yazaradi { get; set; }
        public string turadi { get; set; }
        public int yazarno { get; set; }
        public int turno { get; set; }
    }
}
