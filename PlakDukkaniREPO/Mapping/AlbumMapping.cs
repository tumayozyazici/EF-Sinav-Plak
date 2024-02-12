using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlakDükkaniDATA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkaniREPO.Mapping
{
    public class AlbumMapping : IEntityTypeConfiguration<Album>
    {
        public void Configure(EntityTypeBuilder<Album> builder)
        {
            builder.HasKey(x => x.AlbumID);
            builder.HasData(
                new Album { AlbumID = 1, Adi = "Album 1", Sanatci="Sanatci 1", CikisTarihi= new DateTime(2023, 1, 1), IndirimOrani=15, Fiyati=250, SatisDevamMi=true, DukkanID=1 },
                new Album { AlbumID = 2, Adi = "Album 2", Sanatci = "Sanatci 2", CikisTarihi = new DateTime(1990, 2, 10), IndirimOrani = 25, Fiyati = 750, SatisDevamMi = true, DukkanID = 1 },
                new Album { AlbumID = 3, Adi = "Album 3", Sanatci = "Sanatci 3", CikisTarihi = new DateTime(1992, 3, 9), IndirimOrani = 0, Fiyati = 750, SatisDevamMi = false, DukkanID = 1 },
                new Album { AlbumID = 4, Adi = "Album 4", Sanatci = "Sanatci 4", CikisTarihi = new DateTime(1945, 3, 8), IndirimOrani = 25, Fiyati = 750, SatisDevamMi = true, DukkanID = 1 },
                new Album { AlbumID = 5, Adi = "Album 5", Sanatci = "Sanatci 5", CikisTarihi = new DateTime(1932, 3, 7), IndirimOrani = 0, Fiyati = 750, SatisDevamMi = false, DukkanID = 1 },
                new Album { AlbumID = 6, Adi = "Album 6", Sanatci = "Sanatci 6", CikisTarihi = new DateTime(1912, 5, 6), IndirimOrani = 15, Fiyati = 750, SatisDevamMi = true, DukkanID = 1 },
                new Album { AlbumID = 7, Adi = "Album 7", Sanatci = "Sanatci 7", CikisTarihi = new DateTime(1999, 3, 5), IndirimOrani = 0, Fiyati = 750, SatisDevamMi = true, DukkanID = 1 },
                new Album { AlbumID = 8, Adi = "Album 8", Sanatci = "Sanatci 8", CikisTarihi = new DateTime(2000, 4, 4), IndirimOrani = 20, Fiyati = 750, SatisDevamMi = false, DukkanID = 1 },
                new Album { AlbumID = 9, Adi = "Album 9", Sanatci = "Sanatci 9", CikisTarihi = new DateTime(1965, 3, 3), IndirimOrani = 25, Fiyati = 750, SatisDevamMi = true, DukkanID = 1 },
                new Album { AlbumID = 10, Adi = "Album 10", Sanatci = "Sanatci 10", CikisTarihi = new DateTime(1970, 3, 21), IndirimOrani = 50, Fiyati = 750, SatisDevamMi = true, DukkanID = 1 },
                new Album { AlbumID = 11, Adi = "Album 11", Sanatci = "Sanatc 11", CikisTarihi = new DateTime(1920, 6, 2), IndirimOrani = 30, Fiyati = 750, SatisDevamMi = true, DukkanID = 1 },
                new Album { AlbumID = 12, Adi = "Album 12", Sanatci = "Sanatci 12", CikisTarihi = new DateTime(1925, 7, 10), IndirimOrani = 10, Fiyati = 750, SatisDevamMi = true, DukkanID = 1 },
                new Album { AlbumID = 13, Adi = "Album 13", Sanatci = "Sanatci 13", CikisTarihi = new DateTime(2005, 10, 11), IndirimOrani = 0, Fiyati = 750, SatisDevamMi = true, DukkanID = 1 }
            );
        }
    }
}
