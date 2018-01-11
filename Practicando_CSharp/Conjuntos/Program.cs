using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> conjunto1 = new HashSet<int>();
            HashSet<int> conjunto2 = new HashSet<int>();
            HashSet<int> conjunto3 = new HashSet<int>();

            conjunto1.Add(5);
            conjunto1.Add(6);
            conjunto1.Add(5);

            conjunto2.Add(5);
            conjunto2.Add(8);

            leerConjunto(conjunto1);
            leerConjunto(conjunto2);


            conjunto1.UnionWith(conjunto2);

            leerConjunto(conjunto1);

            conjunto1.ExceptWith(conjunto2);

            conjunto1.SymmetricExceptWith(conjunto2);

            Console.Read();

        }

        public static void leerConjunto<T>(HashSet<T> valor)
        {
            foreach (var item in valor)
            {
                Console.WriteLine(item);
            }
        }

        public List<T> CreaLista<T>(params T[] pars)
        {
            List<T> list = new List<T>();
            foreach (T elem in pars)
            {
                list.Add(elem);
            }
            return list;
        }
    }
}


