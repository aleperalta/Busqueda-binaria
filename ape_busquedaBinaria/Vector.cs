using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ape_busquedaBinaria
{
    class Vector
    {
        public int[] v;
        public int comparaciones { get; private set; }
        static Random rand = new Random();

        public Vector(int vTam)
        {
            v = new int[vTam];
        }

        public void llenar(int vLimite)
        {
            for (int i = 0; i < v.Length; i++)
                v[i] = rand.Next(0, vLimite + 1);

            ordenar();
        }

        public void ordenar()
        {
            Array.Sort(v);
        }

        public int buscar(int vBuscar)
        {
            int lSup = v.Length, lInf = 0, media = (lSup - lInf)/2;
            comparaciones = 0;

            if (vBuscar == v[media])
            {
                comparaciones++;
                return media;
            }
            else
                return buscarRecursivo(lSup, lInf, media, vBuscar);

        }

        public int buscarRecursivo(int lSup, int lInf, int media, int vBuscar)
        {
            comparaciones++;
            if (vBuscar == v[media])
                return media;
            else if (vBuscar > v[media])
            {
                lInf = media;
                media += (lSup - lInf) / 2;                             //Saca el nuevo valor de la media

                if (lInf + 1 == lSup)                                   //Si los límites son seguidos, no se puede sacar la media, entonces no se encontró el número
                    return -1;
                else
                    return buscarRecursivo(lSup, lInf, media, vBuscar);
            }
            else                                                        //Si vBuscar < v[media]
            {
                lSup = media;
                media -= (lSup - lInf) / 2;                             //Saca el nuevo valor de la media

                if (lInf + 1 == lSup)                                   //Si los límites son seguidos, no se puede sacar la media, entonces no se encontró el número
                    return -1;
                else
                    return buscarRecursivo(lSup, lInf, media, vBuscar);
            }
        }

        public string mostrar()
        {
            string vec = "";

            for (int i = 0; i < v.Length; i++)
                vec += v[i].ToString() + Environment.NewLine;

            return vec;
        }
    }
}
