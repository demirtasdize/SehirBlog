using FormSınavı.Class;
using FormSınavı.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormSınavı
{
    public partial class MekanEkle : Form
    {
        DatabaseContext db = new DatabaseContext();
        static public int sehirID;

        public MekanEkle()
        {
            InitializeComponent();
        }

        private void btnMekanEkle_Click(object sender, EventArgs e)
        {
            Sehir secili = (db.Sehirler.FirstOrDefault(x => x.ID == sehirID));
            var yenimekan = new Mekan();
            yenimekan.Ad = txtMekanAdı.Text;
            yenimekan.Adres = txtAdres.Text;
            yenimekan.Aciklama = txtAciklama.Text;
            yenimekan.Tel = txtTel.Text;
            yenimekan.SehirID = secili.ID;
            db.Mekanlar.Add(yenimekan);
            db.SaveChanges();
            MessageBox.Show("Mekan eklendi.");
            this.Close();
        }

        private void MekanEkle_Load(object sender, EventArgs e)
        {
            Sehir secili = (db.Sehirler.FirstOrDefault(x => x.ID == sehirID));
            lblSehirAdi.Text = secili.Ad;
        }
    }
}
