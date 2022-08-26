using Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : BaseModel
    {
        public string Create(T entity)
        {
            return "Criado com sucesso";
        }

        public string Delete(int id)
        {
            return "Deletado com sucesso";
        }

        public List<T> GetAll()
        {
            List<T> list = new List<T>();
            return list;
        }

        public T GetById(int id)
        {
            T entity = null;
            return entity;
        }

        public string Update(T entity)
        {
            return "Atualizado com sucesso";
        }
    }
}
