using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgiYarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruno, dogru, yanlis;

        private void BtnSonraki_Click(object sender, EventArgs e)
        {
            soruno++;
            LblSoruNo.Text = soruno.ToString();
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            BtnSonraki.Enabled = false;
            BtnA.Enabled = true;
            BtnB.Enabled = true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;


            if (soruno == 1)
            {
                richTextBox1.Text = "Cumhuriyet kaç yılında ilan edilmiştir?";
                BtnA.Text = "1920";
                BtnB.Text = "1921";
                BtnC.Text = "1922";
                BtnD.Text = "1923";
                label4.Text = "1923"; //Label4 doğru cevabımızı tutacak ve program çalıştığında gözükmeyecek. Visible=false oldugu için.
            }

            if (soruno == 2)
            {
                richTextBox1.Text = "Aşağıdakilerden hangisi Ege Bölgemizde bulunmaz?";
                BtnA.Text = "İzmir";
                BtnB.Text = "Balıkesir";
                BtnC.Text = "Artvin";
                BtnD.Text = "Çanakkale";
                label4.Text = "Artvin"; //Label4 doğru cevabımızı tutacak ve program çalıştığında gözükmeyecek. Visible=false oldugu için.
            }

            if (soruno == 3)
            {
                richTextBox1.Text = "Son Kuşlar adlı kitabın yazarı kimdir?";
                BtnA.Text = "Sait Faik";
                BtnB.Text = "Cemal Süreya";
                BtnC.Text = "Atilla İlhan";
                BtnD.Text = "Reşat Nuri";
                label4.Text = "Sait Faik"; //Label4 doğru cevabımızı tutacak ve program çalıştığında gözükmeyecek. Visible=false oldugu için.
                BtnSonraki.Text = "SONUÇLAR";
            }

            if (soruno == 4)
            {
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
                BtnSonraki.Enabled = false;
                MessageBox.Show("Doğru: " + dogru + " \n" + "Yanlis: " + yanlis);
            }

        }

        private void BtnA_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;
            label5.Text = BtnA.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true; //yeşil ışık yanacak.

            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true; //kırmızı ışık yanacak.
                BtnA.Enabled = false;
            }
        }

        private void BtnB_Click(object sender, EventArgs e)
        {

            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            label5.Text = BtnB.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true; //yeşil ışık yanacak.
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true; //kırmızı ışık yanacak.
                BtnA.Enabled = false;
            }
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;

            BtnSonraki.Enabled = true;
            label5.Text = BtnC.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true; //yeşil ışık yanacak.

            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true; //kırmızı ışık yanacak.
                BtnA.Enabled = false;
            }
        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;
            label5.Text = BtnD.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true; //yeşil ışık yanacak.

            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true; //kırmızı ışık yanacak.
                BtnA.Enabled = false;
            }
        }

    }

}





