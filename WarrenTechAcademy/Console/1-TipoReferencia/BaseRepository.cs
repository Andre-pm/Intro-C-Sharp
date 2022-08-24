using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console._1_TipoReferencia
{
    internal class BaseRepository : IRepository
    {
        List<Pessoa> pessoas;

        public BaseRepository()
        {
            this.pessoas = new List<Pessoa>();
        }
        public string Create(Pessoa p)
        {
            this.pessoas.Add(p);
            return $"Pessoa: {p.Nome} salva com sucesso!";
        }

        public string Delete(int id)
        {
            return $"Pessoa de id: {id} deletada com sucesso!";
        }

        public List<Pessoa> Read()
        {
            return pessoas;
        }

        public string Update(Pessoa p)
        {
            return $"Pessoa: {p.Nome} alterada com sucesso!";
        }
    }
}
