using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metin_yazar_210601694
{
    public class Node
    {
        public object data;
        public Node next;
        public Node(object dat)
        {
            data = dat;
            next = null;
        }
    }
}
