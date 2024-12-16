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
    public partial class Frm_Giris : Form
    {
        public Frm_Giris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DbEntityUrunEntities db = new DbEntityUrunEntities();
            var sorgu = from x in db.Tbl_Admin where x.KULLANICI == textBox1.Text && x.SIFRE == textBox2.Text select x;
            if (sorgu.Any())
            {
                Frm_Anasayfa fr = new Frm_Anasayfa();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı Veya Şifre Girdiniz", "Hatalı Giriş Denemesi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
