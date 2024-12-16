using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityProjectApp
{
    public partial class Frm_Urun : Form
    {
        public Frm_Urun()
        {
            InitializeComponent();
        }

        private void Frm_Urun_Load(object sender, EventArgs e)
        {
            listele();
            var kategoriler = (from x in db.Tbl_kategori
                               select new
                               {
                                 x.ID,
                                 x.AD
                               }).ToList();
            Cmb_kategori.ValueMember = "ID";
            Cmb_kategori.DisplayMember = "AD";
            Cmb_kategori.DataSource = kategoriler;

            Cmb_kategori.SelectedIndex = -1;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = e.RowIndex;

            if (selectedRowIndex >= 0) // Geçerli bir satır mı kontrol et
            {
                // DataGridView'den seçilen satırdaki verileri al
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];

                // TextBox'lara atama yap
                Txturunıd.Text = selectedRow.Cells["URUNID"].Value.ToString();
                Txturunad.Text = selectedRow.Cells["URUNAD"].Value.ToString();
                Txturunmarka.Text = selectedRow.Cells["MARKA"].Value.ToString();
                Txturunstok.Text = selectedRow.Cells["STOK"].Value.ToString();
                Txturunfiyat.Text = selectedRow.Cells["FIYAT"].Value.ToString();
                
               
            }
        }

        DbEntityUrunEntities db = new DbEntityUrunEntities();
        private void Btn_Listele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in db.Tbl_urun
                                        select new
                                        {
                                            x.URUNID,
                                            x.URUNAD,
                                            x.MARKA,
                                            x.STOK,
                                            x.FIYAT,
                                            x.Tbl_kategori.AD,
                                            x.DURUM
                                        }).ToList();
        }

        private void listele()
        {
            dataGridView1.DataSource = (from x in db.Tbl_urun
                                        select new
                                        {
                                            x.URUNID,
                                            x.URUNAD,
                                            x.MARKA,
                                            x.STOK,
                                            x.FIYAT,
                                            x.Tbl_kategori.AD,
                                            x.DURUM
                                        }).ToList();
        }

        private void Btn_Ekle_Click(object sender, EventArgs e)
        {
            Tbl_urun t = new Tbl_urun();
            t.URUNAD = Txturunad.Text;
            t.MARKA = Txturunmarka.Text;
            t.STOK = short.Parse(Txturunstok.Text);
            t.KATEGORI = int.Parse(Cmb_kategori.SelectedValue.ToString());
            t.FIYAT = decimal.Parse(Txturunfiyat.Text);
            t.DURUM = true;
            db.Tbl_urun.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün başarılı bir şekilde eklenmiştir", "Başarılı işlem bildirimi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();

        }

        private void Btn_Sil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Txturunıd.Text);
            var urun = db.Tbl_urun.Find(x);
            db.Tbl_urun.Remove(urun);
            db.SaveChanges();
            MessageBox.Show("Ürün başarılı bir şekilde silindi", "Başarılı işlem bildirimi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void Btn_Güncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Txturunıd.Text);
            var urun = db.Tbl_urun.Find(x);
            urun.URUNAD = Txturunad.Text;
            urun.MARKA = Txturunmarka.Text;
            urun.STOK = short.Parse(Txturunstok.Text);
            urun.FIYAT = decimal.Parse(Txturunfiyat.Text);
            db.SaveChanges();
            MessageBox.Show("Güncelleme işlemi başarılı", "Başarılı işlem bildirimi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            
        }

        private void Btn_Temizle_Click(object sender, EventArgs e)
        {
            Txturunad.Text = " ";
            Txturunmarka.Text = " ";
            Txturunıd.Text = " ";
            Txturunstok.Text = " ";
            Txturunfiyat.Text = " ";
            textBox6.Text = " ";
            Cmb_kategori.SelectedIndex = -1;
        }
    }
}
