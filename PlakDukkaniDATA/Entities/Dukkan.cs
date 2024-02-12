using AlbumData.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakDükkaniDATA.Entities
{
    public class Dukkan:BasePlakDukkani
    {
        public Dukkan()
        {
            Albums = new HashSet<Album>();
            Yoneticis = new HashSet<Yonetici>();
        }
        public int DukkanID { get; set; }

        public string Adi { get; set; }
        public virtual ICollection<Album> Albums { get; set; }
        public virtual ICollection<Yonetici> Yoneticis { get; set; }

    }
}
