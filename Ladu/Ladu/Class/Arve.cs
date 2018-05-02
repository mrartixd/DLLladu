using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ladu
{
    class Arve
    {
        public long ID { get; set; }
        public long OstukorviFK { get; set; }
        public Ostukorvi ostukorvi { get; set; }
        public DateTime Date { get; set; }


        public Arve() { }
    }
}
