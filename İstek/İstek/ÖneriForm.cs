using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İstek
{
    public partial class ÖneriForm : Form
    {
        public ÖneriForm()
        {
            InitializeComponent();
        }
        private void ÖneriForm_Load(object sender, EventArgs e)
        {

        }

        private void textÖneri(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SecenekForm sec = new SecenekForm();
            sec.Show();
            this.Close();
        }

        private void gönder(object sender, EventArgs e)
        {
            string denemelocal = "C:\\Users\\mrcod\\source\\repos\\İstek\\İstek\\deneme.txt";

            string Zaman = DateTime.Now.ToString("dd MMMM yyyy , HH:mm:ss");

            Random st = new Random();
            int Id = st.Next(1, 1000);

            list lst = new list();
            lst.list_Id = Id;

            try
            {
                string öneri = txtÖneri.Text;

                File.AppendAllText(denemelocal, $"{Id}. Öneri: {öneri} - {Zaman}{Environment.NewLine}");
                MessageBox.Show("Öneri gönderildi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu" + ex.Message);
            }

        }


        private void txtÖneri_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OneriKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Enter'ın varsayılan davranışını engelle
                string denemelocal = "C:\\Users\\mrcod\\source\\repos\\İstek\\İstek\\deneme.txt";

                string Zaman = DateTime.Now.ToString("dd MMMM yyyy , HH:mm:ss");

                Random st = new Random();
                int Id = st.Next(1, 1000);

                list lst = new list();
                lst.list_Id = Id;

                try
                {
                    string öneri = txtÖneri.Text;

                    File.AppendAllText(denemelocal, $"{Id}. Öneri: {öneri} - {Zaman}{Environment.NewLine}");
                    MessageBox.Show("Öneri gönderildi.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata Oluştu" + ex.Message);
                }
            }
        }
    }
}
