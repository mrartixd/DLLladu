using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ladu
{
    class Ostukorvi
    {
        public long ID { get; set; }
        public long KlientFK { get; set; }
        public Klient klient { get; set; }
        public long ToodeFK { get; set; }
        public Toode toode { get; set; }
        public int Kogus { get; set; }

        public Ostukorvi() { }

    }
}
