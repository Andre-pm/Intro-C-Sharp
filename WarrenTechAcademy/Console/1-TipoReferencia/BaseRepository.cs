using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console._1_TipoReferencia
{
    //Implementa o IRepository e diz que o BaseRepository aceita qualquer tipo, desde que eles herdem de BaseModel
    //Isso acontece pois para exibir o Id que é mostrado é necessário que sempre tenha um id na entidade que estou recebendo
    internal class BaseRepository<T> : IRepository<T> where T : BaseModel
    {
        List<T> entidade;

        public BaseRepository()
        {
            this.entidade = new List<T>();
        }
        public virtual  string Create(T p)
        {
            this.entidade.Add(p);
            return $"O dado de id: {p.Id} foi salvo com sucesso!";
        }

        public virtual string Delete(int id)
        {
            return $"Dado de id: {id} foi deletado com sucesso!";
        }

        public virtual List<T> Read()
        {
            return entidade;
        }

        public virtual string Update(T p)
        {
            return $"O dado de id: {p.Id} foi alterada com sucesso!";
        }
    }
}
