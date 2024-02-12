using PlakDükkaniDATA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkaniREPO.Interfaces
{
    public interface IYoneticiREPO:IBaseREPO<Yonetici>
    {

        bool YoneticiVarMi(string kullaniciAdi);
    }
}
