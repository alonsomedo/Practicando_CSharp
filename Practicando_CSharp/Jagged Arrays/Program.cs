using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jagged_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //El 2 indica el numero de arreglos que va tener nuestra coleccion de arreglos
            int[][] jaggedArray = new int[2][];
            jaggedArray[0] = new int[4];
            jaggedArray[0][0] = 6;
            jaggedArray[0][1] = 3;
            jaggedArray[0][2] = 3;
            jaggedArray[0][3] = 3;

            jaggedArray[1] = new int[]
            {
                15,6,7,8,9,2,1,4
            };

            for (int i = 0; i < jaggedArray.GetLength(0); i++)
            {
                string join = string.Join(",", jaggedArray[i]);
                Console.WriteLine(join);
            }
            Console.Read();
        }
    }
}
