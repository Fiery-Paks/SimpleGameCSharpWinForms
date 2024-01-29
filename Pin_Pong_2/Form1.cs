using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pin_Pong_2
{
    public partial class Form1 : Form
    {
        Graphics graphics;
        Timer timer = new Timer();

        int FPS = MainForm.S_B;
        int player1y;
        int player2y;

        int ballx;
        int bally;
        int ballspdx = 3;
        int ballspdy = 3;

        int end = 761;
        int ps = MainForm.S_P;
        bool game = true;
        int pause1 = 0;
        int pause2 = 0;
        int p;
        bool infopause = false;

        public Form1()
        {
            InitializeComponent();

            timer.Enabled = true;
            timer.Interval = 500 / FPS;
            timer.Tick += new EventHandler(TimerCallback);

            ballx = this.Width / 2 - 10;
            bally = this.Height / 2 - 10;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            labelP1.Visible = false;
            labelP2.Visible = false;
            Lab_GW.Visible = false;
            Lab_PW.Visible = false;
            if (MainForm.WG >0 || MainForm.WP > 0)
            {
                Lab_GW.Visible = true;
                Lab_PW.Visible = true;
                Lab_GW.Text = MainForm.WG.ToString();
                Lab_PW.Text = MainForm.WP.ToString();
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            graphics = CreateGraphics();
            DrawRectangle(0, player1y, 20, 130, new SolidBrush(Color.Green));
            DrawRectangle(0+end, player2y, 20, 130, new SolidBrush(Color.Purple));
            DrawRectangle(ballx, bally, 20, 20, new SolidBrush(Color.Black));
        }
        void DrawRectangle(int x, int y, int w, int h, SolidBrush Color)
        {
            graphics.FillRectangle(Color, new Rectangle(x, y, w, h));
        }

        void UpdateBall()
        {
            ballx += ballspdx;
            bally += ballspdy;

            if (ballx + 30 > this.Width)
            {
                ballspdx = -ballspdx;
            }

            if (bally < 0 || bally + 60 > this.Height)
            {
                ballspdy = -ballspdy;
            }

            if (IsCollided())
            {
                ballspdx = -ballspdx;
            }

            if (IsCollided2())
            {
                ballspdx = -ballspdx;
            }

            if (p == 2)
            {
                label1.Visible = true;
                labelP1.Visible = false;
                labelP2.Visible = false;
                label1.Text = "Pause";
                label1.ForeColor = Color.Black;
            }

            if (ballx < 0)
            {
                label1.Visible = true;
                label1.Text = "Purple Win!!!";
                label1.ForeColor = Color.Purple;
                ++MainForm.WP;
                game = false;
                timer.Stop();
            }
            if (ballx > end)
            {
                label1.Visible = true;
                label1.Text = "Green Win!!!";
                label1.ForeColor = Color.Green;
                ++MainForm.WG;
                game = false;
                timer.Stop();
            }
        }

        bool IsCollided()
        {
            if (ballx < 20 && bally > player1y && bally < player1y + 130)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        bool IsCollided2()
        {
            if (ballx > end - 20 && bally > player2y && bally < player2y + 130)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        void TimerCallback(object sender, EventArgs e)
        {
            DrawRectangle(0, player1y, 20, 130, new SolidBrush(Color.Green));
            DrawRectangle(0 + end, player2y, 20, 130, new SolidBrush(Color.Purple));
            DrawRectangle(ballx, bally, 20, 20, new SolidBrush(Color.Black));
            UpdateBall();

            this.Invalidate();
            return;
        }
        void Pause()
        {
            if (p == 2)
            {
                infopause = true;
                label1.Visible = true;
                labelP1.Visible = false;
                labelP2.Visible = false;
                label1.Text = "Pause";
                label1.ForeColor = Color.Black;
                timer.Stop();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int key = e.KeyValue;
            int key2 = e.KeyValue;

            if (key == 87 && player1y > 0 )
            {
                player1y -= ps;
            }

            if (key == 83 && player1y < 335)
            {
                player1y += ps;
            }
            
            if (key2 == 38 && player2y > 0)
            {
                player2y -= ps;
            }

            if (key2 == 40 && player2y < 335)
            {
                player2y += ps; 
            }

            if (key2 == 68)
            {
                pause1 = 1;
                labelP1.Visible = true;
                labelP1.Text = "pause";
                labelP1.ForeColor = Color.Green;
                p = pause1 + pause2;
                Pause();
            }

            if (key2 == 39)
            {
                pause2 = 1;
                labelP2.Visible = true;
                labelP2.Text = "pause";
                labelP2.ForeColor = Color.Purple;
                p = pause1 + pause2;
                Pause();
            }

            if (key2 == 32 && infopause == true)
            {
                infopause = false;
                pause1 = 0;
                pause2 = 0;
                p = 0;
                timer.Start();
                label1.Visible = false;
            }

            //if (key == 87 && player1y > 0 && key == 38 && player2y > 0)
            //{
            //    player1y -= ps;
            //    player2y -= ps;
            //}

            if (key == 27 && game == false)
            {
                MainForm MF = new MainForm();
                MF.Visible = true;
                this.Close();
            }
        }
    }
}
