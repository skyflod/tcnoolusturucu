using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCNO_Oluşturucu
{
    public partial class Form1 : Form
    {
        int b1, b2, b3, b4, b5, b6, b7, b8, b9, b10, b11;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random bsmk = new Random();
           
            b1 = bsmk.Next(1,10);
            b2 = bsmk.Next(0,10);
            b3 = bsmk.Next(0,10);
            b4 = bsmk.Next(0,10);
            b5 = bsmk.Next(0,10);
            b6 = bsmk.Next(0,10);
            b7 = bsmk.Next(0,10);
            b8 = bsmk.Next(0,10);
            b9 = bsmk.Next(0,10);
            b10 = (((b1 + b3 + b5 + b7 + b9) * 7) - (b2 + b4 + b6 + b8)) % 10;
            b11 = (b1 + b2 + b3 + b4 + b5 + b6 + b7 + b8 + b9 + b10) % 10;

            textBox1.Text = b1.ToString() + b2.ToString() + b3.ToString() + b4.ToString() + b5.ToString() +b6.ToString() + b7.ToString() + b8.ToString() + b9.ToString() + b10.ToString() + b11.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int kural1;
            int kural2;
            
            kural1 = ((b1 + b3 + b5 + b7 + b9) * 7) - (b2 + b4 + b6 + b8);
            kural2 = b1 + b2 + b3 + b4 + b5 + b6 + b7 + b8 + b9 + b10;
            
            if (kural1 % 10 == b10)
            {
                if (kural2 % 10 == b11)
                {
                    if (b1 == 0)
                    {
                        label1.Text = "Kontrol Sonucu : Hatalı ";
                    }
                    else
                    {
                       if (b11 % 2 == 1)
                       {
                           label1.Text = "Kontrol Sonucu : Hatalı ";
                       }
                       else
                       {
                           label1.Text = "Kontrol Sonucu : Doğru ";
                       }
                    }
                }
                else
                {
                    label1.Text = "Kontrol Sonucu : Hatalı ";
                }

            }
            else
            {
                label1.Text = "Kontrol Sonucu : Hatalı ";
            }
        }
    }
}
