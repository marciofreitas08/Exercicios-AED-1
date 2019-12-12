using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança1
{
    class Fisica : Pessoa
    {
        private double _cpf;
        private char _sexo;
        private string _ocupacao;

        public Fisica(double cpf, char sexo, string ocupacao, string nome, string data, string cidade, string email) : base(nome, data, cidade, email)
        {
            _cpf = cpf;
            _sexo = sexo;
            _ocupacao = ocupacao;
        }

        public Fisica()
        {
            _cpf = 12345678901;
            _sexo = 'M';
            _ocupacao = "Estudante";
        }

        public double getCpf()
        {
            return _cpf;
        }

        public void setCpf(double cpf)
        {
            _cpf = cpf;
        }

        public char getSexo()
        {
            return _sexo;
        }

        public void setSexo(char sexo)
        {
            _sexo = sexo;
        }

        public string getOcupacao()
        {
            return _ocupacao;
        }

        public void setOcupacao(string ocupacao)
        {
            _ocupacao = ocupacao;
        }

        public override string ToString()
        {
            return "Nome: " + getNome() + " | Data de nascimento/criação: " + getDataNasc() + " | Cidade: " + getCidade() + " | E-mail: " + getEmail() + "CPF: " + _cpf + " | Sexo: " + _sexo + " | Ocupação: " + _ocupacao;
        }
    }
}
