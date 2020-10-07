using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoughtsAndCrosses
{

    public partial class Form1 : Form
    {
        //grid values for each player 
        bool a1p1 = false;
        bool a1p2 = false;
        bool a1p3 = false;
        bool a1p4 = false;
        bool a1p5 = false;
        bool a1p6 = false;
        bool a1p7 = false;
        bool a1p8 = false;
        bool a1p9 = false;
        bool a2p1 = false;
        bool a2p2 = false;
        bool a2p3 = false;
        bool a2p4 = false;
        bool a2p5 = false;
        bool a2p6 = false;
        bool a2p7 = false;
        bool a2p8 = false;
        bool a2p9 = false;

        //buttoncheck values
        bool but1pressed = false;
        bool but2pressed = false;
        bool but3pressed = false;
        bool but4pressed = false;
        bool but5pressed = false;
        bool but6pressed = false;
        bool but7pressed = false;
        bool but8pressed = false;
        bool but9pressed = false;

        //keeps track of player, f=x, t=o
        bool playerbool = false;
 



        public Form1()
        {
            InitializeComponent();
        }

        void WinCheck() 
        {
            if (a1p1 == true && a1p2 == true && a1p3 == true) 
            {
                MessageBox.Show("player 1 wins!");
            }
            else if (a1p4 == true && a1p5 == true && a1p6 == true)
            {
                MessageBox.Show("player 2 wins!");
            }
            else if (a1p7 == true && a1p8 == true && a1p9 == true)
            {
                MessageBox.Show("player 2 wins!");
            }
            else if (a1p1 == true && a1p4 == true && a1p7 == true)
            {
                MessageBox.Show("player 2 wins!");
            }
            else if (a1p1 == true && a1p5 == true && a1p8 == true)
            {
                MessageBox.Show("player 2 wins!");
            }
            else if (a1p3 == true && a1p6 == true && a1p9 == true)
            {
                MessageBox.Show("player 2 wins!");
            }
            else if (a1p1 == true && a1p5 == true && a1p9 == true)
            {
                MessageBox.Show("player 2 wins!");
            }
            else if (a1p3 == true && a1p5 == true && a1p7 == true)
            {
                MessageBox.Show("player 2 wins!");
            }
            else if (a2p1 == true && a2p2 == true && a2p3 == true)
            {
                MessageBox.Show("player 1 wins!");
            }
            else if (a2p4 == true && a2p5 == true && a2p6 == true)
            {
                MessageBox.Show("player 1 wins!");
            }
            else if (a2p7 == true && a2p8 == true && a2p9 == true)
            {
                MessageBox.Show("player 1 wins!");
            }
            else if (a2p1 == true && a2p4 == true && a2p7 == true)
            {
                MessageBox.Show("player 1 wins!");
            }
            else if (a2p2 == true && a2p5 == true && a2p8 == true)
            {
                MessageBox.Show("player 1 wins!");
            }
            else if (a2p3 == true && a2p6 == true && a2p9 == true)
            {
                MessageBox.Show("player 1 wins!");
            }
            else if (a2p1 == true && a2p5 == true && a2p9 == true)
            {
                MessageBox.Show("player 1 wins!");
            }
            else if (a2p3 == true && a2p5 == true && a2p7 == true)
            {
                MessageBox.Show("player 1 wins!");
            }



        }

        private void a1_Click(object sender, EventArgs e)
        {
            if (but1pressed == false)
            {
                but1pressed = true;
                if (playerbool == true)
                {
                    //place an o
                    a1.Text = ("O");
                    playerbool = false;
                    a1p1 = true;        
                    WinCheck();
                }
                else if (playerbool == false)
                {
                    //place an x
                    a1.Text = ("X");
                    playerbool = true;
                    a2p1 = true;
                    WinCheck();
                }
            }            
        }

        private void a2_Click(object sender, EventArgs e)
        {
            if (but2pressed == false)
            {
                but2pressed = true;
                if (playerbool == true)
                {
                    //place an o
                    a2.Text = ("O");
                    playerbool = false;
                    a1p2 = true;
                    WinCheck();
                }
                else if (playerbool == false)
                {
                    //place an x
                    a2.Text = ("X");
                    playerbool = true;
                    a2p2 = true;
                    WinCheck();
                }
            }
        }

        private void a3_Click(object sender, EventArgs e)
        {
            if (but3pressed == false)
            {
                but3pressed = true;
                if (playerbool == true)
                {
                    //place an o
                    a3.Text = ("O");
                    playerbool = false;
                    a1p3 = true;
                    WinCheck();
                }
                else if (playerbool == false)
                {
                    //place an x
                    a3.Text = ("X");
                    playerbool = true;
                    a2p3 = true;
                    WinCheck();
                }
            }
        }

        private void b1_Click(object sender, EventArgs e)
        {
            if (but4pressed == false)
            {
                but4pressed = true;
                if (playerbool == true)
                {
                    //place an o
                    b1.Text = ("O");
                    playerbool = false;
                    a1p4 = true;
                    WinCheck();
                }
                else if (playerbool == false)
                {
                    //place an x
                    b1.Text = ("X");
                    playerbool = true;
                    a2p4 = true;
                    WinCheck();
                }
            }
        }

        private void b2_Click(object sender, EventArgs e)
        {
            if (but5pressed == false)
            {
                but5pressed = true;
                if (playerbool == true)
                {
                    //place an o
                    b2.Text = ("O");
                    playerbool = false;
                    a1p5 = true;
                    WinCheck();
                }
                else if (playerbool == false)
                {
                    //place an x
                    b2.Text = ("X");
                    playerbool = true;
                    a2p5 = true;
                    WinCheck();
                }
            }
        }

        private void b3_Click(object sender, EventArgs e)
        {
            if (but6pressed == false)
            {
                but6pressed = true;
                if (playerbool == true)
                {
                    //place an o
                    b3.Text = ("O");
                    playerbool = false;
                    a1p6 = true;
                    WinCheck();
                }
                else if (playerbool == false)
                {
                    //place an x
                    b3.Text = ("X");
                    playerbool = true;
                    a2p6 = true;
                    WinCheck();
                }
            }
        }

        private void c1_Click(object sender, EventArgs e)
        {
            if (but7pressed == false)
            {
                but7pressed = true;
                if (playerbool == true)
                {
                    //place an o
                    c1.Text = ("O");
                    playerbool = false;
                    a1p7 = true;
                    WinCheck();
                }
                else if (playerbool == false)
                {
                    //place an x
                    c1.Text = ("X");
                    playerbool = true;
                    a2p7 = true;
                    WinCheck();
                }
            }
        }

        private void c2_Click(object sender, EventArgs e)
        {
            if (but8pressed == false)
            {
                but8pressed = true;
                if (playerbool == true)
                {
                    //place an o
                    c2.Text = ("O");
                    playerbool = false;
                    a1p8 = true;
                    WinCheck();
                }
                else if (playerbool == false)
                {
                    //place an x
                    c2.Text = ("X");
                    playerbool = true;
                    a2p8 = true;
                    WinCheck();
                }
            }
        }

        private void c3_Click(object sender, EventArgs e)
        {
            if (but9pressed == false)
            {
                but9pressed = true;
                if (playerbool == true)
                {
                    //place an o
                    c3.Text = ("O");
                    playerbool = false;
                    a1p9 = true;
                    WinCheck();
                }
                else if (playerbool == false)
                {
                    //place an x
                    c3.Text = ("X");
                    playerbool = true;
                    a2p9 = true;
                    WinCheck();
                }
            }
        }

        private void BTNreset_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
