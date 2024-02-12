using PlakDükkaniDATA.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace AlbumData.Abstract
{
    public abstract class BasePlakDukkani
    {
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? UpdatedDate { get; set; } // ? Null geçilebilir demek.
        public DateTime? DeletedDate { get; set; }
        public Status Status { get; set; } = Status.Added;

    }
}
