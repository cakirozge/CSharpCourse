using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
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
            //for (int i = 1; i <= 64; i++)
            //{
            //    Button button = new Button();
            //    button.Width = 50;
            //    button.Height = 50;
            //    button.Text = "My Button";
            //    this.Controls.Add(button);
            //}

            GenerateButtons();


        }

        private void GenerateButtons()
        {
            Button[,] buttons = new Button[8, 8];

            int top = 0;
            int left = 0;

            for (int i = 0; i < buttons.GetUpperBound(0); i++)
            {
                for (int j = 0; j < buttons.GetUpperBound(1); j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;

                    buttons[i, j].Left = left; // 2. satır bittiğinde sola gecmesi icin yapılır.
                    buttons[i, j].Top = top; // aşağı doğru yukardan ilerletmek için tanımlandı.
                    left += 50;

                    if ((i + j) % 2 == 0)
                    {
                        buttons[i, j].BackColor = Color.DarkOrange;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.White;
                    }
                    this.Controls.Add(buttons[i, j]);
                }
                left = 0; // satır tamamlamak için
                top += 50; // her satır degıstıgınde yukarıdan uzaklıgı belirlemek icin verildi.
            }

            //button.Width = 50;
            //button.Height = 50;
            //button.Text = "My Button";
            //this.Controls.Add(buttons);
        }
    }
}
