using System;
using System.Globalization;

namespace exercicio_aula_classe_trem_vagao
{
    class Vagao
    {
        private string nome;
        private string material;
        public double carga;
        private double max_vagao = 50;
        private double resto_carga;

        public Vagao(string n, string mat, double car)
        {
            this.nome = n;
            this.material = mat;
            if (car > max_vagao)
            {
                resto_carga = car - max_vagao;
                this.carga = max_vagao;
                Console.WriteLine();
                Console.WriteLine("Caregamos ate o maximo do vagao " + this.nome + " e sobrou " + resto_carga + " t de "
                    + material + " no patio:");
                Console.WriteLine();

            }
            else
            {
                this.carga = car;
                Console.WriteLine(" Vagao " + this.nome + " peso OK ");
                Console.WriteLine();
            }

            
           
            

        }

        public Vagao()
        {
            material = "pelotas";
            
        }


        public string getmaterial()
        {
            return material;
        }

        public void setmaterial(string m)
        {
            material = m;
        }

        public double getcarga()
        {
            return carga;
        }

        public void setcarga(double c)
        {           
             carga = c;
           
        }
              

        public bool TransferirCarga(Vagao destino, double carga)
        {
                      
                if ((destino.max_vagao - destino.carga) >= carga)
                {
                    if (this.carga >= carga)
                    {
                        if (this.material == destino.material)
                        {
                            destino.carga += carga;
                            this.carga -= carga;
                            return true;
                        }
                    }

                }
            
                return false;

        }     
            
         
        public override string ToString()
        {
            return  nome + " Material: " + material + " / Peso vagão: " + carga ;

        }


    }
}
