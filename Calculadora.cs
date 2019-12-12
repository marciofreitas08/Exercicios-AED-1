using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_estaticos_calculadora
{
    class Calculadora
    {
        private int num1, num2;

        public int getNum1()
        {
            return num1;
        }
        public int getNum2()
        {
            return num2;
        }

        public void setNum1(int n)
        {
            num1 = n;
        }

        public void setAno(int n2)
        {
            num2 = n2;
        }

        public Calculadora(int n,int n2)
        {
            num1 = n;

            num2 = n2;
        }

        public int Soma()
        {
             return num1 + num2;
        }

        public int Subtracao()
        {
            if(num1 < num2)
            {
                 return num2 - num1;
            }
            else
            {
                return num1 - num2;

            }
           
           
        }
        public int Divisao()
        {
            return num1 / num2;
        }

        public int Multiplicacao()
        {
            return num1 * num2;
        }

       






    }
}
