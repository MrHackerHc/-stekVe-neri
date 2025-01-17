using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İstek
{
    public partial class list : Form
    {
        public list()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            //Geri butona tıklanınca çalışır.
            İlkForm ilk = new İlkForm();
            ilk.Show();
            this.Close();
            //Bu dosya kapanır İlkForm kapanır.
        }

        private void list_Load(object sender, EventArgs e)
        {

        }
        public string txtOkuyucu = File.ReadAllText("C:\\Users\\mrcod\\source\\repos\\İstek\\İstek\\deneme.txt");
        //Txt dosyasını tanımlıyoruz.
        private void veriload(object sender, EventArgs e)
        {
            //Verileri Yükle butonuna tıklanınca çalışır.
            veris.Clear();
            //RichTextBox'ta bulunan verileri siliyoruz.
            veris.Text = txtOkuyucu;
            //Tekrar RichTextBox'a veri kayıt ediyoruz.
        }

        private void veri_TextChanged_1(object sender, EventArgs e)
        {

        }
        public int list_Id;
        //ÖneriForm,ŞikayetForm da yazılan yazılara atanan Id.
        private void sil(object sender,EventArgs e)
        {
           string[] txtOkuyuc = File.ReadAllLines("C:\\Users\\mrcod\\source\\repos\\İstek\\İstek\\deneme.txt");
            //Txt dosyasını liste haline getiriyoruz.
            string silId = IdDelete.Text;
            //Silencek Id yerinde Text yerine yazılan Id kayıt ediliyor.
            string[] IDbul = txtOkuyuc
            //IDbul'u liste olarak kayıt ediyoruz ve Txt dosyasına onu tanımlıyoruz.
                .Where(satir => !satir.StartsWith(silId))
                //silId'yi bütün satırlarda kontrol eder başı silId ile başlamayanları alır 
                .ToArray();
            if (txtOkuyuc.Length == IDbul.Length)
            {
                //txt dosyasının satır sayısını kontrol eder eğer IDbul'a eşitse çalışıyor.
                MessageBox.Show($"ID {silId} bulunamadı.");
            }
            else if (silId != "")
            {
                File.WriteAllLines("C:\\Users\\mrcod\\source\\repos\\İstek\\İstek\\deneme.txt", IDbul);

                veris.Clear();
                //RichTextBox'ta bulunan verileri siler.

                veris.Text = string.Join(Environment.NewLine, IDbul);

                IdDelete.Clear();
                //IdDelete Kısmını siliyor.
            }
            else
            {
                MessageBox.Show("Silinecek ID kısmını doldurunuz.");
            }

        }

        private void IdDelete_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void IdSilText(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Enter'ın varsayılan davranışını engelle
                string[] txtOkuyuc = File.ReadAllLines("C:\\Users\\mrcod\\source\\repos\\İstek\\İstek\\deneme.txt");
                //Txt dosyasını liste haline getiriyoruz.
                string silId = IdDelete.Text;
                //Silencek Id yerinde Text yerine yazılan Id kayıt ediliyor.
                string[] IDbul = txtOkuyuc
                    //IDbul'u liste olarak kayıt ediyoruz ve Txt dosyasına onu tanımlıyoruz.
                    .Where(satir => !satir.StartsWith(silId))
                    //silId'yi bütün satırlarda kontrol eder başı silId ile başlamayanları alır 
                    .ToArray();
                if (txtOkuyuc.Length == IDbul.Length)
                {
                    //txt dosyasının satır sayısını kontrol eder eğer IDbul'a eşitse çalışıyor.
                    MessageBox.Show($"ID {silId} bulunamadı.");
                }
                else if (silId != "")
                {
                    File.WriteAllLines("C:\\Users\\mrcod\\source\\repos\\İstek\\İstek\\deneme.txt", IDbul);

                    veris.Clear();
                    //RichTextBox'ta bulunan verileri siler.

                    veris.Text = string.Join(Environment.NewLine, IDbul);

                    IdDelete.Clear();
                    //IdDelete Kısmını siliyor.
                }
                else
                {
                    MessageBox.Show("Silinecek ID kısmını doldurunuz.");
                }
            }
        }
    }
}
