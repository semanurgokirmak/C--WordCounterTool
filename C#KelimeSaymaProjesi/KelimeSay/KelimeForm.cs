using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KelimeSay
{
    public partial class KelimeForm : Form
    {
        public KelimeForm()
        {
            InitializeComponent();
        }

        #region Değişkenler ve Tanımlamalar

        #endregion

        #region Kullanıcı Tanımlı Olaylar
        private void Temizle ()
        {
            //tbKelime.Text = tbMetin.Text = "";
            tbKelime.Clear();
            tbMetin.Clear();
            lvListe.Items.Clear();
            tbMetin.Select();
        }
        #endregion

        #region Nesne Tanımlı Olaylar
        private void KelimeForm_Load(object sender, EventArgs e)
        {
            this.Width = 375;
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            this.Width = 375;
            Temizle();
            //tbKelime.Clear();
            //tbMetin.Clear();
            //lvListe.Items.Clear();
            //tbMetin.Select();
        }
        private void tbMetin_Click(object sender, EventArgs e)
        {
            Temizle();
            this.Width = 375;
        }

        private void BtnHesapla_Click(object sender, EventArgs e)
        {
            //string[] Cumle = { "Ahmet", "Bayraktar" }; 
            //string[] Cumle = new string[50];
            //Cumle[0] = "Ahmet";
            //Cumle[1] = "Bayraktar";
            string[] Cumle = tbMetin.Text.Split(new[] { " " }, StringSplitOptions.None);
            string BulunanKelime = "";
            int HarfSayisi = 0;
            foreach (string Kelime in Cumle)
            {
                ListViewItem SecilenKelime = new ListViewItem();
                SecilenKelime.Text = Kelime;
                SecilenKelime.SubItems.Add(Kelime.Length.ToString());
                lvListe.Items.Add(SecilenKelime);
                if (Kelime.Length>HarfSayisi)
                {
                    BulunanKelime = Kelime;
                    HarfSayisi = Kelime.Length;
                }
            }
            tbKelime.Text = BulunanKelime;  
        }

        private void btnListe_Click(object sender, EventArgs e)
        {
            this.Width = 800;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Uygulama \n Sonlandırılsın mı?", "Çıkış Onayı",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                Application.Exit();
        }
        #endregion
    }
}
