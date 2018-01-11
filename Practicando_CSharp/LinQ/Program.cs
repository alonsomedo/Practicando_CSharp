using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>()
            {
                3,5,7,8,2,-3,-100,523,6,22
            };

            numeros = numeros.Where(x => x > 0).ToList();

            var numerosPares = numeros.Where(x => x > 0 && x % 2 == 0).ToList();

            //Where con indice, me trae los elementos que esten en un indice par
            var paresIndice = numeros.Where((x,indice) => indice % 2 == 0).ToList();

            List<int> numbers = new List<int>()
            {
                3,5,7,8,2,-3,-100,523,6,22
            };

            //First
            var primerElemento = numbers.First();
            var primerElementDefault = numbers.FirstOrDefault(x=>x%2==0);

            //Reverse en un rango
            numbers.Reverse(1, 8);
            //Ordenamos 
            numbers = numbers.Where(x => x > 0).OrderBy(x=>x).ToList();

            
           
            List<Persona> personas = new List<Persona>()
            {
                new Persona(){ Nombre = "Felipe", Edad=99, Salario=5 },
                new Persona(){ Nombre = "Claudia", Edad=35,Salario=7 },
                new Persona(){ Nombre = "Mateo", Edad=17, Salario=10 },
                new Persona(){ Nombre = "Patricia", Edad=12, Salario=1 },
                new Persona(){ Nombre = "Ana", Edad=22, Salario=5 },
            };

            var nombre = personas.Where(x => x.Edad < 18).Select(x => x.Nombre).FirstOrDefault();

            //Proyeccion: permite tomar valores (nombre,edad) y proyectarlos en un nuevo objeto
            var nombreProyeccion = personas.Where(x => x.Edad < 18).Select(x => new Persona()
            {
                Edad = x.Edad,
                Nombre = x.Nombre
            }).FirstOrDefault();

            //OrderBy
            var personaMenorEdad = personas.OrderBy(x => x.Edad).FirstOrDefault(x => x.Edad < 18);
            personas = personas.OrderBy(x => x.Edad).ThenBy(x=>x.Nombre).ToList();









            string cadena = "j ose ; pedro;pepe;  ;  asdd ; ";
            List<string> destinatarios = new List<string>();
            destinatarios = cadena.Split(';').ToList();
            destinatarios = destinatarios.Select(x=>x.Trim()).ToList();
            destinatarios.RemoveAll(x => string.IsNullOrWhiteSpace(x));
            

            foreach (var item in destinatarios)
            {
                Console.WriteLine(item);
            }

            Console.Read();
        }

    }
}
