using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list
{
    class List
    {
        public Nodo Start { get; set; }

        public void AddToBeginning (Nodo nodo)
        {
            if (Start == null) Start = nodo;
            else
            {
                Nodo aux = Start;
                Start = nodo;
                Start.NextNodo = aux;
            }
        }

        public void AddToEnd (Nodo nodo)
        {
            if (Start == null) Start = nodo;
            else
            {
                Nodo LastNodo = SearchLastNodo(Start);
                LastNodo.NextNodo = nodo;
            }
        }

        public Nodo SearchLastNodo (Nodo nodo)
        {
            if (nodo.NextNodo == null) return nodo;
            else return SearchLastNodo(nodo.NextNodo);
        }
    }
}
