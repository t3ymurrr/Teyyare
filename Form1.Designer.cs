namespace Winform
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblVerenOrgan = new System.Windows.Forms.Label();
            this.lblEtibarlidir = new System.Windows.Forms.Label();
            this.lblVerilme = new System.Windows.Forms.Label();
            this.lblAileVaz = new System.Windows.Forms.Label();
            this.lblDogumYeri = new System.Windows.Forms.Label();
            this.lblDogumTarixi = new System.Windows.Forms.Label();
            this.lblCins = new System.Windows.Forms.Label();
            this.lblAtaAdi = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblFin = new System.Windows.Forms.Label();
            this.lblSeriya = new System.Windows.Forms.Label();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.btnSekilYukle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtVerenOrgan = new System.Windows.Forms.TextBox();
            this.txtEtibarlidir = new System.Windows.Forms.TextBox();
            this.txtVerilmeTarixi = new System.Windows.Forms.TextBox();
            this.txtAileVeziyyeti = new System.Windows.Forms.TextBox();
            this.txtDogumYeri = new System.Windows.Forms.TextBox();
            this.txtDogumTarixi = new System.Windows.Forms.TextBox();
            this.txtCins = new System.Windows.Forms.TextBox();
            this.txtAtaAdi = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtFin = new System.Windows.Forms.TextBox();
            this.txtSeriya = new System.Windows.Forms.TextBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnYaddaSaxla = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();

            this.groupBox1.Controls.Add(this.lblVerenOrgan);
            this.groupBox1.Controls.Add(this.lblEtibarlidir);
            this.groupBox1.Controls.Add(this.lblVerilme);
            this.groupBox1.Controls.Add(this.lblAileVaz);
            this.groupBox1.Controls.Add(this.lblDogumYeri);
            this.groupBox1.Controls.Add(this.lblDogumTarixi);
            this.groupBox1.Controls.Add(this.lblCins);
            this.groupBox1.Controls.Add(this.lblAtaAdi);
            this.groupBox1.Controls.Add(this.lblAd);
            this.groupBox1.Controls.Add(this.lblSoyad);
            this.groupBox1.Controls.Add(this.lblFin);
            this.groupBox1.Controls.Add(this.lblSeriya);
            this.groupBox1.Controls.Add(this.pbFoto);
            this.groupBox1.Controls.Add(this.btnSekilYukle);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 480);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Şəxsiyyət vəsiqəsi";

            this.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFoto.Location = new System.Drawing.Point(20, 40);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(120, 150);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFoto.TabIndex = 0;
            this.pbFoto.TabStop = false;

            this.lblSeriya.Location = new System.Drawing.Point(150, 40);
            this.lblSeriya.Name = "lblSeriya";
            this.lblSeriya.Size = new System.Drawing.Size(130, 20);
            this.lblSeriya.Text = "Seriya: ";

            this.lblFin.Location = new System.Drawing.Point(290, 40);
            this.lblFin.Name = "lblFin";
            this.lblFin.Size = new System.Drawing.Size(150, 20);
            this.lblFin.Text = "FİN: ";

            this.lblSoyad.Location = new System.Drawing.Point(150, 70);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(200, 20);
            this.lblSoyad.Text = "Soyad: ";

            this.lblAd.Location = new System.Drawing.Point(150, 100);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(200, 20);
            this.lblAd.Text = "Ad: ";

            this.lblAtaAdi.Location = new System.Drawing.Point(150, 130);
            this.lblAtaAdi.Name = "lblAtaAdi";
            this.lblAtaAdi.Size = new System.Drawing.Size(200, 20);
            this.lblAtaAdi.Text = "Ata adı: ";

            this.lblCins.Location = new System.Drawing.Point(150, 160);
            this.lblCins.Name = "lblCins";
            this.lblCins.Size = new System.Drawing.Size(200, 20);
            this.lblCins.Text = "Cins: ";

            this.lblDogumTarixi.Location = new System.Drawing.Point(150, 190);
            this.lblDogumTarixi.Name = "lblDogumTarixi";
            this.lblDogumTarixi.Size = new System.Drawing.Size(200, 20);
            this.lblDogumTarixi.Text = "Doğum tarixi: ";

            this.lblDogumYeri.Location = new System.Drawing.Point(150, 220);
            this.lblDogumYeri.Name = "lblDogumYeri";
            this.lblDogumYeri.Size = new System.Drawing.Size(200, 20);
            this.lblDogumYeri.Text = "Doğum yeri: ";

            this.lblAileVaz.Location = new System.Drawing.Point(150, 250);
            this.lblAileVaz.Name = "lblAileVaz";
            this.lblAileVaz.Size = new System.Drawing.Size(200, 20);
            this.lblAileVaz.Text = "Ailə vəz.: ";

            this.lblVerilme.Location = new System.Drawing.Point(150, 280);
            this.lblVerilme.Name = "lblVerilme";
            this.lblVerilme.Size = new System.Drawing.Size(200, 20);
            this.lblVerilme.Text = "Verilmə: ";

            this.lblEtibarlidir.Location = new System.Drawing.Point(150, 310);
            this.lblEtibarlidir.Name = "lblEtibarlidir";
            this.lblEtibarlidir.Size = new System.Drawing.Size(200, 20);
            this.lblEtibarlidir.Text = "Etibarlıdır: ";

            this.lblVerenOrgan.Location = new System.Drawing.Point(150, 340);
            this.lblVerenOrgan.Name = "lblVerenOrgan";
            this.lblVerenOrgan.Size = new System.Drawing.Size(290, 20);
            this.lblVerenOrgan.Text = "Verən organ: ";

            this.btnSekilYukle.Location = new System.Drawing.Point(20, 420);
            this.btnSekilYukle.Name = "btnSekilYukle";
            this.btnSekilYukle.Size = new System.Drawing.Size(420, 40);
            this.btnSekilYukle.TabIndex = 1;
            this.btnSekilYukle.Text = "Şəkil yüklə...";
            this.btnSekilYukle.UseVisualStyleBackColor = true;
            this.btnSekilYukle.Click += new System.EventHandler(this.btnSekilYukle_Click);

            this.groupBox2.Controls.Add(this.txtVerenOrgan);
            this.groupBox2.Controls.Add(this.txtEtibarlidir);
            this.groupBox2.Controls.Add(this.txtVerilmeTarixi);
            this.groupBox2.Controls.Add(this.txtAileVeziyyeti);
            this.groupBox2.Controls.Add(this.txtDogumYeri);
            this.groupBox2.Controls.Add(this.txtDogumTarixi);
            this.groupBox2.Controls.Add(this.txtCins);
            this.groupBox2.Controls.Add(this.txtAtaAdi);
            this.groupBox2.Controls.Add(this.txtAd);
            this.groupBox2.Controls.Add(this.txtSoyad);
            this.groupBox2.Controls.Add(this.txtFin);
            this.groupBox2.Controls.Add(this.txtSeriya);
            this.groupBox2.Location = new System.Drawing.Point(490, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 480);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vəsiqə məlumatları";

            this.txtSeriya.Location = new System.Drawing.Point(180, 30); this.txtSeriya.Size = new System.Drawing.Size(260, 22); this.txtSeriya.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txtFin.Location = new System.Drawing.Point(180, 65); this.txtFin.Size = new System.Drawing.Size(260, 22); this.txtFin.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txtSoyad.Location = new System.Drawing.Point(180, 100); this.txtSoyad.Size = new System.Drawing.Size(260, 22); this.txtSoyad.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txtAd.Location = new System.Drawing.Point(180, 135); this.txtAd.Size = new System.Drawing.Size(260, 22); this.txtAd.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txtAtaAdi.Location = new System.Drawing.Point(180, 170); this.txtAtaAdi.Size = new System.Drawing.Size(260, 22); this.txtAtaAdi.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txtCins.Location = new System.Drawing.Point(180, 205); this.txtCins.Size = new System.Drawing.Size(260, 22); this.txtCins.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txtDogumTarixi.Location = new System.Drawing.Point(180, 240); this.txtDogumTarixi.Size = new System.Drawing.Size(260, 22); this.txtDogumTarixi.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txtDogumYeri.Location = new System.Drawing.Point(180, 275); this.txtDogumYeri.Size = new System.Drawing.Size(260, 22); this.txtDogumYeri.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txtAileVeziyyeti.Location = new System.Drawing.Point(180, 310); this.txtAileVeziyyeti.Size = new System.Drawing.Size(260, 22); this.txtAileVeziyyeti.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txtVerilmeTarixi.Location = new System.Drawing.Point(180, 345); this.txtVerilmeTarixi.Size = new System.Drawing.Size(260, 22); this.txtVerilmeTarixi.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txtEtibarlidir.Location = new System.Drawing.Point(180, 380); this.txtEtibarlidir.Size = new System.Drawing.Size(260, 22); this.txtEtibarlidir.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txtVerenOrgan.Location = new System.Drawing.Point(180, 415); this.txtVerenOrgan.Size = new System.Drawing.Size(260, 22); this.txtVerenOrgan.TextChanged += new System.EventHandler(this.txt_TextChanged);

            this.btnTemizle.Location = new System.Drawing.Point(670, 510);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(130, 40);
            this.btnTemizle.TabIndex = 2;
            this.btnTemizle.Text = "Təmizlə";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);

            this.btnYaddaSaxla.Location = new System.Drawing.Point(820, 510);
            this.btnYaddaSaxla.Name = "btnYaddaSaxla";
            this.btnYaddaSaxla.Size = new System.Drawing.Size(130, 40);
            this.btnYaddaSaxla.TabIndex = 3;
            this.btnYaddaSaxla.Text = "Yadda saxla";
            this.btnYaddaSaxla.UseVisualStyleBackColor = true;
            this.btnYaddaSaxla.Click += new System.EventHandler(this.btnYaddaSaxla_Click);

            this.progressBar1.Location = new System.Drawing.Point(12, 515);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(630, 30);
            this.progressBar1.TabIndex = 4;
            this.progressBar1.Visible = false;

            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 570);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnYaddaSaxla);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Azərbaycan Şəxsiyyət Vəsiqəsi";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Button btnSekilYukle;
        private System.Windows.Forms.Label lblSeriya;
        private System.Windows.Forms.Label lblFin;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblAtaAdi;
        private System.Windows.Forms.Label lblCins;
        private System.Windows.Forms.Label lblDogumTarixi;
        private System.Windows.Forms.Label lblDogumYeri;
        private System.Windows.Forms.Label lblAileVaz;
        private System.Windows.Forms.Label lblVerilme;
        private System.Windows.Forms.Label lblEtibarlidir;
        private System.Windows.Forms.Label lblVerenOrgan;

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSeriya;
        private System.Windows.Forms.TextBox txtFin;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtAtaAdi;
        private System.Windows.Forms.TextBox txtCins;
        private System.Windows.Forms.TextBox txtDogumTarixi;
        private System.Windows.Forms.TextBox txtDogumYeri;
        private System.Windows.Forms.TextBox txtAileVeziyyeti;
        private System.Windows.Forms.TextBox txtVerilmeTarixi;
        private System.Windows.Forms.TextBox txtEtibarlidir;
        private System.Windows.Forms.TextBox txtVerenOrgan;

        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnYaddaSaxla;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}