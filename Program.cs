using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança1
{
    class Program
    {
        static void Main(string[] args)
        {
            Fisica fulano = new Fisica(1291728, 'M', "Estudante", "Jão", "02/03/2002", "São Paulo", "jaosp@gmail.com");

            Console.WriteLine(fulano);
        }
    }
}
