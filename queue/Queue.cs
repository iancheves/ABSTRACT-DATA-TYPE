using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queue
{
    class Queue
    {
        public Nodo Start { get; set; }

        public void Enqueue (Nodo nodo)
        {
            if (Start == null) Start = nodo;
            else
            {
                Nodo lastNodo = SearchLastNodo(Start);
                lastNodo.NextNodo = nodo;
            }
        }

        public void Dequeue()
        {
            if (Start != null)
            {
                Start = Start.NextNodo;
            }
        }

        public Nodo SearchLastNodo(Nodo nodo)
        {
            if (nodo.NextNodo == null) return nodo;
            else return SearchLastNodo(nodo.NextNodo);
        }
    }
}
