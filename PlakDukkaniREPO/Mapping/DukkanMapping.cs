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
    public class DukkanMapping : IEntityTypeConfiguration<Dukkan>
    {
        public void Configure(EntityTypeBuilder<Dukkan> builder)
        {
            builder.HasKey(x => x.DukkanID);
            builder.HasMany(x => x.Albums).WithOne(x=>x.Dukkan).HasForeignKey(x=>x.DukkanID);
            builder.HasData(new Dukkan { DukkanID=1,Adi="Eskiler",});
        }
    }
}
