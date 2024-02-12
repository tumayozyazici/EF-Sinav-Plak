using PlakDükkaniDATA.Entities;
using PlakDükkaniDATA.Enums;
using PlakDukkaniREPO.Concrete;
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
    public class AlbumSERVICE : IAlbumSERVICE
    {
        private readonly IAlbumREPO albumREPO;
        public AlbumSERVICE()
        {
            albumREPO = new AlbumREPO();
        }
        public int Add(Album entity)
        {
            entity.CreatedDate = DateTime.Now;
            entity.Status = Status.Added;
            return albumREPO.Update(entity);
        }

        public int Delete(Album entity)
        {
            entity.CreatedDate = DateTime.Now;
            entity.Status = Status.Deleted;
            return albumREPO.Delete(entity);
        }

        public List<Album> EklenenSonOnAlbum()
        {
            return albumREPO.EklenenSonOnAlbum();
        }

        public List<Album> GetAll()
        {
            return albumREPO.GetAll();
        }

        public List<Album> GetAllActive()
        {
            throw new NotImplementedException();
        }

        public List<Album> GetWhere(Func<Album, bool> expression)
        {
            return albumREPO.GetAll().Where(expression).ToList();
        }

        public List<Album> IndirimleriGetir()
        {
            return albumREPO.GetAllWhere(x => x.IndirimOrani > 0 && x.IndirimOrani != null).OrderByDescending(x => x.IndirimOrani).ToList();
        }

        public Album KosulaGoreGetir(Expression<Func<Album, bool>> expression)
        {
            return albumREPO.KosulaGoreGetir(expression);
        }

        public List<Album> SatisiDurmusAlbumler(bool durum)
        {
            return albumREPO.SatisiDurmusAlbumler(durum);
        }

        public int Update(Album entity)
        {
            entity.CreatedDate = DateTime.Now;
            entity.Status = Status.Modified;
            return albumREPO.Update(entity);
        }
    }
}
