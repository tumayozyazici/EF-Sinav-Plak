using PlakDükkaniDATA.Entities;
using PlakDukkaniREPO.Concrete;
using PlakDükkaniDATA.Enums;
using PlakDukkaniSERVICE.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlakDukkaniREPO.Interfaces;

namespace PlakDukkaniSERVICE.Concrete
{
    public class DukkanSERVICE : IDukkanSERVICE
    {
        private readonly IDukkanREPO dukkanREPO;
        public DukkanSERVICE()
        {
            dukkanREPO = new DukkanREPO();
        }
        public int Add(Dukkan entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(Dukkan entity)
        {
            throw new NotImplementedException();
        }

        public List<Dukkan> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Dukkan> GetAllActive()
        {
            throw new NotImplementedException();
        }

        public List<Dukkan> GetWhere(Func<Dukkan, bool> expression)
        {
            throw new NotImplementedException();
        }

        public int Update(Dukkan entity)
        {
            throw new NotImplementedException();
        }
    }
}
