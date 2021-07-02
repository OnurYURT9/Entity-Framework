using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity_Son_Kısım
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        dbsinavogrenciEntities db = new dbsinavogrenciEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            /*
            var degerler = db.tblogrenci.OrderBy(x => x.sehir).GroupBy(y => y.sehir).
                Select(z => new { sehir= z.Key, Toplam = z.Count() });
            dataGridView1.DataSource = degerler.ToList();*/
            // label1.Text = db.tbl_notlar.Max(x => x.ortalama).ToString();
            dataGridView1.DataSource = db.kulupler().ToList();
        }

    }
}
