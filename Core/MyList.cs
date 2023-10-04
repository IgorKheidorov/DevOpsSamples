using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses
{
    public class MyList<T>
    {
        Node<T> head;

        public void AddHead(T data)
        {
            if (head == null)
            {
                head = new Node<T>(data, null);
            }
            else 
            {
                Node<T> newNodeInt = new Node<T>(data, head);
                head = newNodeInt;
            }
        
        }

    }
}
