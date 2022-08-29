using Data.Context;
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
        public virtual List<T> GetAll()
        {
            List<T> list = new List<T>();
            using (MovieAPiContext movieContext = new MovieAPiContext())
            {
                list = movieContext.Set<T>().ToList();
            }
            return list;
        }

        public virtual string Create(T entity)
        {
            using (MovieAPiContext movieContext = new MovieAPiContext())
            {
                movieContext.Set<T>().Add(entity);
                movieContext.SaveChanges();
            }
            return "Filme adicionado";
            
        }

        public virtual string Delete(int id)
        {
            using (MovieAPiContext movieContext = new MovieAPiContext())
            {
                movieContext.Entry<T>(this.GetById(id)).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                movieContext.SaveChanges();
            }
            return "Filme deletado com sucesso";
        }

        public virtual T GetById(int id)
        {
            T entity = null;
            using (MovieAPiContext movieContext = new MovieAPiContext())
            {
                entity = movieContext.Set<T>().Find(id);
            }
            return entity;
        }

        public virtual string Update(T entity)
        {
            using (MovieAPiContext movieContext = new MovieAPiContext())
            {
                movieContext.Entry<T>(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                movieContext.SaveChanges();
            }
            return "Filme atualizado com sucesso";
        }
    }
}
