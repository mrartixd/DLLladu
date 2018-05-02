using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ladu
{
    class Alamkategooria
    {
        public long ID { get; set; }
        public String Nimi { get; set; }
        public long KategooriaFK { get; set; }
        public Kategooria kategooria { get; set; }

        public Alamkategooria() { }
    }
}
