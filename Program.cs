using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios_ESO_divisivel_por_2_3_5_7
{
    class Program
    {
       /* Fazer um programa que leia vários números(um por vez) e imprima 0 (zero) se o número
          não for múltiplo de 2,3, 5 nem 7. Imprimir 1(um) se o número for múltiplo de 2 ou 3 
          e 2(dois) se o número for múltiplo de 5 e 7. Sair do programa quando for digitado
          o valor -1. (Não é necessária nenhuma consistência ou crítica dos dados).
          */

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine(" Digite um numero qualquer:");
                int a = int.Parse(Console.ReadLine());

                if (a % 2 != 0 && a % 3 != 0 && a % 5 != 0 && a % 7 != 0)
                {
                    Console.WriteLine("0");

                }

                else if (a % 2 == 0 || a % 3 == 0)
                {
                    Console.WriteLine("1");
                }

                else if (a % 5 == 0 || a % 7 == 0)
                {
                    Console.WriteLine("2");

                }

                Console.WriteLine(" Aperte -1 para sair");
                int num = int.Parse(Console.ReadLine());

                if (num == -1)
                {
                    break;
                }



            }
            
        }
    }
}
