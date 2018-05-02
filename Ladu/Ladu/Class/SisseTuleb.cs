using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ladu
{
    class SisseTuleb
    {
        public long ID { get; set; }
        public long toodeFK { get; set; }
        public Toode toode { get; set; }
        public double Hind { get; set; }
        public int Kogus { get; set; }


        public SisseTuleb() { }
    }
}
