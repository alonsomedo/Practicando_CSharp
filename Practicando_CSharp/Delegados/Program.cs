using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados
{
    class Program
    {
        public delegate string DeEnteroAString(int valor);
        
        static void Main(string[] args)
        {
            DeEnteroAString deEnteroAString = new DeEnteroAString(FuncionRetornaStringMas1);
            Console.WriteLine(deEnteroAString(10));

            Template(deEnteroAString, 10);

            //Otro delegado
            Func<int, string> delegadoFunc = FuncionRetornaString;
            Console.WriteLine("Delegado Func:"+delegadoFunc(10));

            //La diferencia entre func y action es que FUNC exije que se devuelva algo, mientras que action NO.
            Action<string> delegadoAction = Ejemplo;
            delegadoAction("José");
            
            Console.Read();
        }

        public static void Ejemplo(string nombre)
        {
            Console.WriteLine("ProbandoDelegadoAction"+ nombre);
        }
        public static string FuncionRetornaString(int valor)
        {
            return valor.ToString();
        }

        public static string FuncionRetornaStringMas1(int valor)
        {
            return (valor + 1).ToString();
        }

        public static void Template(DeEnteroAString algoritmo, int valor)
        {
            Console.WriteLine("Hacer algo antes del algoritmo");
            Console.WriteLine(algoritmo(valor));
            Console.WriteLine("Hacer algo después del algoritmo");
        }
    }
}
