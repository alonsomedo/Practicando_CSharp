using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            Matriz matrizA = new Matriz(2, 2);
            matrizA[0, 0] = 1;
            matrizA[0, 1] = 6;
            matrizA[1, 0] = 3;
            matrizA[1, 0] = 9;

            Matriz matrizB = new Matriz(2, 2);
            matrizB[0, 0] = 1;
            matrizB[0, 1] = 10;
            matrizB[1, 0] = 16;
            matrizB[1, 0] = 8;

            Matriz matrizSuma = matrizA + matrizB;


            //for (int i = 0; i < 2; i++) // filas
            //{
            //    for (int j = 0; j < 2; j++) // columnas
            //    {
            //        matrizB[i, j] = 1;
            //        Console.WriteLine(matrizB[i, j]);
            //    }
            //}
            Console.Read();

            Matriz matriz = new Matriz(2, 2);
            matriz[0, 0] = 5;
     

        }



        
    }
}
