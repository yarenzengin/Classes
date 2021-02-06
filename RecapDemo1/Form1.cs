using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //nesneye erişim sıkıntılı
            //aynı işlemden farklı nesneler oluşturup onları kontrol altında tutmak istiyorsanız Array yapmak lazım 
            Button[,] buttons = new Button[9,9];
            int top = 0;
            int left = 0;
            for (int i = 0; i < buttons.GetUpperBound(0); i++)//0.boyutun alabilceği en yüksek değer

            {
                for (int j = 0; j < buttons.GetUpperBound(1); j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    buttons[i, j].Left = left;//formun uzaklığı 
                    buttons[i, j].Top = top;
                    left += 50;//2.butonda çalışmak için
                    if ((i + j) %2 == 0)
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.White;
                    }


                    //button.Text = "My Button";
                    this.Controls.Add(buttons[i,j]);//this forma karşılık gelir
                }
              
                top += 50;
                left = 0;//2.satıra geçtik
             
            }
            
           
        }
    }
}
