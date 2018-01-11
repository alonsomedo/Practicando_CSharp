using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicando_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var persona = new Persona() { Nombre = "Alonso", Edad = 10 };

            Console.WriteLine("Por Referencia");
            Console.WriteLine("Prevvio al cambio");
            Console.WriteLine(persona.Nombre);
            EditarPersona(persona, "José");
            Console.WriteLine(persona.Nombre);

            Console.WriteLine("Por Referencia");
            Console.WriteLine("Prevvio al cambio");
            int edad;
            //Console.WriteLine(edad);
            EditarEdad(out edad);
            Console.WriteLine(edad);
            Console.Read();

        }


        public static void EditarPersona(Persona persona, string nuevoNombre)
        {
            persona.Nombre = nuevoNombre;
        }

        //out obliga a darle un valor a la variable en el metodo.
        public static void EditarEdad(out int edad)
        {
            edad = 14;
        }
        public class Persona
        {
            public string Nombre { get; set; }
            public int Edad { get; set; }
        }
    }
}
