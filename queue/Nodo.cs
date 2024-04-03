using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queue
{
    class Nodo
    {
        public String Name { get; }
        public Nodo NextNodo { get; set; }

        public Nodo(String Name)
        {
            this.Name = Name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
