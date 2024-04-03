using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack
{
    class Stack
    {
        Nodo top;
        public void Push(Nodo nodo)
        {
            if (top == null) top = nodo;
            else
            {
                Nodo aux = Top;
                top = nodo;
                top.NextNode = aux;
            }
        }

        public void Pop()
        {
            if (top != null)
            {
                top = top.NextNode;
            }
        }

        public Nodo Top
        {
            get { return top; }
            set { top = value; }
        }
    }
}
