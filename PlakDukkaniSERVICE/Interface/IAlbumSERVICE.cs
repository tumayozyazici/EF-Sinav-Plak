using PlakDükkaniDATA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkaniSERVICE.Interface
{
    public interface IAlbumSERVICE
    {
        int Add(Album entity);
        int Update(Album entity);
        int Delete(Album entity);
        List<Album> GetAll();
        List<Album> GetAllActive();
        List<Album> GetWhere(Func<Album, bool> expression);
        List<Album> SatisiDurmusAlbumler(bool durum);
        List<Album> EklenenSonOnAlbum();
        List<Album> IndirimleriGetir();
        Album KosulaGoreGetir(Expression<Func<Album, bool>> expression);
    }
}
