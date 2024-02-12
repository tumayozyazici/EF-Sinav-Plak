using PlakDükkaniDATA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkaniSERVICE.Interface
{
    public interface IDukkanSERVICE
    {
        int Add(Dukkan entity);
        int Update(Dukkan entity);
        int Delete(Dukkan entity);
        List<Dukkan> GetAll();
        List<Dukkan> GetAllActive();
        List<Dukkan> GetWhere(Func<Dukkan, bool> expression);
    }
}
