using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ladu
{
    class Toode
    {
        public long ID { get; set; }
        public String Nimi { get; set; }
        public long KategoriaFK { get; set; }
        public Kategooria kategooria { get; set; }
        public int Kogus { get; set; }
        public String KoodToode { get; set; }
        public double Hind { get; set; }
        

        public Toode() { }
    }
}
