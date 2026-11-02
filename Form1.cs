using System;
using System.Drawing;
using System.Windows.Forms;

namespace Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            lblSeriya.Text = "Seriya: " + txtSeriya.Text;
            lblFin.Text = "FİN: " + txtFin.Text;
            lblSoyad.Text = "Soyad: " + txtSoyad.Text;
            lblAd.Text = "Ad: " + txtAd.Text;
            lblAtaAdi.Text = "Ata adı: " + txtAtaAdi.Text;
            lblCins.Text = "Cins: " + txtCins.Text;
            lblDogumTarixi.Text = "Doğum tarixi: " + txtDogumTarixi.Text;
            lblDogumYeri.Text = "Doğum yeri: " + txtDogumYeri.Text;
            lblAileVaz.Text = "Ailə vəz.: " + txtAileVeziyyeti.Text;
            lblVerilme.Text = "Verilmə: " + txtVerilmeTarixi.Text;
            lblEtibarlidir.Text = "Etibarlıdır: " + txtEtibarlidir.Text;
            lblVerenOrgan.Text = "Verən organ: " + txtVerenOrgan.Text;
        }

        private void btnSekilYukle_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "PNG faylları (*.png)|*.png";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbFoto.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnYaddaSaxla_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Visible = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 10;
            }
            else
            {
                timer1.Stop();

                bool bosXanaVar = txtSeriya.Text == "" || txtFin.Text == "" || txtSoyad.Text == "" ||
                                 txtAd.Text == "" || txtAtaAdi.Text == "" || txtCins.Text == "" ||
                                 txtDogumTarixi.Text == "" || txtDogumYeri.Text == "" ||
                                 txtAileVeziyyeti.Text == "" || txtVerilmeTarixi.Text == "" ||
                                 txtEtibarlidir.Text == "" || txtVerenOrgan.Text == "";

                DialogResult result;

                if (bosXanaVar)
                {
                    result = MessageBox.Show("Məlumatlar tam daxil edilməyib", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    result = MessageBox.Show("Yadda saxlandı", "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (result == DialogResult.OK)
                {
                    progressBar1.Visible = false;
                }
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtSeriya.Clear();
            txtFin.Clear();
            txtSoyad.Clear();
            txtAd.Clear();
            txtAtaAdi.Clear();
            txtCins.Clear();
            txtDogumTarixi.Clear();
            txtDogumYeri.Clear();
            txtAileVeziyyeti.Clear();
            txtVerilmeTarixi.Clear();
            txtEtibarlidir.Clear();
            txtVerenOrgan.Clear();
            pbFoto.Image = null;
        }
    }
}