
namespace Entty_framework
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnlistele = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btnbul = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtfoto = new System.Windows.Forms.TextBox();
            this.txtogrenciid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtdersad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtdersid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnjoin = new System.Windows.Forms.Button();
            this.btnhesapla = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtdurum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsınav3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtsınav2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtortalama = new System.Windows.Forms.TextBox();
            this.txtsınav1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnderslistesi = new System.Windows.Forms.Button();
            this.btnnotlistesi = new System.Windows.Forms.Button();
            this.btnprosedur = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnlinqentity = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(760, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnlistele
            // 
            this.btnlistele.Location = new System.Drawing.Point(12, 222);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(155, 38);
            this.btnlistele.TabIndex = 1;
            this.btnlistele.Text = "ÖĞRENCİ LİSTELE";
            this.btnlistele.UseVisualStyleBackColor = true;
            this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(12, 269);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(155, 35);
            this.btnkaydet.TabIndex = 2;
            this.btnkaydet.Text = "KAYDET";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(12, 316);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(155, 32);
            this.btnsil.TabIndex = 3;
            this.btnsil.Text = "SİL";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(12, 354);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(155, 37);
            this.btnguncelle.TabIndex = 4;
            this.btnguncelle.Text = "GÜNCELLE";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btnbul
            // 
            this.btnbul.Location = new System.Drawing.Point(12, 397);
            this.btnbul.Name = "btnbul";
            this.btnbul.Size = new System.Drawing.Size(155, 34);
            this.btnbul.TabIndex = 5;
            this.btnbul.Text = "BUL";
            this.btnbul.UseVisualStyleBackColor = true;
            this.btnbul.Click += new System.EventHandler(this.btnbul_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtsoyad);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtfoto);
            this.groupBox1.Controls.Add(this.txtogrenciid);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(198, 234);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 144);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ogrenci";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "FOTOGRAF:";
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(160, 74);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(100, 22);
            this.txtsoyad.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "SOYAD";
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(160, 41);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(100, 22);
            this.txtad.TabIndex = 19;
            this.txtad.TextChanged += new System.EventHandler(this.txtad_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "AD:";
            // 
            // txtfoto
            // 
            this.txtfoto.Location = new System.Drawing.Point(160, 107);
            this.txtfoto.Name = "txtfoto";
            this.txtfoto.Size = new System.Drawing.Size(100, 22);
            this.txtfoto.TabIndex = 17;
            // 
            // txtogrenciid
            // 
            this.txtogrenciid.Location = new System.Drawing.Point(160, 0);
            this.txtogrenciid.Name = "txtogrenciid";
            this.txtogrenciid.Size = new System.Drawing.Size(100, 22);
            this.txtogrenciid.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtdersad);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtdersid);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(198, 397);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(355, 71);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dersler";
            // 
            // txtdersad
            // 
            this.txtdersad.Location = new System.Drawing.Point(160, 41);
            this.txtdersad.Name = "txtdersad";
            this.txtdersad.Size = new System.Drawing.Size(100, 22);
            this.txtdersad.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(105, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "AD:";
            // 
            // txtdersid
            // 
            this.txtdersid.Location = new System.Drawing.Point(160, 0);
            this.txtdersid.Name = "txtdersid";
            this.txtdersid.Size = new System.Drawing.Size(100, 22);
            this.txtdersid.TabIndex = 16;
            this.txtdersid.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(111, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "ID:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnjoin);
            this.groupBox3.Controls.Add(this.btnhesapla);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtdurum);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtsınav3);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtsınav2);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtortalama);
            this.groupBox3.Controls.Add(this.txtsınav1);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(595, 239);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(355, 270);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Notlar";
            // 
            // btnjoin
            // 
            this.btnjoin.Location = new System.Drawing.Point(83, 204);
            this.btnjoin.Name = "btnjoin";
            this.btnjoin.Size = new System.Drawing.Size(206, 38);
            this.btnjoin.TabIndex = 28;
            this.btnjoin.Text = "Join İle Getir";
            this.btnjoin.UseVisualStyleBackColor = true;
            this.btnjoin.Click += new System.EventHandler(this.btnjoin_Click);
            // 
            // btnhesapla
            // 
            this.btnhesapla.Location = new System.Drawing.Point(83, 163);
            this.btnhesapla.Name = "btnhesapla";
            this.btnhesapla.Size = new System.Drawing.Size(206, 38);
            this.btnhesapla.TabIndex = 27;
            this.btnhesapla.Text = "HESAPLA";
            this.btnhesapla.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(66, 135);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 17);
            this.label11.TabIndex = 24;
            this.label11.Text = "DURUM:";
            // 
            // txtdurum
            // 
            this.txtdurum.Location = new System.Drawing.Point(160, 135);
            this.txtdurum.Name = "txtdurum";
            this.txtdurum.Size = new System.Drawing.Size(100, 22);
            this.txtdurum.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "ORTALAMA:";
            // 
            // txtsınav3
            // 
            this.txtsınav3.Location = new System.Drawing.Point(160, 74);
            this.txtsınav3.Name = "txtsınav3";
            this.txtsınav3.Size = new System.Drawing.Size(100, 22);
            this.txtsınav3.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(98, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "SINAV3:";
            // 
            // txtsınav2
            // 
            this.txtsınav2.Location = new System.Drawing.Point(160, 41);
            this.txtsınav2.Name = "txtsınav2";
            this.txtsınav2.Size = new System.Drawing.Size(100, 22);
            this.txtsınav2.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(94, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "SINAV2:";
            // 
            // txtortalama
            // 
            this.txtortalama.Location = new System.Drawing.Point(160, 107);
            this.txtortalama.Name = "txtortalama";
            this.txtortalama.Size = new System.Drawing.Size(100, 22);
            this.txtortalama.TabIndex = 17;
            // 
            // txtsınav1
            // 
            this.txtsınav1.Location = new System.Drawing.Point(160, 0);
            this.txtsınav1.Name = "txtsınav1";
            this.txtsınav1.Size = new System.Drawing.Size(100, 22);
            this.txtsınav1.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(94, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 17);
            this.label10.TabIndex = 15;
            this.label10.Text = "SINAV1:";
            // 
            // btnderslistesi
            // 
            this.btnderslistesi.Location = new System.Drawing.Point(12, 437);
            this.btnderslistesi.Name = "btnderslistesi";
            this.btnderslistesi.Size = new System.Drawing.Size(155, 50);
            this.btnderslistesi.TabIndex = 25;
            this.btnderslistesi.Text = "DERS LİSTESİ";
            this.btnderslistesi.UseVisualStyleBackColor = true;
            this.btnderslistesi.Click += new System.EventHandler(this.btnderslistesi_Click);
            // 
            // btnnotlistesi
            // 
            this.btnnotlistesi.Location = new System.Drawing.Point(12, 493);
            this.btnnotlistesi.Name = "btnnotlistesi";
            this.btnnotlistesi.Size = new System.Drawing.Size(155, 50);
            this.btnnotlistesi.TabIndex = 26;
            this.btnnotlistesi.Text = "NOT LİSTESİ";
            this.btnnotlistesi.UseVisualStyleBackColor = true;
            this.btnnotlistesi.Click += new System.EventHandler(this.btnnotlistesi_Click);
            // 
            // btnprosedur
            // 
            this.btnprosedur.Location = new System.Drawing.Point(12, 549);
            this.btnprosedur.Name = "btnprosedur";
            this.btnprosedur.Size = new System.Drawing.Size(155, 38);
            this.btnprosedur.TabIndex = 27;
            this.btnprosedur.Text = "PROSEDÜR";
            this.btnprosedur.UseVisualStyleBackColor = true;
            this.btnprosedur.Click += new System.EventHandler(this.btnprosedur_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(1045, 66);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(157, 21);
            this.radioButton1.TabIndex = 28;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Ada Göre Sırala A-Z";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // btnlinqentity
            // 
            this.btnlinqentity.Location = new System.Drawing.Point(1041, 507);
            this.btnlinqentity.Name = "btnlinqentity";
            this.btnlinqentity.Size = new System.Drawing.Size(141, 36);
            this.btnlinqentity.TabIndex = 29;
            this.btnlinqentity.Text = "Linq Entity";
            this.btnlinqentity.UseVisualStyleBackColor = true;
            this.btnlinqentity.Click += new System.EventHandler(this.btnlinqentity_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(1045, 123);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(157, 21);
            this.radioButton2.TabIndex = 30;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Ada Göre Sırala Z-A";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(1045, 165);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(89, 21);
            this.radioButton3.TabIndex = 31;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "İlk 3 Kayıt";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(1045, 192);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(160, 21);
            this.radioButton4.TabIndex = 32;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "ID\'ye Göre Veri Getir";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(1045, 231);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(158, 21);
            this.radioButton5.TabIndex = 33;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Adı A ile Başlayanlar";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(1045, 269);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(131, 21);
            this.radioButton6.TabIndex = 34;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Adı L ile Bitenler";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(1045, 296);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(120, 21);
            this.radioButton7.TabIndex = 35;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Değer Var Mı?";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(1041, 327);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(196, 21);
            this.radioButton8.TabIndex = 36;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Bir Tablodaki Değer Sayısı";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(1042, 357);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(160, 21);
            this.radioButton9.TabIndex = 37;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "Sınav1 Toplam Puan";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Location = new System.Drawing.Point(1041, 384);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(171, 21);
            this.radioButton10.TabIndex = 38;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "Sınav1 Ortalama Puan";
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.Location = new System.Drawing.Point(1034, 419);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(180, 21);
            this.radioButton11.TabIndex = 39;
            this.radioButton11.TabStop = true;
            this.radioButton11.Text = "Sınav1 En Yüksek Puan";
            this.radioButton11.UseVisualStyleBackColor = true;
            // 
            // radioButton12
            // 
            this.radioButton12.AutoSize = true;
            this.radioButton12.Location = new System.Drawing.Point(956, 441);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(266, 21);
            this.radioButton12.TabIndex = 40;
            this.radioButton12.TabStop = true;
            this.radioButton12.Text = "Sınav1 En Yüksek Puanı Alan öğrenci";
            this.radioButton12.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 634);
            this.Controls.Add(this.radioButton12);
            this.Controls.Add(this.radioButton11);
            this.Controls.Add(this.radioButton10);
            this.Controls.Add(this.radioButton9);
            this.Controls.Add(this.radioButton8);
            this.Controls.Add(this.radioButton7);
            this.Controls.Add(this.radioButton6);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.btnlinqentity);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.btnprosedur);
            this.Controls.Add(this.btnnotlistesi);
            this.Controls.Add(this.btnderslistesi);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnbul);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.btnlistele);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnlistele;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btnbul;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtfoto;
        private System.Windows.Forms.TextBox txtogrenciid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtdersad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtdersid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsınav3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtsınav2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtortalama;
        private System.Windows.Forms.TextBox txtsınav1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtdurum;
        private System.Windows.Forms.Button btnderslistesi;
        private System.Windows.Forms.Button btnnotlistesi;
        private System.Windows.Forms.Button btnjoin;
        private System.Windows.Forms.Button btnhesapla;
        private System.Windows.Forms.Button btnprosedur;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btnlinqentity;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.RadioButton radioButton11;
        private System.Windows.Forms.RadioButton radioButton12;
    }
}

