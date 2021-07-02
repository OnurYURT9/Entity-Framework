using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entty_framework
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        dbsinavogrenciEntities db = new dbsinavogrenciEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                var degerler = db.tbl_notlar.Where(x => x.sınav1 < 50);
                dataGridView1.DataSource = degerler.ToList();
            }
            if (radioButton2.Checked == true)
            {
                var degerler = db.tblogrenci.Where(x => x.ad == "Ali" );
                dataGridView1.DataSource = degerler.ToList();
            }
            if (radioButton3.Checked == true)
            {
                var degerler = db.tblogrenci.Where(x => x.ad == textBox1.Text || x.soyad == textBox1.Text);
                dataGridView1.DataSource = degerler.ToList();
            }
            if (radioButton6.Checked == true)
            {
                var degerler = db.tblogrenci.Select(x => new { soyadı = x.soyad });
                dataGridView1.DataSource = degerler.ToList();
            }
            if(radioButton5.Checked == true)
            {
                var degerler = db.tblogrenci.Select(x => new {ad=x.ad.ToUpper(), soyadı=x.soyad.ToLower() });
                dataGridView1.DataSource = degerler.ToList();
            }
            if(radioButton4.Checked == true)
            {
                var degerler = db.tblogrenci.Select(x => new 
                { ad = x.ad.ToUpper(),
                    soyadı = x.soyad.ToLower() 
                }).Where(x=>x.ad !="Ali");
                dataGridView1.DataSource = degerler.ToList();
            }
            if (radioButton7.Checked == true)
            {
                var degerler = db.tbl_notlar.Select(x =>
                new
                {
                    Ogrenciad = x.ogr,
                    Ortalaması = x.ortalama,
                    Durum = x.durum==true ? "geçti" : "Kaldı"
                }) ;
               
               
                dataGridView1.DataSource = degerler.ToList();
            }
            if (radioButton8.Checked == true)
            {
                var degerler = db.tbl_notlar.SelectMany(x => db.tblogrenci.Where(y => y.id == x.ogr), (x,y) => new
                {
                    y.ad,
                    y.soyad,
                    x.ortalama
                });
                dataGridView1.DataSource = degerler.ToList();
            }
            if (radioButton11.Checked == true)
            {
                var degerler = db.tblogrenci.OrderBy(x => x.id).Take(3);
                dataGridView1.DataSource = degerler.ToList();
            }
            if (radioButton10.Checked == true)
            {
                var degerler = db.tblogrenci.OrderByDescending(x => x.id).Take(3);
                dataGridView1.DataSource = degerler.ToList();
            }
            if (radioButton9.Checked == true)
            {
                var degerler = db.tblogrenci.OrderByDescending(x => x.ad);
                dataGridView1.DataSource = degerler.ToList();
            }
            if (radioButton12.Checked == true)
            {
                var degerler = db.tblogrenci.OrderByDescending(x => x.ad).Skip(5);
                dataGridView1.DataSource = degerler.ToList();
            }
        }

      
    }
}
