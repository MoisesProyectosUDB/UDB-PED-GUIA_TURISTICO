using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guia_Turistico
{
    class Floyd
    {
        private List<Vertice> vertices;
        private int[,] matriz;
        private int[,] rutas;
        private List<int> ruta;

        public Floyd(List<Vertice> vertices, int[,] matriz)
        {
            this.vertices = vertices;
            this.matriz = matriz;            
            int cant = vertices.Count;
            rutas = new int[cant, cant];
            ruta = new List<int>();
            for (int i = 0; i < cant; i++)
            {
                for (int j = 0; j < cant; j++)
                {
                    rutas[i, j] = -1;
                }
            }
        }

        public void ObtenerRutas()
        {
            int cant = vertices.Count;
            for (int k = 0; k < cant; k++)
            {
                for (int i = 0; i < cant; i++)
                {                    
                    for (int j = 0; j < cant; j++)
                    {                        
                        if (matriz[i, j] > matriz[i, k] + matriz[k, j])
                        {
                            matriz[i, j] = matriz[i, k] + matriz[k, j];
                            rutas[i, j] = k;
                        }
                    }
                }
            }
        }

        //public string Ruta(int origen, int destino)
        //{            
        //    int intermedio = rutas[origen, destino];
        //    if (intermedio == -1)
        //        return " ";
        //    else
        //        return Ruta(origen, intermedio) + intermedio.ToString() + Ruta(intermedio, destino);
        //}

        public List<int> Ruta(int origen, int destino)
        {
            ruta.Clear();
            int vertice = rutas[origen, destino];
            while (vertice != -1)
            {
                ruta.Add(vertice);
                vertice = rutas[origen, vertice];
            }
            ruta.Add(origen);
            ruta.Reverse();
            return ruta;
        }
    }
}
