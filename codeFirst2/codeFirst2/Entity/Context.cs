using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeFirst2.Entity
{
    public class Context : DbContext
    {
        public DbSet<Urunler> Urunlers { get; set; }
        public DbSet<Kategori> Kategoris { get; set; }
       
    }
}
