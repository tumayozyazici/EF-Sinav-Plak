using PlakDükkaniDATA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkaniSERVICE.Interface
{
    public interface IYoneticiSERVICE
    {
        int Add(Yonetici entity);
        int Update(Yonetici entity);
        int Delete(Yonetici entity);
        List<Yonetici> GetAll();
        List<Yonetici> GetAllActive();
        List<Yonetici> GetWhere(Func<Yonetici, bool> expression);
        bool YoneticiVarMi(string kullaniciAdi);
    }
}
