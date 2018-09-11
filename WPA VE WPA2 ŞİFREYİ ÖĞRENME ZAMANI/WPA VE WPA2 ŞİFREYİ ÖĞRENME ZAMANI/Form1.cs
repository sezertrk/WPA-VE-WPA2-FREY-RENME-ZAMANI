using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WPA_VE_WPA2_ŞİFREYİ_ÖĞRENME_ZAMANI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "HD 6990": { textBox1.Text = "100000"; break; }
                case "HD 6850": { textBox1.Text = "32769"; break; }
                case "GTX 590": { textBox1.Text = "50787"; break; }
                case "GTX 460": { textBox1.Text = "18105"; break; }
                
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox3.Text = (int.Parse(textBox1.Text) * int.Parse(textBox2.Text)).ToString();
            }
            catch (Exception)
            {

                textBox3.Text = "1";
            }
               
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double parola = Double.Parse(textBox3.Text);
            Double karakter = Double.Parse(textBox5.Text);
            Double karakteruz = Double.Parse(textBox6.Text);
            Double yil;
            Double ay;
            Double gun;
            Double toparola=1;  
            for (int i = 0; i < karakteruz ; i++)
            {
                toparola = toparola * karakteruz;   
            }
            yil = parola * 86400 * 365;
            
            Double saniye = 0;
            Double snislem = 0;
            snislem = parola * karakter;
            //saniye = toparola / parola;
            saniye = toparola / yil;
            
            
            textBox4.Text = saniye.ToString();
            
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.Text)
            {
                case "Sayılar": { textBox5.Text = "10"; break; }
                case "Kucuk Harf + Sayılar": { textBox5.Text = "36"; break; }
                case "Buyuk Harf + Sayılar": { textBox5.Text = "36"; break; }
                case "Kucuk Harf + Buyuk Harf + Sayılar": { textBox5.Text = "62"; break; }

            }
        }
    }
}
