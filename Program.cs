using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenando_inteiros
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                num.Add(Convert.ToInt32(Console.ReadLine()));
            }
            num.Sort();
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(num[i]);
            }
            Console.ReadKey();
        }
    }
}
