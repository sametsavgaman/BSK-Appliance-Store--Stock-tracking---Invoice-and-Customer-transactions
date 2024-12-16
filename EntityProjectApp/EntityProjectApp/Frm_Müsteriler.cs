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
    public partial class Frm_Müsteriler : Form
    {
        public Frm_Müsteriler()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        DbEntityUrunEntities db = new DbEntityUrunEntities();
        private void Frm_Müsteriler_Load(object sender, EventArgs e)
        {

            using (var context = new DbEntityUrunEntities())
            {
                var data = context.Tbl_musteriler.Select(x => new
                {
                    x.MUSTERIID,
                    x.MUSTERIAD,
                    x.MUSTERISOYAD,
                    x.SEHIR
                }).ToList();
                dataGridView1.DataSource = data;

            }
        }

        private void Btn_Temizle_Click(object sender, EventArgs e)
        {
            Txtmüsteriid.Text = "";
            Txtmüsteriad.Text = "";
            Txtmüsterisoyad.Text = "";
            Cmb_sehir.SelectedValue = -1;
        }

        DbEntityUrunEntities dl = new DbEntityUrunEntities();

        private void listele()
        {
            dataGridView1.DataSource = (from x in dl.Tbl_musteriler
                                        select new
                                        {
                                            x.MUSTERIID,
                                            x.MUSTERIAD,
                                            x.MUSTERISOYAD,
                                            x.SEHIR
                                        }).ToList();

        }
        private void Btn_Ekle_Click(object sender, EventArgs e)
        {
            Tbl_musteriler t = new Tbl_musteriler();

            t.MUSTERIAD = Txtmüsteriad.Text;
            t.MUSTERISOYAD = Txtmüsterisoyad.Text;
            t.SEHIR = Cmb_sehir.Text;
            t.DURUM = true;
            dl.Tbl_musteriler.Add(t);
            dl.SaveChanges();
            MessageBox.Show("Müşteri kaydı başarılı şekilde eklendi", "Başarılı kayıt işlem bildirimi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void Btn_Sil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Txtmüsteriid.Text);
            var musterı = dl.Tbl_musteriler.Find(x);
            dl.Tbl_musteriler.Remove(musterı);
            db.SaveChanges();
            MessageBox.Show("Müşteri kaydı silindi", "Kayıt silme işlemi başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void Btn_Guncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Txtmüsteriid.Text);
            var musterı = dl.Tbl_musteriler.Find(x);
            musterı.MUSTERIAD = Txtmüsteriad.Text;
            musterı.MUSTERISOYAD = Txtmüsterisoyad.Text;
            musterı.SEHIR = Cmb_sehir.Text;
            dl.SaveChanges();
            MessageBox.Show("Ürün başarıyla güncellendi", "Başarılı işlem bildirimi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.CurrentRow != null)
            {
                Txtmüsteriid.Text = dataGridView1.CurrentRow.Cells["MUSTERIID"].Value.ToString();
                Txtmüsteriad.Text = dataGridView1.CurrentRow.Cells["MUSTERIAD"].Value.ToString();
                Txtmüsterisoyad.Text = dataGridView1.CurrentRow.Cells["MUSTERISOYAD"].Value.ToString();

                //sehiri comboboxta secili hale getirme
                var sehiradi = dataGridView1.CurrentRow.Cells["SEHIR"].Value.ToString();
                if (!string.IsNullOrEmpty(sehiradi))
                {


                    // ComboBox'ta bu şehri seç
                    Cmb_sehir.SelectedItem = sehiradi;
                }

            }
        }
    }
}
