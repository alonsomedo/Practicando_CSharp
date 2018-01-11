using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
{
    public class Matriz
    {
        private int[,] _data;
        public Matriz(int filas, int columnas)
        {
            _data = new int[filas, columnas];
        }

        public int Filas { get { return _data.GetLength(0); } }
        public int Columnas { get { return _data.GetLength(1); } }
        //Indexador
        public int this[int fila, int columna]
        {
            get { return _data[fila, columna]; }
            set { _data[fila, columna] = value; }
        }

        public static Matriz operator +(Matriz a, Matriz b)
        {
            if (a.Filas != b.Filas || a.Columnas != b.Columnas)
            {
                throw new ApplicationException("Las matrices deben ser de la misma dimensión");
            }

            Matriz resultado = new Matriz(a.Filas, a.Columnas);

            for (int i = 0; i < a.Filas; i++)
            {
                for (int j = 0; j < a.Columnas; j++)
                {
                    resultado[i, j] = a[i, j] + b[i, j];
                }
            }
            return resultado;
        }


    }
}
