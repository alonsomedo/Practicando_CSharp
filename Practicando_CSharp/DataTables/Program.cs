using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTables
{
    class Program
    {
        static void Main(string[] args)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Nombre", typeof(string));
            dt.Columns.Add("Edad", typeof(int));
            

            dt.Rows.Add("Alonso", 40);
            dt.Rows.Add("Juan", 20);

            var nombre = dt.Rows[0]["Nombre"];

            var resultado = dt.Select("Nombre = 'Alonso'");

            var sumaEdad = dt.Compute("Sum(Edad)", "");

            List<Persona> personas = new List<Persona>()
            {
                new Persona(){ Nombre="Juan",Edad=14,Apellido="Perez",Salario=500},
                new Persona(){ Nombre="Alonso",Edad=35,Apellido="Medina",Salario=800},
                new Persona(){ Nombre="Jose",Edad=16,Apellido="Salvatore",Salario=250},
                new Persona(){ Nombre="Fredy",Edad=22,Apellido="Land",Salario=300},
                new Persona(){ Nombre="Zombie",Edad=14,Apellido="Land",Salario=100},
                new Persona() { Nombre = "Zamsung", Edad = 65, Apellido = "Land",Salario=120 }
            };

            DataTable dtPersonas = new DataTable();

            dtPersonas.Columns.Add("Nombre", typeof(string));
            dtPersonas.Columns.Add("Apellido", typeof(string));
            dtPersonas.Columns.Add("Edad", typeof(int));
            dtPersonas.Columns.Add("Salario", typeof(decimal));

            foreach (Persona persona in personas)
            {
                dtPersonas.Rows.Add(persona.Nombre, persona.Apellido, persona.Edad, persona.Salario);
            }

            var ordenarNombre = dtPersonas.AsEnumerable().OrderByDescending(x => x.Field<string>("Nombre")).AsDataView();

            var mayorDe45 = dtPersonas.AsEnumerable().Where(x => x.Field<int>("Edad") > 45).AsDataView();


            var menoresDe40 = dtPersonas.AsEnumerable().Select(x =>
            new
            {
                Nombre = x.Field<string>("Nombre"),
                Edad = x.Field<int>("Edad")
            }).Where(x => x.Edad < 40).ToList();

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
