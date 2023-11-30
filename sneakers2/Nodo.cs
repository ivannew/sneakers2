using sneakers2.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sneakers2
{
    public class Nodo
    {
        public Sneaker Sneaker { get; set; }
        public Nodo Siguiente { get; set; }

        public Nodo(Sneaker sneaker)
        {
            Sneaker = sneaker;
            Siguiente = null;
        }
    }

}
