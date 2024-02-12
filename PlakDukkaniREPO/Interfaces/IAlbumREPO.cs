using PlakDükkaniDATA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkaniREPO.Interfaces
{
    public interface IAlbumREPO:IBaseREPO<Album>
    {
        List<Album> SatisiDurmusAlbumler(bool durum);

        List<Album> EklenenSonOnAlbum();

        Album KosulaGoreGetir(Expression<Func<Album, bool>> expression);
    }
}
