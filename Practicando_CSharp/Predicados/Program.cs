using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predicados
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<Persona> predicado = EsMayorDeEdad;
            Persona p = new Persona()
            {
                Nombre = "José",
                Edad = 20
            };

            Console.WriteLine(predicado(p));
            Console.Read();
        }

        //Predicados son para metodos que siempre devuelven bool y solo tienen 1 parametro de entrada.
        static bool EsMayorDeEdad(Persona persona)
        {
            return persona.Edad >= 18;
        }
        public class Persona
        {
            public string Nombre { get; set; }
            public int Edad { get; set; }
        }
    }
}
