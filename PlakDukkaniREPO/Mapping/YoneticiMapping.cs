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
    public class YoneticiMapping : IEntityTypeConfiguration<Yonetici>
    {
        public void Configure(EntityTypeBuilder<Yonetici> builder)
        {
            builder.HasKey(x => x.YoneticiID);
            builder.HasOne(x=>x.Dukkan).WithMany(x=>x.Yoneticis).HasForeignKey(x=>x.DukkanID);
            builder.HasData(new Yonetici {YoneticiID=1, KullaniciAdi="a", Password="a", DukkanID=1});  
            
        }
    }
}
