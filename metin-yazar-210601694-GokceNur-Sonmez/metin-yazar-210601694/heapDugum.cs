using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metin_yazar_210601694
{
   public  class heapDugum
    {
        public kelime Kelime;
        public heapDugum sag;
        public heapDugum sol;
        public heapDugum(kelime k)
        {
            this.Kelime = k;
            sag = sol = null;
        }
    }
}
