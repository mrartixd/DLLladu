using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ladu
{
    class SisseTulebArv
    {
        public long ID { get; set; }
        public long ValdFK { get; set; }
        public SisseTuleb Vald { get; set; }
        public DateTime Date { get; set; }
        public long PakkujaFK { get; set; }
        public Pakkuja pakkuja { get; set; }


       public SisseTulebArv() { }

    }
}
