using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
   
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ClientProxyForm_P5_20190140098
{
    public partial class Form1 : Form
    {
        ServiceReference1.MatematikaClient obj = new ServiceReference1.MatematikaClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonHasil_Click(object sender, EventArgs e)
        {
            int angka1 = Convert.ToInt32(textBox1.Text);
            int angka2 = Convert.ToInt32(textBox2.Text);

            double labelPenjumlahan = obj.Tambah(angka1, angka2);
            double labelPengurangan = obj.Kurang(angka1, angka2);
            double labelPerkalian = obj.Kali(angka1, angka2);
            double labelPembagian = obj.Bagi(angka1, angka2);

            hasilpenjumlahan.Text = labelPenjumlahan.ToString();
            hasilpengurangan.Text = hasilkurang.ToString();
            hasilperkalian.Text = hasilkali.ToString();
            hasilpembagian.Text = hasilbagi.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
