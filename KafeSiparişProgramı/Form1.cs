﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KafeSiparişProgramı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

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
    }
}
