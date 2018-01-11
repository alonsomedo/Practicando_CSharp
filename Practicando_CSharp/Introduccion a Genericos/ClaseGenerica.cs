using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduccion_a_Genericos
{
    public class ClaseGenerica<T>
    {
        public List<T> Milista { get; set; }

        public ClaseGenerica()
        {
            Milista = new List<T>();
        }
        public void Agregar(T valor)
        {
            Milista.Add(valor);
        }
    }
}
