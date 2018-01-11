using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionesAnonimas
{
    class Program
    {
        static void Main(string[] args)
        {
            //X ES EL VALOR DE ENTRADA, => INDICA EL CUERPO DE LA FUNCION 
            Func<int, int> duplicar = x => { return x * 2; } ;
            Func<int, int, int> multiplicar = (x, y) => { return x * y; };
            Console.WriteLine(duplicar(35));
            Console.WriteLine(multiplicar(2,5));
            Console.Read();
        }
    }
}
