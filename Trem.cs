using System;
using System.Globalization;

namespace exercicio_aula_classe_trem_vagao
{
    class Trem
    {
        private int velocidade;
        private double carga_max_locomotiva;
        private Vagao n1;
        private Vagao n2;
        private Vagao n3;
        private string nome;

       
        public Trem(string n, int vel,double carga_max, Vagao a, Vagao b, Vagao c)
        {
           this.carga_max_locomotiva = carga_max;
           this.velocidade = vel;
           this.n1 = a;
           this.n2 = b;
           this.n3 = c;
           this.nome = n;

            if (cargaTotal() > carga_max_locomotiva)
            {
                Console.WriteLine();
                Console.WriteLine( this.nome + " : Nao suporta peso dos vagoes, transferir carga:");
            }

            else
            {
                Console.WriteLine( this.nome + " : OK, saindo da doca: " );
                Console.WriteLine();
            }


        }

        public int getvelocidade()
        {
            return velocidade;
        }

        public void setvelocidade(int v)
        {
            velocidade = v;
        }

        public double getcarga_max_locomotiva()
        {
            return carga_max_locomotiva;
        }

        public void setcarga_max_locomotiva(double c)
        {
            carga_max_locomotiva = c;
        }

        public Vagao getn1()
        {
            return  n1;
        }

        public void setn1(Vagao n)
        {
            n1 = n;
        }

        public Vagao getn2()
        {
            return n2;
        }

        public void setn2(Vagao n)
        {
            n2 = n;
        }

        public Vagao getn3()
        {
            return n2;
        }

        public void setn3(Vagao n)
        {
            n2 = n;
        }

        public double cargaTotal()
        {
            return  n1.carga + n2.carga + n3.carga;
        }


       
       
        public override string ToString()
        {
            return nome + " Vel Max: " + velocidade + " / " + " Carga max do trem: "
                   + carga_max_locomotiva + " / " + n1.ToString()
                   + " / " + n2.ToString() + " / " + n3.ToString();

        }

    }
}
