using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjExOrientacaoObjeto
{
    internal class Pessoa
    {
        //atributos
        String nome;
        String dataNasc;
        String cpf;
        String telefone;

        public Pessoa(string nome, string dataNasc, string cpf, string telefone) //metodo construtor (parametro)
        {
            this.nome = nome;
            this.dataNasc = dataNasc;
            this.cpf = cpf;
            this.telefone = telefone;
        }

        public override string ToString() //retorna os valores do usuario em string
        {
            return "\nO seu nome: " + nome + " data de nascimento: " + dataNasc + " CPF: " + cpf + " e o telefone: " + telefone;
        }

        /*
        public void setNome(string nome)
        {
            this.nome = nome; 
        }
        */

    }
}
