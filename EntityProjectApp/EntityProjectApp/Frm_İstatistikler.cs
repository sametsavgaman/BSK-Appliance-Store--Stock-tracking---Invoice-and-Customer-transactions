using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityProjectApp
{
    public partial class Frm_İstatistikler : Form
    {
        public Frm_İstatistikler()
        {
            InitializeComponent();
        }

        private void Btn_Menü_Click(object sender, EventArgs e)
        {
            Frm_Anasayfa fr = new Frm_Anasayfa();
            fr.Show();
            this.Hide();
        }

        private void Btn_Cıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        DbEntityUrunEntities db = new DbEntityUrunEntities();
        private void Frm_İstatistikler_Load(object sender, EventArgs e)
        {
            label2.Text = db.Tbl_kategori.Count().ToString();
            label3.Text = db.Tbl_urun.Count().ToString();
            label5.Text = db.Tbl_musteriler.Count(x => x.DURUM == true).ToString();
            label7.Text = db.Tbl_musteriler.Count(x => x.DURUM == false).ToString();
            label19.Text = db.Tbl_urun.Sum(x => x.STOK).ToString();
            label21.Text = db.Tbl_satıs.Sum(x => x.FIYAT).ToString()+" TL";
            label13.Text = (from x in db.Tbl_urun orderby x.FIYAT descending select x.URUNAD).FirstOrDefault();
            label15.Text = (from x in db.Tbl_urun orderby x.FIYAT ascending select x.URUNAD).FirstOrDefault();
            label9.Text = db.Tbl_urun.Count(x => x.KATEGORI == 1).ToString();
            label11.Text = db.Tbl_urun.Count(x => x.KATEGORI == 2).ToString();
            label23.Text = (from x in db.Tbl_musteriler select x.SEHIR).Distinct().Count().ToString();

        }
    }
}
