using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesapmakinesi
{
    public partial class Form1 : Form
    {
        char _islem;
        bool _ekranTemizlenecekMi;
        float _ilksayi;
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {


            if (_ekranTemizlenecekMi)
            {
                ekranlabel.Text = " ";
                _ekranTemizlenecekMi = false;
            }
            if (ekranlabel.Text == "0")
                ekranlabel.Text = " ";
            ekranlabel.Text += "8";
        }

        private void sayi1_Click(object sender, EventArgs e)
        {

            if (_ekranTemizlenecekMi)
            {
                ekranlabel.Text = " ";
                _ekranTemizlenecekMi = false;
            }
            if (ekranlabel.Text == "0") 
                ekranlabel.Text = " ";
               ekranlabel.Text += "1";
        }

        private void sayi2_Click(object sender, EventArgs e)
        {

            if (_ekranTemizlenecekMi)
            {
                ekranlabel.Text = " ";
                _ekranTemizlenecekMi = false;
            }
            if (ekranlabel.Text == "0")
                ekranlabel.Text = " ";
            ekranlabel.Text += "2";
        }

        private void sayi3_Click(object sender, EventArgs e)
        {

            if (_ekranTemizlenecekMi)
            {
                ekranlabel.Text = " ";
                _ekranTemizlenecekMi = false;
            }
            if (ekranlabel.Text == "0")
                ekranlabel.Text = " ";
            ekranlabel.Text += "3";
        }

        private void sayi4_Click(object sender, EventArgs e)
        {

            if (_ekranTemizlenecekMi)
            {
                ekranlabel.Text = " ";
                _ekranTemizlenecekMi = false;
            }
            if (ekranlabel.Text == "0")
                ekranlabel.Text = " ";
            ekranlabel.Text += "4";
        }

        private void sayi5_Click(object sender, EventArgs e)
        {

            if (_ekranTemizlenecekMi)
            {
                ekranlabel.Text = " ";
                _ekranTemizlenecekMi = false;
            }
            if (ekranlabel.Text == "0")
                ekranlabel.Text = " ";
            ekranlabel.Text += "5";

        }

        private void sayi6_Click(object sender, EventArgs e)
        {

            if (_ekranTemizlenecekMi)
            {
                ekranlabel.Text = " ";
                _ekranTemizlenecekMi = false;
            }
            if (ekranlabel.Text == "0")
                ekranlabel.Text = " ";
            ekranlabel.Text += "6";
        }

        private void sayi7_Click(object sender, EventArgs e)
        {

            if (_ekranTemizlenecekMi)
            {
                ekranlabel.Text = " ";
                _ekranTemizlenecekMi = false;
            }
            if (ekranlabel.Text == "0")
                ekranlabel.Text = " ";
            ekranlabel.Text += "7";
        }

        private void sayi9_Click(object sender, EventArgs e)
        {

            if (_ekranTemizlenecekMi)
            {
                ekranlabel.Text = " ";
                _ekranTemizlenecekMi = false;
            }
            if (ekranlabel.Text == "0")
                ekranlabel.Text = " ";
            ekranlabel.Text += "9";
        }

        private void sayi0_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranlabel.Text = " ";
                _ekranTemizlenecekMi = false;
            }
            if (ekranlabel.Text == "0")
                ekranlabel.Text = " ";
            ekranlabel.Text += "0";
        }

        private void arti_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekranTemizlenecekMi = true;
            _ilksayi = Convert.ToInt32(ekranlabel.Text);
        }

        private void esit_Click(object sender, EventArgs e)
        {
            float ikincisayi = Convert.ToInt32(ekranlabel.Text);
           float sonuc;
            switch(_islem)
            {
                case '+' :
                    sonuc = _ilksayi + ikincisayi;
                    break;
                case '-':
                    sonuc = _ilksayi - ikincisayi;
                    break;

                case '*':
                    sonuc = _ilksayi * ikincisayi;
                    break;

                case '/':
                    sonuc = _ilksayi / ikincisayi;
                    break;

                default:
                    sonuc = 0;
                    break;




            }

            ekranlabel.Text = Convert.ToString(sonuc);

           

        }

        private void eksi_Click(object sender, EventArgs e)
        {
            {
                _islem = '-';
                _ekranTemizlenecekMi = true;
                _ilksayi = Convert.ToInt32(ekranlabel.Text);
            }
        }

        private void carpim_Click(object sender, EventArgs e)
        {
            {
                _islem = '*';
                _ekranTemizlenecekMi = true;
                _ilksayi = Convert.ToInt32(ekranlabel.Text);
            }
        }

        private void bölme_Click(object sender, EventArgs e)
        {
            {
                _islem = '/';
                _ekranTemizlenecekMi = true;
                _ilksayi = Convert.ToInt32(ekranlabel.Text);
            }
        }

        private void siltus_Click(object sender, EventArgs e)
        {
            ekranlabel.Text = "0";
        }
    }
}
