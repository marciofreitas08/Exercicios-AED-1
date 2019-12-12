using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios_do_ssatela_soft
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" num1 ");
            int num1 = int.Parse(Console.ReadLine());

            if (num1 % 2 == 0)
            {
                Console.WriteLine(" numero par:");

            }

            else
            {
                Console.WriteLine(" numero impar:");
            }

        }
    }
}
