using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices.ComTypes;
using static iTextSharp.text.Image;

namespace EntityProjectApp
{
    public partial class Frm_Satıslar : Form
    {
        public Frm_Satıslar()
        {
            InitializeComponent();
        }

        public class FooterEvent : PdfPageEventHelper
        {
            public override void OnEndPage(PdfWriter writer, Document document)
            {
                PdfContentByte cb = writer.DirectContent;
                Phrase footer = new Phrase("BSK MARKET TICARET LIMITED SIRKETİ BILGİ FISIDIR. MALI DEGERI YOKTUR", FontFactory.GetFont("Arial", 12));
                ColumnText.ShowTextAligned(cb, Element.ALIGN_RIGHT, footer, document.Right - 40, document.Bottom + 30, 0);
            }
        }

        DbEntityUrunEntities db = new DbEntityUrunEntities();
        private void Frm_Satıslar_Load(object sender, EventArgs e)
        {
            //Tablo'nun doğru gösterimi
            using (var context = new DbEntityUrunEntities())
            {
                var data = (from satis in context.Tbl_satıs
                            join musteri in context.Tbl_musteriler
                            on satis.MUSTERI equals musteri.MUSTERIID
                            join urun in context.Tbl_urun
                            on satis.URUN equals urun.URUNID
                            select new
                            {
                                satis.SATISID,
                                URUN = urun.URUNAD,
                                MUSTERI = musteri.MUSTERIAD + " " + musteri.MUSTERISOYAD,
                                satis.FIYAT,
                                satis.TARIH
                            }).ToList();
                dataGridView1.DataSource = data;
            }


            //Combobox ürün ataması
            var ürünler = (from x in db.Tbl_urun
                           select new
                           {
                               x.URUNID,
                               x.URUNAD
                           }).ToList();
            Cmb_Ürün.ValueMember = "URUNID";
            Cmb_Ürün.DisplayMember = "URUNAD";
            Cmb_Ürün.DataSource = ürünler;
            Cmb_Ürün.SelectedIndex = -1;
            
        }

        private void listele()
        {
            using (var context = new DbEntityUrunEntities())
            {
                var data = (from satis in context.Tbl_satıs
                            join musteri in context.Tbl_musteriler
                            on satis.MUSTERI equals musteri.MUSTERIID
                            join urun in context.Tbl_urun
                            on satis.URUN equals urun.URUNID
                            select new
                            {
                                satis.SATISID,
                                URUN = urun.URUNAD,
                                MUSTERI = musteri.MUSTERIAD + " " + musteri.MUSTERISOYAD,
                                satis.FIYAT,
                                satis.TARIH
                            }).ToList();
                dataGridView1.DataSource = data;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Cmb_Ürün.SelectedValue != null && !string.IsNullOrEmpty(Txtmüsteri.Text) && !string.IsNullOrEmpty(Txtfiyat.Text))
            {
                try
                {
                    string[]musteriBilgisi = Txtmüsteri.Text.Split(' ');
                    string musteriAd = musteriBilgisi[0];
                    string musteriSoyad = musteriBilgisi.Length > 1 ? musteriBilgisi[1]: "";

                    var mevcutMusteri = db.Tbl_musteriler
                        .FirstOrDefault(m=>m.MUSTERIAD == musteriAd && m.MUSTERISOYAD==musteriSoyad);

                    int musteriID;
                    if (mevcutMusteri != null)
                    {
                        musteriID = mevcutMusteri.MUSTERIID;
                    }
                    else
                    {
                        var yeniMusteri = new Tbl_musteriler
                        {
                            MUSTERIAD = musteriAd,
                            MUSTERISOYAD = musteriSoyad,
                            SEHIR = "",
                            DURUM = true
                        };

                        db.Tbl_musteriler.Add(yeniMusteri);
                        db.SaveChanges();

                        musteriID = yeniMusteri.MUSTERIID;
                    }





                    Tbl_satıs yenisatis = new Tbl_satıs
                    {
                        URUN = Convert.ToInt32(Cmb_Ürün.SelectedValue),
                        MUSTERI = musteriID,
                        FIYAT = decimal.Parse(Txtfiyat.Text),
                        TARIH = DateTime.Parse(Msk_tarih.Text),
                    };
                    db.Tbl_satıs.Add(yenisatis);
                    db.SaveChanges();
                    MessageBox.Show("Satış başarı ile eklendi","Tebrikler! Satış işlemi gerçekleşti",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    listele();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
  
                }
            }

            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz", "Geçersiz işlem yaptınız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Satır seçilip seçilmediğini kontrol et
            if (e.RowIndex >= 0 && dataGridView1.CurrentRow != null)
            {
                // Seçili satırdaki verileri al
                Txtsatisid.Text = dataGridView1.CurrentRow.Cells["SATISID"].Value?.ToString();

                // Ürün adını Combobox'a seçili hale getir (ValueMember üzerinden çalışır)
                var urunAdi = dataGridView1.CurrentRow.Cells["URUN"].Value?.ToString();
                if (!string.IsNullOrEmpty(urunAdi))
                {
                    var urun = db.Tbl_urun.FirstOrDefault(u => u.URUNAD == urunAdi);
                    if (urun != null)
                    {
                        Cmb_Ürün.SelectedValue = urun.URUNID; // URUNID'yi Combobox'ta seçili yap
                    }
                }

                // Müşteri adı ve soyadını ilgili TextBox'a yerleştir
                Txtmüsteri.Text = dataGridView1.CurrentRow.Cells["MUSTERI"].Value?.ToString();

                // Fiyat ve Tarih alanlarını doldur
                Txtfiyat.Text = dataGridView1.CurrentRow.Cells["FIYAT"].Value?.ToString();
                Msk_tarih.Text = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["TARIH"].Value).ToShortDateString();
            }
        }

          

        private void button5_Click(object sender, EventArgs e)
        {
            Txtsatisid.Text = " ";
            Cmb_Ürün.SelectedValue = -1;
            Txtmüsteri.Text = " ";
            Txtfiyat.Text = "";
            Msk_tarih.Text = " ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if(dataGridView1.CurrentRow != null)
                {
                    int satisID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["SATISID"].Value);

                    var silineceksatis = db.Tbl_satıs.FirstOrDefault(s => s.SATISID == satisID);

                    if (silineceksatis != null)
                    {
                        db.Tbl_satıs.Remove(silineceksatis);
                        db.SaveChanges();

                        MessageBox.Show("Satış kaydı başarıyla silindi.", "Başarılı Silme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        listele();
                    }
                    else
                    {
                        MessageBox.Show("Silinecek kayıt bulunamadı");
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen silmek istediğiniz satışı seçiniz");
                }
               


            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                // Satır seçili mi kontrol et
                if (dataGridView1.CurrentRow != null)
                {
                    // Seçili satırdaki satış ID'sini al
                    int satisID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["SATISID"].Value);

                    // Satışı veritabanında bul
                    var satisToUpdate = db.Tbl_satıs.FirstOrDefault(s => s.SATISID == satisID);

                    if (satisToUpdate != null)
                    {
                        // Güncellenmiş bilgileri al
                        string[] musteriBilgisi = Txtmüsteri.Text.Split(' ');
                        string musteriAd = musteriBilgisi[0];
                        string musteriSoyad = musteriBilgisi.Length > 1 ? musteriBilgisi[1] : "";

                        var mevcutMusteri = db.Tbl_musteriler
                            .FirstOrDefault(m => m.MUSTERIAD == musteriAd && m.MUSTERISOYAD == musteriSoyad);

                        int musteriID;
                        if (mevcutMusteri != null)
                        {
                            musteriID = mevcutMusteri.MUSTERIID;
                        }
                        else
                        {
                            // Yeni müşteri oluşturuluyor, ancak burada müşteri eklemek gerekmiyor.
                            MessageBox.Show("Müşteri bulunamadı veya geçersiz müşteri adı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Güncelleme işlemi
                        satisToUpdate.URUN = Convert.ToInt32(Cmb_Ürün.SelectedValue);
                        satisToUpdate.MUSTERI = musteriID;
                        satisToUpdate.FIYAT = decimal.Parse(Txtfiyat.Text);
                        satisToUpdate.TARIH = DateTime.Parse(Msk_tarih.Text);

                        // Veritabanında güncelle
                        db.SaveChanges();

                        MessageBox.Show("Satış başarıyla güncellendi", "Güncelleme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Listeyi yenile
                        listele();
                    }
                    else
                    {
                        MessageBox.Show("Seçilen satış kaydı bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen güncellemek istediğiniz satışı seçiniz.", "Geçersiz işlem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme işlemi sırasında hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                


                iTextSharp.text.Font titleFont = FontFactory.GetFont("Arial", 18, iTextSharp.text.Font.BOLD);
                iTextSharp.text.Font normalFont = FontFactory.GetFont("Arial", 12);
                // 1. PDF için gerekli bilgileri alalım
                string musteriAdiSoyadi = Txtmüsteri.Text;
                string urunAdi = Cmb_Ürün.Text;
                string satisFiyati = Txtfiyat.Text;
                string tarih = Msk_tarih.Text;

               

                // 2. PDF belgesini oluşturacak dosya yolu
                // string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Fatura.pdf";
              string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
              string fileName = $"Fatura_{Guid.NewGuid()}.pdf"; // Benzersiz dosya adı
              string filePath = Path.Combine(desktopPath, fileName);



                // 3. PDF belgesi oluşturma
                Document pdfDoc = new Document(PageSize.A4);
                PdfWriter writer = PdfWriter.GetInstance(pdfDoc, new FileStream(filePath, FileMode.Create));
                writer.PageEvent = new FooterEvent(); // FooterEvent burada atanmalı
                pdfDoc.Open();

                // 4. PDF İçeriği (Yazılar, Veriler)
                titleFont = FontFactory.GetFont("Arial", 18, iTextSharp.text.Font.BOLD);
                 normalFont = FontFactory.GetFont("Arial", 12);

                string imagePath = "C:\\Users\\Samet\\Desktop\\BSK MarketPlace\\imageskase.png"; // Resim dosyasının yolu
                if (File.Exists(imagePath)) // Resim dosyasının var olup olmadığını kontrol et
                {
                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(imagePath);
                    img.SetAbsolutePosition(50, 50); // Sol alt köşe koordinatları (X:50, Y:50)
                    img.ScaleAbsolute(100,100); // Genişlik: 100, Yükseklik: 100 (isteğe göre ayarlayın)
                    pdfDoc.Add(img);
                }

                // Başlık
                // pdfDoc.Add(new Paragraph("SATIS FATURASI", titleFont));
                Paragraph title = new Paragraph("SATIS FATURASI", titleFont);
                title.Alignment = Element.ALIGN_CENTER;
                pdfDoc.Add(title);

                Paragraph space = new Paragraph("\n\n");
                pdfDoc.Add(space);



                // Müşteri Bilgisi

               
                Paragraph para1 = new Paragraph($"Müsteri Adı Soyadı: {musteriAdiSoyadi}", normalFont);
                para1.Alignment = Element.ALIGN_CENTER;
                pdfDoc.Add(para1);

                // Ürün
                Paragraph para2 = new Paragraph($"Ürün: {urunAdi}", normalFont);
                para2.Alignment = Element.ALIGN_CENTER;
                pdfDoc.Add(para2);

                // Satış Fiyatı
                Paragraph para3 = new Paragraph($"Satis Fiyatı: {satisFiyati} TL", normalFont);
                para3.Alignment = Element.ALIGN_CENTER;
                pdfDoc.Add(para3);

                // Tarih
                Paragraph para4 = new Paragraph($"Tarih: {tarih}", normalFont);
                para4.Alignment = Element.ALIGN_CENTER;
                pdfDoc.Add(para4);

                //PdfWriter writer = PdfWriter.GetInstance(pdfDoc, new FileStream(filePath, FileMode.Create));
                //writer.PageEvent = new FooterEvent();


                pdfDoc.Close();

                // 5. PDF Dosyasını Yazdır
                DialogResult result = MessageBox.Show("Fatura başarıyla oluşturuldu. Yazdırmak ister misiniz?",
                                                     "Fatura Yazdırma", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    ProcessStartInfo info = new ProcessStartInfo(filePath)
                    {
                        Verb = "print", // Yazdır komutunu çalıştır
                        CreateNoWindow = true,
                        UseShellExecute = true
                    };
                    Process.Start(info);
                }
                else
                {
                    MessageBox.Show($"PDF dosyanız masaüstüne kaydedildi: {filePath}", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
