namespace EntityProjectApp
{
    partial class Frm_Müsteriler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Müsteriler));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txtmüsteriid = new System.Windows.Forms.TextBox();
            this.Btn_Ekle = new System.Windows.Forms.Button();
            this.Txtmüsteriad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txtmüsterisoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Cmb_sehir = new System.Windows.Forms.ComboBox();
            this.Btn_Sil = new System.Windows.Forms.Button();
            this.Btn_Guncelle = new System.Windows.Forms.Button();
            this.Btn_Temizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 27);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(632, 371);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(638, 401);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Listesi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(716, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Müşteri ID :";
            // 
            // Txtmüsteriid
            // 
            this.Txtmüsteriid.Location = new System.Drawing.Point(832, 58);
            this.Txtmüsteriid.Name = "Txtmüsteriid";
            this.Txtmüsteriid.Size = new System.Drawing.Size(144, 31);
            this.Txtmüsteriid.TabIndex = 3;
            // 
            // Btn_Ekle
            // 
            this.Btn_Ekle.Location = new System.Drawing.Point(687, 244);
            this.Btn_Ekle.Name = "Btn_Ekle";
            this.Btn_Ekle.Size = new System.Drawing.Size(289, 38);
            this.Btn_Ekle.TabIndex = 4;
            this.Btn_Ekle.Text = "Müşteri Ekle";
            this.Btn_Ekle.UseVisualStyleBackColor = true;
            this.Btn_Ekle.Click += new System.EventHandler(this.Btn_Ekle_Click);
            // 
            // Txtmüsteriad
            // 
            this.Txtmüsteriad.Location = new System.Drawing.Point(832, 95);
            this.Txtmüsteriad.Name = "Txtmüsteriad";
            this.Txtmüsteriad.Size = new System.Drawing.Size(144, 31);
            this.Txtmüsteriad.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(712, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Müşteri Ad :";
            // 
            // Txtmüsterisoyad
            // 
            this.Txtmüsterisoyad.Location = new System.Drawing.Point(832, 132);
            this.Txtmüsterisoyad.Name = "Txtmüsterisoyad";
            this.Txtmüsterisoyad.Size = new System.Drawing.Size(144, 31);
            this.Txtmüsterisoyad.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(682, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Müşteri Soyad :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(759, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "Şehir :";
            // 
            // Cmb_sehir
            // 
            this.Cmb_sehir.FormattingEnabled = true;
            this.Cmb_sehir.Items.AddRange(new object[] {
            " Adana",
            " Adıyaman",
            " Afyonkarahisar",
            " Ağrı",
            " Aksaray",
            " Amasya",
            " Ankara",
            " Antalya",
            " Ardahan",
            " Artvin",
            " Aydın",
            " Balıkesir",
            " Bartın",
            " Batman",
            " Bayburt",
            " Bilecik",
            " Bingöl",
            " Bitlis",
            " Bolu",
            " Burdur",
            " Bursa",
            " Çanakkale",
            " Çankırı",
            " Çorum",
            " Denizli",
            " Diyarbakır",
            " Düzce",
            " Edirne",
            " Elazığ",
            " Erzincan",
            " Erzurum",
            " Eskişehir",
            " Gaziantep",
            " Giresun",
            " Gümüşhane",
            " Hakkâri",
            " Hatay",
            " Iğdır",
            " Isparta",
            " İstanbul",
            " İzmir",
            " Kahramanmaraş",
            " Karabük",
            " Karaman",
            " Kars",
            " Kastamonu",
            " Kayseri",
            " Kilis",
            " Kırıkkale",
            " Kırklareli",
            " Kırşehir",
            " Kocaeli",
            " Konya",
            " Kütahya",
            " Malatya",
            " Manisa",
            " Mardin",
            " Mersin",
            " Muğla",
            " Muş",
            " Nevşehir",
            " Niğde",
            " Ordu",
            " Osmaniye",
            " Rize",
            " Sakarya",
            " Samsun",
            " Şanlıurfa",
            " Siirt",
            " Sinop",
            " Sivas",
            " Şırnak",
            " Tekirdağ",
            " Tokat",
            " Trabzon",
            " Tunceli",
            " Uşak",
            " Van",
            " Yalova",
            " Yozgat",
            " Zonguldak"});
            this.Cmb_sehir.Location = new System.Drawing.Point(832, 169);
            this.Cmb_sehir.Name = "Cmb_sehir";
            this.Cmb_sehir.Size = new System.Drawing.Size(144, 31);
            this.Cmb_sehir.TabIndex = 10;
            // 
            // Btn_Sil
            // 
            this.Btn_Sil.Location = new System.Drawing.Point(687, 288);
            this.Btn_Sil.Name = "Btn_Sil";
            this.Btn_Sil.Size = new System.Drawing.Size(289, 38);
            this.Btn_Sil.TabIndex = 11;
            this.Btn_Sil.Text = "Müşteri Sil";
            this.Btn_Sil.UseVisualStyleBackColor = true;
            this.Btn_Sil.Click += new System.EventHandler(this.Btn_Sil_Click);
            // 
            // Btn_Guncelle
            // 
            this.Btn_Guncelle.Location = new System.Drawing.Point(687, 332);
            this.Btn_Guncelle.Name = "Btn_Guncelle";
            this.Btn_Guncelle.Size = new System.Drawing.Size(289, 38);
            this.Btn_Guncelle.TabIndex = 12;
            this.Btn_Guncelle.Text = "Güncelle";
            this.Btn_Guncelle.UseVisualStyleBackColor = true;
            this.Btn_Guncelle.Click += new System.EventHandler(this.Btn_Guncelle_Click);
            // 
            // Btn_Temizle
            // 
            this.Btn_Temizle.Location = new System.Drawing.Point(832, 206);
            this.Btn_Temizle.Name = "Btn_Temizle";
            this.Btn_Temizle.Size = new System.Drawing.Size(144, 27);
            this.Btn_Temizle.TabIndex = 13;
            this.Btn_Temizle.Text = "Temizle";
            this.Btn_Temizle.UseVisualStyleBackColor = true;
            this.Btn_Temizle.Click += new System.EventHandler(this.Btn_Temizle_Click);
            // 
            // Frm_Müsteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1026, 402);
            this.Controls.Add(this.Btn_Temizle);
            this.Controls.Add(this.Btn_Guncelle);
            this.Controls.Add(this.Btn_Sil);
            this.Controls.Add(this.Cmb_sehir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txtmüsterisoyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txtmüsteriad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_Ekle);
            this.Controls.Add(this.Txtmüsteriid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Müsteriler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BSK Market - Müşteri Kayıtları";
            this.Load += new System.EventHandler(this.Frm_Müsteriler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txtmüsteriid;
        private System.Windows.Forms.Button Btn_Ekle;
        private System.Windows.Forms.TextBox Txtmüsteriad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txtmüsterisoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Cmb_sehir;
        private System.Windows.Forms.Button Btn_Sil;
        private System.Windows.Forms.Button Btn_Guncelle;
        private System.Windows.Forms.Button Btn_Temizle;
    }
}