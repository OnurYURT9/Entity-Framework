using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeFirst2.Entity
{
   public class Kategori
    {
        [Key]
        public int KategoriId { get; set; }
        public string KategoriAd { get; set; }
        public ICollection<Urunler> Urunlers { get; set; } //1 kategoride birden fazla ürün yer aldığı için Icollection kullanıldı

    }
}
