using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Entity
{
    class Urunler
    {
        [Key]
        public int Urunid { get; set; }
        public string Urunad { get; set; }
        public string UrunMarka { get; set; }
        public string UrunKategori { get; set; }
        public int UrunStok { get; set; }
    }
}
