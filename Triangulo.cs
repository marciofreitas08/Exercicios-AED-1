using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificaTriangulo2
{
    class Triangulo
    {
        public int ladoA;
        public int ladoB;
        public int ladoC;

        public void verificaTriangulo()
        {               
                if ((ladoA < ladoB + ladoC) && (ladoB < ladoA + ladoC) && (ladoC < ladoB + ladoA))
                {
                    Console.WriteLine(" Forma um triangulo:");
                    
                }
                else
                {
                    Console.WriteLine(" Nao forma um triangulo");
                }
            
            

        }
    }
}
