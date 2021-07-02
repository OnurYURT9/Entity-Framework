using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeFirst2.Entity
{
   public class Urunler
    {
        [Key]
        public int Urunid { get; set; }
        public string Urunad { get; set; }
        public string UrunMarka { get; set; }
        public string UrunKategori { get; set; }
        public int UrunStok { get; set; }
        public string Aciklama { get; set; }
        public Kategori Kategori { get; set; }
    }
}
