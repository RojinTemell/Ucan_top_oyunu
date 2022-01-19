using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ucan_top_oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int Xekseni = 5, Yekseni = 5 ,can ;
        private void Calisma_olayi()
        {  
            if (button1.Top <= taban.Bottom )
            {
                Yekseni *= -1;
            }
            if(button1.Right >= sag_kolon.Left)
            {
                Xekseni *= -1;
            }
            if (button1.Left <=sol_kolon.Right)
            {
                Xekseni *= -1;
            }
            if (button1.Bottom >=button2.Top && button1.Left>=button2.Left && button1.Right<=button2.Right)
            {
                Yekseni *= -1;
            }

        }
        private void Topun_baslama_noktasi(object sender, EventArgs e)
        {
            button1.Location = new Point(416 ,  157 );
        }
        private void Yanma_olayi(object sender, EventArgs e)
        { //&& ve anlamına gelir 
            can = Convert.ToInt32(label1.Text);
            if (button1.Top >= sag_kolon.Bottom && can == 3)
            {
                button3.BackColor = Color.Red;
                can = can - 1;
                label1.Text = "2";
                timer1.Stop();
                Form1_Load(sender, e);
            }
            else if(button1.Top >= sag_kolon.Bottom && can == 2)
            {
                button4.BackColor = Color.Red;
                can = can - 1;
                label1.Text = "1";
                timer1.Stop();
                Form1_Load(sender, e);
            }
            else if (button1.Top >= sag_kolon.Bottom && can == 1)
            {
                button5.BackColor = Color.Red;
                can = can - 1;
                label1.Text = "0";
                timer1.Stop();
                MessageBox.Show("CANLARINIZ BİTTİ LÜTFEN YENİ OYUNA BAŞLAYINIZ.");
            }
           





        }       
      

        private void Form1_MouseMove(object sender, MouseEventArgs e )
        {
           
            button2.Left = e.X;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            Form1_Load(sender, e);
            button3.BackColor = Color.Green;
            button4.BackColor = Color.Green;
            button5.BackColor = Color.Green;
            label1.Text = "3";
        }

        private void Form1_Load(object sender, EventArgs e )
        {
            timer1.Enabled = true;
            Topun_baslama_noktasi(sender,e);
            
        }

        private void timer1_Tick(object sender, EventArgs e )
        {
            Calisma_olayi();
            Yanma_olayi(sender, e );
            button1.Location = new Point(button1.Location.X + Xekseni , button1.Location.Y +Yekseni );
             
        }

      
    }
}

