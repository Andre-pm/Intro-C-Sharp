using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console._1_TipoReferencia
{
    internal class PessoaFisica : Pessoa
    {
        public string CPF { get; set; }
        public PessoaFisica(string nome, string sobrenome) : base(nome, sobrenome)
        {
        }
    }
}
