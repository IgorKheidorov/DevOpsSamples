using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses
{
    public class Node<T>
    {
        public Node<T> Next;
        public T Data;

        public Node(T data, Node<T> nextNode)
        {
            Next = nextNode;
            Data = data;        
        }

    }
}
