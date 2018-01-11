using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>()
            {
                3,5,7,8,2,-3,-100,523,6,22
            };
            //Take tomar solo los 2 primeros
            var primeros2Elementos = numeros.Take(2).ToList();

            //Salta los primeros 10 elementos
            var saltarElemenos = numeros.Skip(1).Take(3).ToList();

            //TakeWhile: toma los elemntos que cumplen con la condicion hasta encontrarse con uno que NO-
            var listado = numeros.TakeWhile(x => x < 6).ToList();

            //SkipWhile: ignoramos los primeros elementos que cumplen con la condicion
            var listado2 = numeros.SkipWhile(x => x < 6).ToList();

            //GroupBy
            var grupo = numeros.GroupBy(x => Math.Abs(x % 2));

            foreach (var clase in grupo)
            {
                Console.WriteLine("Numeros cuyo residuo es: " + clase.Key);
                foreach (var numero in clase)
                {
                    Console.WriteLine(numero);
                }
                Console.WriteLine(" ");
            }

            List<Persona> personas = new List<Persona>()
            {
                new Persona(){ Nombre="Juan",Edad=14,Apellido="Perez"},
                new Persona(){ Nombre="Alonso",Edad=35,Apellido="Medina"},
                new Persona(){ Nombre="Jose",Edad=16,Apellido="Salvatore"},
                new Persona(){ Nombre="Zombie",Edad=22,Apellido="Land"},
                new Persona(){ Nombre="Zombie",Edad=14,Apellido="Land"},
                new Persona() { Nombre = "Zombie", Edad = 35, Apellido = "Land" }
            };

            var personas_2 = personas.GroupBy(x =>
            {
                if (x.Edad > 20)
                {
                    return "Mayor que 20";
                }
                else {
                    return "Menores que 21";
                }
            });

            foreach (var grupoPersonas in personas_2)
            {
                Console.WriteLine("Grupo de:" + grupoPersonas.Key + "... cantidad:" + grupoPersonas.Count());
                foreach (var persona in grupoPersonas)
                {
                    Console.WriteLine(persona.Nombre);
                }
            }

            List<int> listado1 = new List<int>()
            {
                3,5,7,8,2,-3,-100,523,6,22
            };
            //All y Any devuelven boleanos
            //All devuelve false si existe algun elemento que no cumpla la condicion.
            var sonParesTodos1 = listado1.All(x => x % 2 == 0); 

            //Any devuelve true si existe al menos 1 elemento que cumple la condicion.
            var existeAlgunImpar = listado1.Any(x => x % 2 == 0);


            Console.Read();
        }

        class Persona {
            public String Nombre { get; set; }
            public int Edad { get; set; }
            public String Apellido { get; set; }
        }
    }
}
