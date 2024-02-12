using PlakDükkaniDATA.Entities;
using PlakDükkaniDATA.Enums;
using PlakDukkaniREPO.Concrete;
using PlakDukkaniREPO.Context;
using PlakDukkaniREPO.Interfaces;
using PlakDukkaniSERVICE.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkaniSERVICE.Concrete
{
    public class YoneticiSERVICE : IYoneticiSERVICE
    {
        private readonly IYoneticiREPO yoneticiREPO;
        public YoneticiSERVICE()
        {
            yoneticiREPO=new YoneticiREPO();    
        }
        public int Add(Yonetici entity)
        {
                entity.CreatedDate = DateTime.Now;
                entity.Status = Status.Added;
                return yoneticiREPO.Create(entity);       
        }

        public int Delete(Yonetici entity)
        {
            entity.CreatedDate = DateTime.Now;
            entity.Status = Status.Deleted;
            return yoneticiREPO.Delete(entity);
        }

        public List<Yonetici> GetAll()
        {
            return yoneticiREPO.GetAll();
        }

        public List<Yonetici> GetAllActive()
        {
            throw new NotImplementedException();
        }

        public List<Yonetici> GetWhere(Func<Yonetici, bool> expression)
        {
           return yoneticiREPO.GetAll().Where(expression).ToList();
        }

        public int Update(Yonetici entity)
        {
            entity.CreatedDate = DateTime.Now;
            entity.Status = Status.Modified;
            return yoneticiREPO.Update(entity);
        }

        public bool YoneticiVarMi(string kullaniciAdi)
        {
            return yoneticiREPO.YoneticiVarMi(kullaniciAdi);
        }
    }
}
