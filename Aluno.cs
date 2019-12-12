using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaAlunos1
{
    class Aluno
    {
        private string _nome;
        public string nome
        {
            get
            {
                return this._nome;
            }
            set
            {
                this._nome = value;
            }

        }

        private double _nota1;
        public double nota1
        {
            get
            {
                return this._nota1;

            }
            set
            {
                this._nota1 = value;
            }
        }

        private double _nota2;
        public double nota2
        {
            get
            {
                return this._nota2;

            }
            set
            {
                this._nota2 = value;
            }
        }

        private double _nota3;
        public double nota3
        {
            get
            {
                return this._nota3;

            }
            set
            {
                this._nota3 = value;
            }
        }

        private double _nota4;
        public double nota4
        {
            get
            {
                return this._nota4;

            }
            set
            {
                this._nota4 = value;
            }
        }

        public double media()
        {
            return (this._nota1 + this._nota2 + this._nota3 + this._nota4) / 4;
        }

        public void exibeMedia()
        {
            Console.Clear();
            Console.WriteLine(" Nome:" + this._nome);
            Console.WriteLine(" Nota1:" + this._nota1);
            Console.WriteLine(" Nota2:" + this._nota2);
            Console.WriteLine(" Nota3:" + this._nota3);
            Console.WriteLine(" Nota4:" + this._nota3);
            Console.WriteLine(" Media das notas" + this.media());
        }






    }
}
