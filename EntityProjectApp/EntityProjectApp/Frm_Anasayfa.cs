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
    public partial class Frm_Anasayfa : Form
    {
        public Frm_Anasayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            Form1 fr = new Form1();
            fr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_Urun fr = new Frm_Urun();
            fr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frm_İstatistikler fr = new Frm_İstatistikler();
            fr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Frm_Satıslar fr = new Frm_Satıslar();
            fr.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Frm_Müsteriler fr = new Frm_Müsteriler();
            fr.Show();
        }
    }
}
