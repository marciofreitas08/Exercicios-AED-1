using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_aula_classe_trem_vagao
{
    class Program
    {
        static void Main(string[] args)
        {

            /* - Crie um programa em C# para representar um trem de carga. Cada trem possui apenas 3 vagões,
               a informação da sua velocidade e a carga máxima suportada pela locomotiva. Cada vagão possui
               uma descrição do material presente e a quantidade carregada (em toneladas). 

               - Devem ser criadas classes para a representação do trem e dos vagões.
               - Crie as classes e pelo menos 2 atributos de tipos diferentes em cada classe. 
               - Crie 1 método construtor com parâmetros e um sem parâmetros para cada classe. 
               - Crie pelo menos 1 par de métodos get/set para cada classe.
               - Crie o método CargaRestante que retorna a quantidade de carga que o trem ainda consegue suportar
               com base na carga carregada em seus vagões. 
               - Crie o método bool TransferirCargaPara(Trem destino) que permite transferir a carga de um trem para
               outro mantendo a quantidade carregada em cada vagão. Só deve ser possível realizar a transferência se
               o trem de destino estiver vazio e tiver capacidade para receber a carga. O método deve indicar como
               retorno se a transferência foi realizada com sucesso ou não.
               - Crie um método main para fazer uso da classe criada com pelo menos 2 objetos Trem e uso de 2 dos
               métodos  (diferentes de get/set) criados.
               */
            Vagao v1 = new Vagao( "V1","carvao", 80.0);
            Vagao v2 = new Vagao("V2", "minerio", 40.0);
            Vagao v3 = new Vagao("V3","coque", 40.0);

            Trem num1 = new Trem ("Trem 1",30, 200, v1, v2, v3);

            Vagao k1 = new Vagao("K1","carvao", 10.0);
            Vagao k2 = new Vagao("K2","minerio", 10.0);
            Vagao k3 = new Vagao("K3","coque", 40.0);

            Trem num2 = new Trem("Trem 2",30, 20, k1, k2, k3);

            v1.TransferirCarga(k1, 20.0);

            Console.WriteLine();

            Console.WriteLine( num1);

            Console.WriteLine();
                                 
            Console.WriteLine( num2);

           
                 


        }
    }
}
