using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metin_yazar_210601694
{
    public class stackll 
    {
        public Node head = null;
        public int toplam = 0;
        public object Pop()
        {
            Node temp;
            if (head == null)
            {
                return 0;
            }
            temp = head;
            head = head.next;
            return temp.data;
            
        }
        public object Peek()
        {
            if (head == null)
            {
                return 0;
            }
            return head.data;
        }
        public void Push(object item)
        {
            Node node = new Node(item);
            if(head==null)
            {
                node.next = null;
            }
            else
            {
                node.next = head;
            }
            head = node;
            toplam++;
        }
        public bool IsEmpty()
        {
            return head == null ? true : false;
        }
        
        
    }
}
