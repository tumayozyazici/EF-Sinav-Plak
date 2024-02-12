using AlbumData.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakDükkaniDATA.Entities
{
    public class Yonetici:BasePlakDukkani
    {
        public int YoneticiID { get; set; }
        public string KullaniciAdi { get; set; }
        public string Password { get; set; }
        public virtual Dukkan Dukkan { get; set; }
        public int DukkanID { get; set; }   



    }
}
