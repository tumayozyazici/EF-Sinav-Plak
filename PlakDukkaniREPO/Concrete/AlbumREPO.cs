using PlakDükkaniDATA.Entities;
using PlakDukkaniREPO.Context;
using PlakDukkaniREPO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkaniREPO.Concrete
{
    public class AlbumREPO : BaseREPO<Album>, IAlbumREPO
    {
        PlakDukkaniContext db;
        public AlbumREPO()
        {
             db=new PlakDukkaniContext();   
        }

        public List<Album> EklenenSonOnAlbum()
        {
            return db.Albums.OrderByDescending(x => x.AlbumID).Take(10).ToList();
        }

        public Album KosulaGoreGetir(Expression<Func<Album, bool>> expression)
        {
            return db.Albums.FirstOrDefault(expression);
        }

        public List<Album> SatisiDurmusAlbumler(bool durum)
        {
           return db.Albums.Where(x => x.SatisDevamMi == durum).ToList();
        }
    }
}
