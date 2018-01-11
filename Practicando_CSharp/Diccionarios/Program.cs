using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diccionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> extensiones = new Dictionary<string, string>();
            extensiones.Add("Excel", ".xlsx");
            extensiones.Add("Word", ".docx");
            extensiones.Add("PowerPoint", ".pptx");

            Console.WriteLine(extensiones["Excel"]);
            //validamos si existe la llave
            if (extensiones.ContainsKey("Word"))
            {
                Console.WriteLine(extensiones["Word"]);
            }

            extensiones.Remove("Word");

            foreach (string key in extensiones.Keys)
            {
                Console.WriteLine(key);
            }
            
            Console.Read();
        }
    }
}
