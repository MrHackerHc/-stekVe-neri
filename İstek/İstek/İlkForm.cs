using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// this.FormBorderStyle = FormBorderStyle.None; ** Bu kod Çıkış yerlerini Gizler.

namespace İstek
{
    public partial class İlkForm : Form
    {
        public İlkForm()
        {
            InitializeComponent();
        }
        
        private void İlkForm_Load(object sender, EventArgs e)
        {

        }

        private void Sk(object sender, EventArgs e)
        {
            // İstek Butonuna tıklandığı zaman çalışır.
            SecenekForm ana = new SecenekForm();
            ana.Show();
            this.Hide();
            //Bu ekranı kapıyor ve SecenekForm açıyor.
        }

        private void List(object sender, EventArgs e)
        {
            //List butonuna tıklandığı zaman çalışır.
            try
            {
                ListLogin lg = new ListLogin();
                lg.Show();
                this.Hide();
                //Bu ekranı kapar ve ListLogin formunu çalıştırır.
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Hata"+ex.Message);
                //Hata verirse Mesaj Kutusu olarak gelir ve hata mesajını gösterir
            }
        }
    }
}
