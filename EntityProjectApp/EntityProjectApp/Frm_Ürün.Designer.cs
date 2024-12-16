namespace EntityProjectApp
{
    partial class Frm_Urun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Urun));
            this.label1 = new System.Windows.Forms.Label();
            this.Txturunıd = new System.Windows.Forms.TextBox();
            this.Txturunad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txturunmarka = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txturunstok = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txturunfiyat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Btn_Listele = new System.Windows.Forms.Button();
            this.Btn_Ekle = new System.Windows.Forms.Button();
            this.Btn_Sil = new System.Windows.Forms.Button();
            this.Btn_Güncelle = new System.Windows.Forms.Button();
            this.Btn_Temizle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Cmb_kategori = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(704, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün ID :";
            // 
            // Txturunıd
            // 
            this.Txturunıd.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txturunıd.Location = new System.Drawing.Point(795, 72);
            this.Txturunıd.Name = "Txturunıd";
            this.Txturunıd.Size = new System.Drawing.Size(99, 31);
            this.Txturunıd.TabIndex = 1;
            // 
            // Txturunad
            // 
            this.Txturunad.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txturunad.Location = new System.Drawing.Point(795, 105);
            this.Txturunad.Name = "Txturunad";
            this.Txturunad.Size = new System.Drawing.Size(99, 31);
            this.Txturunad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(695, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ürün Adı :";
            // 
            // Txturunmarka
            // 
            this.Txturunmarka.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txturunmarka.Location = new System.Drawing.Point(795, 138);
            this.Txturunmarka.Name = "Txturunmarka";
            this.Txturunmarka.Size = new System.Drawing.Size(99, 31);
            this.Txturunmarka.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(716, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Marka :";
            // 
            // Txturunstok
            // 
            this.Txturunstok.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txturunstok.Location = new System.Drawing.Point(795, 171);
            this.Txturunstok.Name = "Txturunstok";
            this.Txturunstok.Size = new System.Drawing.Size(99, 31);
            this.Txturunstok.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(730, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Stok :";
            // 
            // Txturunfiyat
            // 
            this.Txturunfiyat.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txturunfiyat.Location = new System.Drawing.Point(795, 204);
            this.Txturunfiyat.Name = "Txturunfiyat";
            this.Txturunfiyat.Size = new System.Drawing.Size(99, 31);
            this.Txturunfiyat.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(727, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fiyat :";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox6.Location = new System.Drawing.Point(795, 237);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(99, 31);
            this.textBox6.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(710, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 26);
            this.label6.TabIndex = 10;
            this.label6.Text = "Durum :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(695, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 26);
            this.label7.TabIndex = 12;
            this.label7.Text = "Kategori :";
            // 
            // Btn_Listele
            // 
            this.Btn_Listele.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Listele.Location = new System.Drawing.Point(933, 82);
            this.Btn_Listele.Name = "Btn_Listele";
            this.Btn_Listele.Size = new System.Drawing.Size(115, 37);
            this.Btn_Listele.TabIndex = 14;
            this.Btn_Listele.Text = "Listele";
            this.Btn_Listele.UseVisualStyleBackColor = true;
            this.Btn_Listele.Click += new System.EventHandler(this.Btn_Listele_Click);
            // 
            // Btn_Ekle
            // 
            this.Btn_Ekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_Ekle.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Ekle.Location = new System.Drawing.Point(933, 128);
            this.Btn_Ekle.Name = "Btn_Ekle";
            this.Btn_Ekle.Size = new System.Drawing.Size(115, 37);
            this.Btn_Ekle.TabIndex = 15;
            this.Btn_Ekle.Text = "Ekle";
            this.Btn_Ekle.UseVisualStyleBackColor = true;
            this.Btn_Ekle.Click += new System.EventHandler(this.Btn_Ekle_Click);
            // 
            // Btn_Sil
            // 
            this.Btn_Sil.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Sil.Location = new System.Drawing.Point(933, 173);
            this.Btn_Sil.Name = "Btn_Sil";
            this.Btn_Sil.Size = new System.Drawing.Size(115, 37);
            this.Btn_Sil.TabIndex = 16;
            this.Btn_Sil.Text = "Sil";
            this.Btn_Sil.UseVisualStyleBackColor = true;
            this.Btn_Sil.Click += new System.EventHandler(this.Btn_Sil_Click);
            // 
            // Btn_Güncelle
            // 
            this.Btn_Güncelle.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Güncelle.Location = new System.Drawing.Point(933, 219);
            this.Btn_Güncelle.Name = "Btn_Güncelle";
            this.Btn_Güncelle.Size = new System.Drawing.Size(115, 37);
            this.Btn_Güncelle.TabIndex = 17;
            this.Btn_Güncelle.Text = "Güncelle";
            this.Btn_Güncelle.UseVisualStyleBackColor = true;
            this.Btn_Güncelle.Click += new System.EventHandler(this.Btn_Güncelle_Click);
            // 
            // Btn_Temizle
            // 
            this.Btn_Temizle.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Temizle.Location = new System.Drawing.Point(933, 265);
            this.Btn_Temizle.Name = "Btn_Temizle";
            this.Btn_Temizle.Size = new System.Drawing.Size(115, 28);
            this.Btn_Temizle.TabIndex = 18;
            this.Btn_Temizle.Text = "Temizle";
            this.Btn_Temizle.UseVisualStyleBackColor = true;
            this.Btn_Temizle.Click += new System.EventHandler(this.Btn_Temizle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(668, 313);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(662, 287);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Cmb_kategori
            // 
            this.Cmb_kategori.FormattingEnabled = true;
            this.Cmb_kategori.Location = new System.Drawing.Point(794, 272);
            this.Cmb_kategori.Name = "Cmb_kategori";
            this.Cmb_kategori.Size = new System.Drawing.Size(100, 27);
            this.Cmb_kategori.TabIndex = 20;
            // 
            // Frm_Urun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1088, 403);
            this.Controls.Add(this.Cmb_kategori);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Btn_Temizle);
            this.Controls.Add(this.Btn_Güncelle);
            this.Controls.Add(this.Btn_Sil);
            this.Controls.Add(this.Btn_Ekle);
            this.Controls.Add(this.Btn_Listele);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Txturunfiyat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txturunstok);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txturunmarka);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txturunad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txturunıd);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Urun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BSK Market - Ürün İşlemleri Modülü";
            this.Load += new System.EventHandler(this.Frm_Urun_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txturunıd;
        private System.Windows.Forms.TextBox Txturunad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txturunmarka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txturunstok;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txturunfiyat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Btn_Listele;
        private System.Windows.Forms.Button Btn_Ekle;
        private System.Windows.Forms.Button Btn_Sil;
        private System.Windows.Forms.Button Btn_Güncelle;
        private System.Windows.Forms.Button Btn_Temizle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox Cmb_kategori;
    }
}