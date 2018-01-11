using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduccion_a_Genericos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>() { 1, 2, 3, 4, 5 };
            numeros.Add(6);
            List<Persona> personas = new List<Persona>()
            {
                new Persona(){ Nombre="Jose",Edad =14},
                new Persona(){ Nombre="Alonso",Edad=15 }
            };

            ClaseGenerica<string> micoleccion = new ClaseGenerica<string>();
            micoleccion.Agregar("Jose");
            micoleccion.Agregar("Alonso");
            foreach (string item in micoleccion.Milista)
            {
                Console.WriteLine(item);
            }
            Console.Read();
                
        }
    }

    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
    }

    public class Empresa
    {
        public string RazonSocial { get; set; }
        public int RUC { get; set; }
    }

    //public static void CambiarDatosPersona<T>(T valor)
    //{
    //}
    //public static void CambiarDatosEmpresa(Empresa empresa)
    //{
        
    //}
}
