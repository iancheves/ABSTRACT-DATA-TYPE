using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list
{
    class Nodo
    {
        public String Name { get; set; }
        public Nodo NextNodo { get; set; }

        public Nodo(String Nombre)
        {
            this.Name = Nombre;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
