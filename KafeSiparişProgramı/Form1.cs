using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using Newtonsoft.Json;

namespace KafeSiparişProgramı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        IFirebaseConfig fc = new FirebaseConfig()
        {
            AuthSecret = "d472QwT9xIpo2Jd5zdEVLCpw5M6DvgDPtOLO47cw",
            BasePath = "https://console.firebase.google.com/u/0/project/kafesiparisprogrami2/database/kafesiparisprogrami2-default-rtdb/data/~2F"
        };
        IFirebaseClient client;
       
        /*
        private void cayarti_btn_Click(object sender, EventArgs e)
        {
            int caysayisi = Convert.ToInt32(caysayisi_label.Text);
            caysayisi++;
            caysayisi_label.Text = Convert.ToString(caysayisi);
        }

        private void kahvearti_btn_Click(object sender, EventArgs e)
        {
            int kahvesayisi = Convert.ToInt32(kahvesayisi_label.Text);
              kahvesayisi++;
            kahvesayisi_label.Text = Convert.ToString(kahvesayisi);
        }

        private void kolaarti_btn_Click(object sender, EventArgs e)
        {
            int kolasayisi = Convert.ToInt32(kolasayisi_label.Text);
            kolasayisi++;
            kolasayisi_label.Text = Convert.ToString(kolasayisi);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cayeksi_btn_Click(object sender, EventArgs e)
        {
            int caysayisi = Convert.ToInt32(caysayisi_label.Text);
            if (caysayisi > 0)
            {
                caysayisi--;
                caysayisi_label.Text = Convert.ToString(caysayisi);
            }
        }

        private void kahveeksi_btn_Click(object sender, EventArgs e)
        {
            int kahvesayisi = Convert.ToInt32(kahvesayisi_label.Text);
            if (kahvesayisi > 0)
            {
                kahvesayisi--;
                kahvesayisi_label.Text = Convert.ToString(kahvesayisi);
            }
        }

        private void kolaeksi_btn_Click(object sender, EventArgs e)
        {
            int kolasayisi = Convert.ToInt32(kolasayisi_label.Text);
            if (kolasayisi > 0)
            {
                kolasayisi--;
                kolasayisi_label.Text = Convert.ToString(kolasayisi);
            }
        }

        private void sıfırla_btn_Click(object sender, EventArgs e)
        {
            caysayisi_label.Text="0";
            kolasayisi_label.Text = "0";
            kahvesayisi_label.Text = "0";
        }

        private void siparişitamamla_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sipariş Özeti:"+" "+ caysayisi_label.Text +" "+ "Çay" +" "+ kahvesayisi_label.Text +" "+ "Kahve" +" "+ kolasayisi_label.Text +" "+ "Kola");
        }*/

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(fc);
            }
            catch (Exception)
            {
                MessageBox.Show("Veri Tabanına Bağlantı Hatası");
         
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sipariscls siparis = new sipariscls()
            {
            miktar = textBox2.Text,
            icecek=textBox3.Text
            };
            var setet = client.Set("siparistbl/"+textBox2.Text,siparis);
            MessageBox.Show("siparisler eklendi");
        }
    }
}
