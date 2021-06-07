using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Guia_Turistico
{
    class Vertice
    {
        public Point p { get; private set; }
        public string nombre {get; private set; }
        public int index { get; set; }

        public Vertice(Point p, string nombre, int index)
        {
            this.p = p;
            this.nombre = nombre;
            this.index = index;
        }
    }
}
