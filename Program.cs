using System;

namespace Marcio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            Console.WriteLine("Entre com numero:");
            numero = int.Parse(Console.ReadLine());
            while (numero > 0)
            {
                Console.WriteLine(" Vou subtrair 2 do numero escolhido");
                numero = numero - 2;
                Console.WriteLine(" O numero agora é: {0}",numero);
            }
        }
    }
}
