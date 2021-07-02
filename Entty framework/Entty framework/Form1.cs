using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Entty_framework
{
    public partial class Form1 : Form
    {
        dbsinavogrenciEntities db = new dbsinavogrenciEntities();
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnderslistesi_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=ONUR;Initial Catalog=dbsinavogrenci;Integrated Security=True");
            SqlCommand komut = new SqlCommand("select * from dersler",baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void btnlistele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.tblogrenci.ToList(); //datagrid üzerinde öğrenci bilgilerini listelemis olduk
            dataGridView1.Columns[3].Visible = false; //3. satırın görünürlüğünü false yaptık
            dataGridView1.Columns[4].Visible = false;
        }
        private void btnnotlistesi_Click(object sender, EventArgs e)
        {
            var query = from item in db.tbl_notlar 
                        select new { item.notid, item.ogr, item.ders, item.sınav1, 
                            item.sınav2,item.sınav3,item.ortalama,item.durum};
            dataGridView1.DataSource = query.ToList(); 
           // dataGridView1.DataSource = db.tbl_notlar.ToList();
        }
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            tblogrenci t = new tblogrenci();        //tblogrenci den t nesnesi türettik
            t.ad = txtad.Text;
            t.soyad = txtsoyad.Text;
            db.tblogrenci.Add(t);       //ürettiğimiz t nesnesini ekleme yaparken kullanmış olduk
            txtad.Clear();
            txtsoyad.Clear();
            db.SaveChanges();
            MessageBox.Show("Öğrenci listeye eklenmiştir");

            dersler d = new dersler();
            d.ders_ad = txtdersad.Text;
            db.dersler.Add(d);
            txtdersad.Clear();
            db.SaveChanges();
            MessageBox.Show("Ders kaydı yapıldı");
        }
        private void btnsil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtogrenciid.Text);
            var x = db.tblogrenci.Find(id);
            db.tblogrenci.Remove(x);
            db.SaveChanges();
            MessageBox.Show("Öğrenci sistemden silindi");

        }
        private void btnguncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtogrenciid.Text);
            var x = db.tblogrenci.Find(id);
            x.ad = txtad.Text;
            x.soyad = txtsoyad.Text;
            x.fotograf = txtfoto.Text;
            db.SaveChanges();
            MessageBox.Show("Öğrenci bilgileri başarıyla güncellendi.");
        }
        private void btnprosedur_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.notlistesi();
        }
        private void btnbul_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.tblogrenci.Where(x => x.ad == txtad.Text | x.soyad == txtsoyad.Text).ToList();
        }
        private void txtad_TextChanged(object sender, EventArgs e)
        {
            string aranan = txtad.Text;
            var degerler = from item in db.tblogrenci
                           where item.ad.Contains(aranan)
                           select item;
            dataGridView1.DataSource = degerler.ToList();
        }

        private void btnlinqentity_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                List<tblogrenci> liste1 = db.tblogrenci.OrderBy(p => p.ad).ToList();
                dataGridView1.DataSource = liste1;
            }
            if(radioButton2.Checked == true)
            {
                List<tblogrenci> liste2 = db.tblogrenci.OrderByDescending(p => p.ad).ToList();
                dataGridView1.DataSource = liste2;
            }
            if(radioButton3.Checked == true)
            {
                List<tblogrenci> list3 = db.tblogrenci.OrderBy(p => p.ad).Take(3).ToList();
                dataGridView1.DataSource = list3;
            }
            if(radioButton4.Checked == true)
            {
                List<tblogrenci> list4 = db.tblogrenci.Where(p => p.id == 5).ToList();
                dataGridView1.DataSource = list4;
            }
            if(radioButton5.Checked == true)
            {
                List<tblogrenci> list5 = db.tblogrenci.Where(p => p.ad.StartsWith("a")).ToList();
                dataGridView1.DataSource = list5;
            }
            if(radioButton6.Checked == true)
            {
                List<tblogrenci> list6 = db.tblogrenci.Where(p => p.ad.EndsWith("l")).ToList();
                dataGridView1.DataSource = list6;
            }
            if(radioButton7.Checked == true)
            {
                bool deger = db.tblkulupler.Any();
                MessageBox.Show(deger.ToString(),"Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            if(radioButton8.Checked == true)
            {
                int toplam = db.tblogrenci.Count();
                MessageBox.Show(toplam.ToString(), "toplam öğrenci sayısı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if(radioButton9.Checked == true)
            {
                var toplam = db.tbl_notlar.Sum(p => p.sınav1);
                MessageBox.Show("toplam sınav1 puanı:" + toplam.ToString());
            }
            if(radioButton10.Checked == true)
            {
                var ortalama = db.tbl_notlar.Average(p => p.sınav1);
                MessageBox.Show("Ortalama sınav1 puanı" + ortalama.ToString());
            }
            if(radioButton11.Checked == true)
            {
                var enyuksek = db.tbl_notlar.Max(p => p.sınav1);
                MessageBox.Show("Max sınav notu" +enyuksek.ToString());
            }
            if(radioButton12.Checked == true)
            {
                var enyuksekisim = db.tbl_notlar.Max(p => p.sınav1);
                dataGridView1.DataSource = db.notlistesi().Where(p => p.sınav1 == enyuksekisim).ToList();
            }
        }

        private void btnjoin_Click(object sender, EventArgs e)
        {
            var sorgu = from d1 in db.tbl_notlar
                        join d2 in db.tblogrenci
                        on d1.ogr equals d2.id
                        join d3 in db.dersler
                        on d1.ders equals d3.ders_id
                        select new
                        {
                            ÖĞRENCİ = d2.ad + " " + d2.soyad,
                            DERS = d3.ders_ad,
                            SINAV1 = d1.sınav1,
                            SINAV2 = d1.sınav2,
                            SINAV3 = d1.sınav3,
                            ortalama = d1.ortalama
                        };
            dataGridView1.DataSource = sorgu.ToList();

        }
    }
}
