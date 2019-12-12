using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_estaticos_calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Crie uma classe chamada CalculadoraInt que possua como atributos 2 operandos
             * e possua as seguintes operações (métodos):

               Métodos não estático para as operações Soma, Subtração, Divisão,
               Multiplicação para a realização das operações básicas com os operandos da
               calculadora.
               Método estático chamado Soma que recebe 2 valores inteiros como parâmetros
               e retorna a soma desses dois valores. Crie também o teste de utilização do
               método dentro do método main.
               Método não estático chamado Maior que retorna o maior dos dois operandos.
               Crie também o teste de utilização do método dentro do método main.
               */

            Calculadora numero = new Calculadora(2,3);
            numero.Soma();

        }
    }
}
