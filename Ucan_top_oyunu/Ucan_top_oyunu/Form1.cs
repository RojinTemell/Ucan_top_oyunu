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
        int Xekseni = 3, Yekseni = 3 ,can ;
        private void Calisma_olayi()
        {  
            if (button1.Top <= taban.Bottom)
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
        {
           
          
     
        }       
      

        private void Form1_MouseMove(object sender, MouseEventArgs e )
        {
           
            button2.Left = e.X;

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

