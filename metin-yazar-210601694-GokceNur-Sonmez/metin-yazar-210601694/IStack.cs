using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metin_yazar_210601694
{
    interface  IStack
    {
         object Pop();
         object Peek();
         void Push();
         bool IsEmpty();
    }
}
