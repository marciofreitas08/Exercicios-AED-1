using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaAlunos1
{
    class Program
    {
        //calcular a media de um aluno informar 4 notas
        static void Main(string[] args)
        {
            Aluno obj = new Aluno();
            String entrada = " ";
            Console.WriteLine(" Calcula a media de um aluno:");
            Console.Write(" Aluno:");
            entrada = Console.ReadLine();
            obj.nome = entrada;

            Console.Write(" Nota1:");
            entrada = Console.ReadLine();
            obj.nota1 = Convert.ToDouble(entrada);

            Console.Write(" Nota2:");
            entrada = Console.ReadLine();
            obj.nota2 = Convert.ToDouble(entrada);

            Console.Write(" Nota3:");
            entrada = Console.ReadLine();
            obj.nota3 = Convert.ToDouble(entrada);

            Console.Write(" Nota4:");
            entrada = Console.ReadLine();
            obj.nota4 = Convert.ToDouble(entrada);

            obj.exibeMedia();
        }
    }
}
