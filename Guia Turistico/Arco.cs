using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guia_Turistico
{
    class Arco
    {
        public int origen { get; private set; }
        public int destino { get; private set; }
        public int distancia { get; private set; }

        public Arco(int origen, int destino, int distancia)
        {
            this.origen = origen;
            this.destino = destino;
            this.distancia = distancia;
        }
    }
}
