using PlakDükkaniDATA.Entities;
using PlakDukkaniREPO.Context;
using PlakDukkaniREPO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkaniREPO.Concrete
{
    public class YoneticiREPO : BaseREPO<Yonetici>, IYoneticiREPO
    {
        PlakDukkaniContext db;
        public YoneticiREPO()
        {
            db = new PlakDukkaniContext();
        }
        public bool YoneticiVarMi(string kullaniciAdi)
        {
            return db.Yoneticis.Any(x => x.KullaniciAdi == kullaniciAdi);
        }
    }
}
