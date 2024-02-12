using AlbumData.Abstract;
using PlakDukkaniREPO.Context;
using PlakDukkaniREPO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkaniREPO.Concrete
{

    public class BaseREPO<T> : IBaseREPO<T> where T : BasePlakDukkani
    {
        private readonly PlakDukkaniContext db;
        public BaseREPO()
        {
            db = new PlakDukkaniContext();
        }
        public int Create(T entity)
        {
            if (entity is not null)
            {
                db.Add(entity);
                return db.SaveChanges();
            }
            throw new Exception("Entity cannot be null.");
        }
        public int Update(T entity)
        {
            if (entity is not null)
            {
                db.Update(entity);
                return db.SaveChanges();
            }
            throw new Exception("Entity cannot be null.");
        }

        public int Delete(T entity)
        {
            if (entity is not null)
            {
                db.Remove(entity);
                return db.SaveChanges();
            }
            throw new Exception("Entity cannot be null.");
        }

        public List<T> GetAll()
        {
            var list = db.Set<T>().ToList();
            if (list is not null)
                return list;
            else
                throw new Exception("Böyle bir data yok");
        }

        public List<T> GetAllWhere(Expression<Func<T, bool>> expression)
        {
            return db.Set<T>().Where(expression).ToList();
        }
    }
}
