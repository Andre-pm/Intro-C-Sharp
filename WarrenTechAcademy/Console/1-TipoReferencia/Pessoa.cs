using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console._1_TipoReferencia
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        public Pessoa(string nome, string sobrenome)
        {
            this.Nome= nome;
            this.Sobrenome= sobrenome;
        }

        public void Saudacao()
        {
            System.Console.WriteLine($"Olá, {this.Nome} {this.Sobrenome}");
        }
    }
}
