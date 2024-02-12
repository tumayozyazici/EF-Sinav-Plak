using AlbumData.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkaniREPO.Interfaces
{
    public interface IBaseREPO<T> where T : BasePlakDukkani
    {
        int Create(T entity);
        int Update(T entity);
        int Delete(T entity);

        // T ye göre bütün Listeyi getirir.
        List<T> GetAll();

        //T tipinde koşula göre tüm listeyi getirir.
        List<T> GetAllWhere(Expression<Func<T, bool>> expression);

    }
}
