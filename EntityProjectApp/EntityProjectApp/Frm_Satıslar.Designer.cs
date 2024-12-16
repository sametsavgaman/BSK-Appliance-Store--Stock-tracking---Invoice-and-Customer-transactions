namespace EntityProjectApp
{
    partial class Frm_Satıslar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Satıslar));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Txtsatisid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txtmüsteri = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txtfiyat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Msk_tarih = new System.Windows.Forms.MaskedTextBox();
            this.Cmb_Ürün = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(639, 333);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Satış Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(633, 303);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(745, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Satış ID :";
            // 
            // Txtsatisid
            // 
            this.Txtsatisid.Location = new System.Drawing.Point(839, 23);
            this.Txtsatisid.Name = "Txtsatisid";
            this.Txtsatisid.ReadOnly = true;
            this.Txtsatisid.Size = new System.Drawing.Size(156, 31);
            this.Txtsatisid.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(766, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ürün :";
            // 
            // Txtmüsteri
            // 
            this.Txtmüsteri.Location = new System.Drawing.Point(839, 97);
            this.Txtmüsteri.Name = "Txtmüsteri";
            this.Txtmüsteri.Size = new System.Drawing.Size(156, 31);
            this.Txtmüsteri.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(654, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Müşteri  AD SOYAD:";
            // 
            // Txtfiyat
            // 
            this.Txtfiyat.Location = new System.Drawing.Point(839, 134);
            this.Txtfiyat.Name = "Txtfiyat";
            this.Txtfiyat.Size = new System.Drawing.Size(156, 31);
            this.Txtfiyat.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(720, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Satış Fiyatı :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(766, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tarih :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(695, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 34);
            this.button1.TabIndex = 11;
            this.button1.Text = "Yeni Satış Gir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(695, 274);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(300, 34);
            this.button2.TabIndex = 12;
            this.button2.Text = "Satış Kaydını Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(695, 314);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(300, 34);
            this.button3.TabIndex = 13;
            this.button3.Text = "Fatura Yazdır";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(695, 354);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(300, 34);
            this.button4.TabIndex = 14;
            this.button4.Text = "Güncelle";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(642, 23);
            this.label6.TabIndex = 15;
            this.label6.Text = "Lütfen hatalı işlem değilse satış silmeyiniz. Satış bilgileri log kayıtlarından s" +
    "ilinmez.";
            // 
            // Msk_tarih
            // 
            this.Msk_tarih.Location = new System.Drawing.Point(839, 171);
            this.Msk_tarih.Mask = "00/00/0000";
            this.Msk_tarih.Name = "Msk_tarih";
            this.Msk_tarih.Size = new System.Drawing.Size(156, 31);
            this.Msk_tarih.TabIndex = 16;
            this.Msk_tarih.ValidatingType = typeof(System.DateTime);
            // 
            // Cmb_Ürün
            // 
            this.Cmb_Ürün.FormattingEnabled = true;
            this.Cmb_Ürün.Location = new System.Drawing.Point(839, 61);
            this.Cmb_Ürün.Name = "Cmb_Ürün";
            this.Cmb_Ürün.Size = new System.Drawing.Size(156, 31);
            this.Cmb_Ürün.TabIndex = 17;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Location = new System.Drawing.Point(839, 209);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(156, 23);
            this.button5.TabIndex = 18;
            this.button5.Text = "Temizle";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Frm_Satıslar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1027, 398);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Cmb_Ürün);
            this.Controls.Add(this.Msk_tarih);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txtfiyat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txtmüsteri);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txtsatisid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Satıslar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BSK Market - Satış İşlem Modülü";
            this.Load += new System.EventHandler(this.Frm_Satıslar_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txtsatisid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txtmüsteri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txtfiyat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox Msk_tarih;
        private System.Windows.Forms.ComboBox Cmb_Ürün;
        private System.Windows.Forms.Button button5;
    }
}