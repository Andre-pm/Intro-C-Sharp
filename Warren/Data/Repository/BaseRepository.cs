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
            using (WarrenContext warrenContext = new WarrenContext())
            {
                list = warrenContext.Set<T>().ToList();
            }
            return list;
        }

        public virtual string Create(T model)
        {
            using (WarrenContext warrenContext = new WarrenContext())
            {
                warrenContext.Set<T>().Add(model);
                warrenContext.SaveChanges();
            }
            return "Criado";
        }

        public virtual string Delete(int id)
        {
            return "Deletado com sucesso";
        }


        public virtual T GetById(int id)
        {
            T entity = null;
            using(WarrenContext warrenContext = new WarrenContext())
            {
                entity = warrenContext.Set<T>().Find(id);
            }
            return entity;
        }

        public virtual string Update(T entity)
        {
            using(WarrenContext warrenContext = new WarrenContext())
            {
                warrenContext.Entry<T>(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                warrenContext.SaveChanges();
            }
            return "Alterado com Sucesso";
        }
    }
}
