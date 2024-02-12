using AlbumData.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakDükkaniDATA.Entities
{
    public class Album:BasePlakDukkani
    {
        public int AlbumID { get; set; }
        public string Adi { get; set; }
        public string Sanatci { get; set; }
        public DateTime CikisTarihi { get; set; }
        public double Fiyati { get; set; }
        public double? IndirimOrani { get; set; }
        public bool SatisDevamMi { get; set; }

        public virtual Dukkan Dukkan { get; set; }
        public int DukkanID { get; set; }




    }
}
