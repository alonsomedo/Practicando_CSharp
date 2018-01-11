using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicando_CSharp
{
    class Params
    {
        static void Main(string[] args)
        {
            Console.Write(CalcularPromedio(4, 5, 6, 7, 8));
            string categoria = Console.ReadLine();
            if (categoria == CategoriaArbol.categoria1_Arbol)
            {
                Console.WriteLine("Primera rama del arbol");
            }
            else if (categoria == CategoriaArbol.categoria2_Arbol)
            {
                Console.WriteLine("Segunda rama del arbol");
            }
            Console.Read();
        }

        public static double CalcularPromedio(params int[] numeros)
        {
            double suma = 0;
            foreach (int numero in numeros)
            {
                suma += numero;
            }
            suma = suma / numeros.Length;
            return suma;


        }
        public static class CategoriaArbol
        {
            public const string categoria1_Arbol = "CATEGORIA_1";
            public const string categoria2_Arbol = "CATEGORIA_2";
        }
    }
}
