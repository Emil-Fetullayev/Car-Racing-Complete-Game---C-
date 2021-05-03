using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp34
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            over.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveline(gamespeed);
            enemy(gamespeed);
            gameover();
            coins(gamespeed);
            coinscollection();
        }

        int collectedcoin = 0;

        Random r = new Random();
        int x, y;
        void enemy(int speed)
        {
            if (enemy1.Top >= 500)
            {
                x = r.Next(0, 200);
             
                enemy1.Location = new Point(x,0);
            }
            else
            {
                enemy1.Top += speed;
            }


            if (enemy2.Top >= 500)
            {
                x = r.Next(0, 320);

                enemy2.Location = new Point(x,0);
            }
            else
            {
                enemy2.Top += speed;
            }


            if (enemy3.Top >= 500)
            {
                x = r.Next(200, 230);

                enemy3.Location = new Point(x, 0);
            }
            else
            {
                enemy3.Top += speed;
            }

        }



        void coins(int speed)
        {
            if (coln1.Top >= 500)
            {
                x = r.Next(0, 200);

                coln1.Location = new Point(x, 0);
            }
            else
            {
                coln1.Top += speed;
            }

            if (coln2.Top >= 500)
            {
                x = r.Next(0, 200);

                coln2.Location = new Point(x, 0);
            }
            else
            {
                coln2.Top += speed;
            }

            if (coln3.Top >= 500)
            {
                x = r.Next(50, 300);

                coln3.Location = new Point(x, 0);
            }
            else
            {
                coln3.Top += speed;
            }

            if (coln4.Top >= 500)
            {
                x = r.Next(0, 400);

                coln4.Location = new Point(x, 0);
            }
            else
            {
                coln4.Top += speed;
            }

        }

        void gameover()
        {
            if (Car.Bounds.IntersectsWith(enemy1.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
            }
            if (Car.Bounds.IntersectsWith(enemy2.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
            }
            if (Car.Bounds.IntersectsWith(enemy3.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
            }

        }






        void moveline(int speed)
        {
            if (pictureBox1.Top >= 500)
            {
                pictureBox1.Top= 0;
            }
            else
            {
                pictureBox1.Top += speed;
            }

            if(pictureBox2.Top>= 500)
            {
                pictureBox2.Top = 0;
            }
            else
            {
                pictureBox2.Top += speed;
            }


            if(pictureBox3.Top >=500)
            {
                pictureBox3.Top = 0;
            }
            else
            {
                pictureBox3.Top += speed;
            }

            if(pictureBox4.Top >= 500)
            {
                pictureBox4.Top = 0;
            }
            else
            {
                pictureBox4.Top += speed;
            }




        
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        void coinscollection()
        {
            if (Car.Bounds.IntersectsWith(coln1.Bounds))
            {
                collectedcoin++;
                label1.Text = "Coins=" + collectedcoin.ToString();
                x = r.Next(50, 300);

                coln1.Location = new Point(x, 0);
            }
            if (Car.Bounds.IntersectsWith(coln2.Bounds))
            {
                collectedcoin++;
                label1.Text = "Coins=" + collectedcoin.ToString();

                x = r.Next(50, 300);

                coln2.Location = new Point(x, 0);
            }
            if (Car.Bounds.IntersectsWith(coln3.Bounds))
            {
                collectedcoin++;
                label1.Text = "Coins=" + collectedcoin.ToString();

                x = r.Next(50, 300);

                coln3.Location = new Point(x, 0);
            }
            if (Car.Bounds.IntersectsWith(coln4.Bounds))
            {
                collectedcoin++;
                label1.Text = "Coins=" + collectedcoin.ToString();

                x = r.Next(50, 300);

                coln4.Location = new Point(x, 0);
            }
        }


        int gamespeed = 0;

        private void over_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                if(Car.Left>0)
                Car.Left += -8;
            }
            if(e.KeyCode == Keys.Right)
            {
                if(Car.Right<280)
                Car.Left += 8;
            }

            if(e.KeyCode == Keys.Up)
            {
                if(gamespeed <21)
                {
                    gamespeed++;
                }
            
            }
            if (e.KeyCode == Keys.Down)
            {
                if (gamespeed > 0)
                {
                    gamespeed--;
                }
            }
        }
    }
}
