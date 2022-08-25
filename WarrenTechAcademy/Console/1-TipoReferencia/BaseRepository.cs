using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console._1_TipoReferencia
{
    //Diz que o BaseRepository aceita qualquer tipo, desde que eles herdem de BaseModel
    internal class BaseRepository<T> : IRepository<T> where T : BaseModel
    {
        List<T> pessoas;

        public BaseRepository()
        {
            this.pessoas = new List<T>();
        }
        public string Create(T p)
        {
            this.pessoas.Add(p);
            return $"O dado de id: {p.Id} foi salvo com sucesso!";
        }

        public string Delete(int id)
        {
            return $"Pessoa de id: {id} deletada com sucesso!";
        }

        public List<T> Read()
        {
            return pessoas;
        }

        public string Update(T p)
        {
            return $"O dado de id: {p.Id} foi alterada com sucesso!";
        }
    }
}
