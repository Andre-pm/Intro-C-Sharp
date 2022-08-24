using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console._1_TipoReferencia
{
    internal class PessoaFisicaRepository
    {
        //CRUD - Create, Read, Update, Delete
        private List<PessoaFisica> pessoas;

        public PessoaFisicaRepository()
        {
            this.pessoas = new List<PessoaFisica>();
        }

        public string Create(PessoaFisica pessoa)
        {
            this.pessoas.Add(pessoa);
            return $"Usuário {pessoa.Nome} salvo com sucesso!";
        }

        public List<PessoaFisica> Read()
        {
            return pessoas;
        }

        public string Update(PessoaFisica pessoa)
        {
            return $"Pessoa: {pessoa.Nome} alterada com sucesso!";
        }

        public string Delete(int id)
        {
            return $"Pessoa de id: {id} deletada com sucesso!";
        }

    }
}
