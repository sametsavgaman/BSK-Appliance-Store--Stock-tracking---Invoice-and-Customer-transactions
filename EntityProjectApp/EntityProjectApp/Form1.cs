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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        DbEntityUrunEntities db = new DbEntityUrunEntities();
        private void Btn_Listele_Click(object sender, EventArgs e)
        {
            var kategoriler = db.Tbl_kategori.ToList();
            dataGridView1.DataSource = kategoriler;
        }

        private void Btn_Ekle_Click(object sender, EventArgs e)
        {
            Tbl_kategori t = new Tbl_kategori();
            t.AD = textBox2.Text;
            db.Tbl_kategori.Add(t);
            db.SaveChanges();
            MessageBox.Show("Kategori başarı ile eklendi", "Başarılı işlem bildirimi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Btn_Sil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            var ktgr = db.Tbl_kategori.Find(x);
            db.Tbl_kategori.Remove(ktgr);
            db.SaveChanges();
            MessageBox.Show("Kategori silindi", "Silme işlemi başarılı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void Btn_Guncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            var ktgr = db.Tbl_kategori.Find(x);
            ktgr.AD = textBox2.Text;
            db.SaveChanges();
            MessageBox.Show("Güncelleme yapıldı", "Başarılı işlem bildirimi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void listele()
        {
            dataGridView1.DataSource = (from x in db.Tbl_kategori select new
            {
                x.ID,
                x.AD
            }).ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = e.RowIndex;

            if (selectedRowIndex >= 0) // Geçerli bir satır mı kontrol et
            {
                // DataGridView'den seçilen satırdaki verileri al
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];

                // TextBox'lara atama yap
               textBox1.Text = selectedRow.Cells["ID"].Value.ToString();
               textBox2.Text = selectedRow.Cells["AD"].Value.ToString();  
               

            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
        }
    }
}
