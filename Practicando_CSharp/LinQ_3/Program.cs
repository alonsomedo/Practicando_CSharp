using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>()
            {
                1,2,3,4,5
            };

            var suma = numeros.Sum();

            //Funciones agregadas 

            var min = numeros.Min();
            var max = numeros.Max();
            var promedio = numeros.Average();

            //Funcion Agregate

            var producto = numeros.Aggregate((anterior, actual) => anterior * actual);

            List<Persona> personas = new List<Persona>()
            {
                new Persona(){ Nombre="Juan",Edad=14,Apellido="Perez",Salario=500},
                new Persona(){ Nombre="Alonso",Edad=35,Apellido="Medina",Salario=800},
                new Persona(){ Nombre="Jose",Edad=16,Apellido="Salvatore",Salario=250},
                new Persona(){ Nombre="Zombie",Edad=22,Apellido="Land",Salario=300},
                new Persona(){ Nombre="Zombie",Edad=14,Apellido="Land",Salario=100},
                new Persona() { Nombre = "Zombie", Edad = 35, Apellido = "Land",Salario=120 }
            };

            var totalSalario = personas.Sum(x => x.Salario);

            var miObjeto = new
            {
                totalSalario_1 = personas.Sum(x => x.Salario),
                count = personas.Count()
            };


            //Funciones agregadas

            var minSalario = personas.Min(x => x.Salario);
            var maxSalario = personas.Max(x => x.Salario);
            var promedioEdad = personas.Average(x => x.Edad);

            Console.Read();
        }
        class Persona
        {
            public String Nombre { get; set; }
            public int Edad { get; set; }
            public String Apellido { get; set; }
            public Double Salario { get; set; }
        }
    }
}
