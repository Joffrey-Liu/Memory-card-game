using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 視窗HW5
{
    public partial class Form1 : Form
    {
        Rectangle[] RectDest = new Rectangle[17];
        Boolean[] RectMatch = new Boolean[17];
        Boolean Click = true;
        int[,] Compare = new int[8, 2] { { 1, 11 }, { 2, 10 }, { 3, 8 }, { 4, 6 }, { 5, 14 }, { 7, 12 }, { 9, 16 }, { 13, 15 } };
        int[] CurrentClick = new int[2];
        Image All = Properties.Resources._8_0;
        Image Apple = Properties.Resources._8_1;
        Image Banana = Properties.Resources._8_8;
        Image Cherry = Properties.Resources._8_4;
        Image Grape = Properties.Resources._8_3;
        Image Orange = Properties.Resources._8_5;
        Image Pieapple = Properties.Resources._8_6;
        Image Tomato = Properties.Resources._8_2;
        Image Watermelon = Properties.Resources._8_7;
        int time = 0;
        int x = 0, y = 30;
        int clickcount = 0;
        int filptime = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ClientSize = new Size(500, 500);
            timer1.Interval = 1000;
            timer1.Start();
            CurrentClick[0] = 0;
            CurrentClick[1] = 0;
            for (int i = 1; i < 17; i++)
                RectMatch[i] = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            label1.Text = time + " second";
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (ImageExsist())
            {
                x = 0; y = 30;
                for (int i = 1; i < 17; i++)
                {
                    RectDest[i] = new Rectangle(x, y, All.Width, All.Height);
                    x += All.Width;
                    if (i % 4 == 0)
                    {
                        x = 0;
                        y += All.Height;
                    }
                    e.Graphics.DrawImage(All, RectDest[i]);
                    e.Graphics.DrawRectangle(new Pen(Color.Black, 3), RectDest[i]);
                }
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (Click)
            {
                clickcount++;
                for (int i = 1; i < 17; i++)
                {
                    if (RectDest[i].Contains(e.Location))
                    {
                        RectMatch[i] = true;
                        Graphics g = this.CreateGraphics();
                        switch (i)
                        {
                            case 1:
                                {
                                    g.DrawImage(Apple, RectDest[i]);
                                    g.DrawRectangle(new Pen(Color.Black, 3), RectDest[i]);
                                    RectMatch[i] = true;
                                    CurrentClick[clickcount - 1] = i;
                                    timer2.Start();
                                }
                                break;
                            case 2:
                                {
                                    g.DrawImage(Banana, RectDest[i]);
                                    g.DrawRectangle(new Pen(Color.Black, 3), RectDest[i]);
                                    RectMatch[i] = true;
                                    CurrentClick[clickcount - 1] = i;
                                    timer2.Start();
                                }
                                break;
                            case 3:
                                {
                                    g.DrawImage(Cherry, RectDest[i]);
                                    g.DrawRectangle(new Pen(Color.Black, 3), RectDest[i]);
                                    RectMatch[i] = true;
                                    CurrentClick[clickcount - 1] = i;
                                    timer2.Start();
                                }
                                break;
                            case 4:
                                {
                                    g.DrawImage(Orange, RectDest[i]);
                                    g.DrawRectangle(new Pen(Color.Black, 3), RectDest[i]);
                                    RectMatch[i] = true;
                                    CurrentClick[clickcount - 1] = i;
                                    timer2.Start();
                                }
                                break;
                            case 5:
                                {
                                    g.DrawImage(Grape, RectDest[i]);
                                    g.DrawRectangle(new Pen(Color.Black, 3), RectDest[i]);
                                    RectMatch[i] = true;
                                    CurrentClick[clickcount - 1] = i;
                                    timer2.Start();
                                }
                                break;
                            case 6:
                                {
                                    g.DrawImage(Orange, RectDest[i]);
                                    g.DrawRectangle(new Pen(Color.Black, 3), RectDest[i]);
                                    RectMatch[i] = true;
                                    CurrentClick[clickcount - 1] = i;
                                    timer2.Start();
                                }
                                break;
                            case 7:
                                {
                                    g.DrawImage(Pieapple, RectDest[i]);
                                    g.DrawRectangle(new Pen(Color.Black, 3), RectDest[i]);
                                    RectMatch[i] = true;
                                    CurrentClick[clickcount - 1] = i;
                                    timer2.Start();
                                }
                                break;
                            case 8:
                                {
                                    g.DrawImage(Cherry, RectDest[i]);
                                    g.DrawRectangle(new Pen(Color.Black, 3), RectDest[i]);
                                    RectMatch[i] = true;
                                    CurrentClick[clickcount - 1] = i;
                                    timer2.Start();
                                }
                                break;
                            case 9:
                                {
                                    g.DrawImage(Tomato, RectDest[i]);
                                    g.DrawRectangle(new Pen(Color.Black, 3), RectDest[i]);
                                    RectMatch[i] = true;
                                    CurrentClick[clickcount - 1] = i;
                                    timer2.Start();
                                }
                                break;
                            case 10:
                                {
                                    g.DrawImage(Banana, RectDest[i]);
                                    g.DrawRectangle(new Pen(Color.Black, 3), RectDest[i]);
                                    RectMatch[i] = true;
                                    CurrentClick[clickcount - 1] = i;
                                    timer2.Start();
                                }
                                break;
                            case 11:
                                {
                                    g.DrawImage(Apple, RectDest[i]);
                                    g.DrawRectangle(new Pen(Color.Black, 3), RectDest[i]);
                                    RectMatch[i] = true;
                                    CurrentClick[clickcount - 1] = i;
                                    timer2.Start();
                                }
                                break;
                            case 12:
                                {
                                    g.DrawImage(Pieapple, RectDest[i]);
                                    g.DrawRectangle(new Pen(Color.Black, 3), RectDest[i]);
                                    RectMatch[i] = true;
                                    CurrentClick[clickcount - 1] = i;
                                    timer2.Start();
                                }
                                break;
                            case 13:
                                {
                                    g.DrawImage(Watermelon, RectDest[i]);
                                    g.DrawRectangle(new Pen(Color.Black, 3), RectDest[i]);
                                    RectMatch[i] = true;
                                    CurrentClick[clickcount - 1] = i;
                                    timer2.Start();
                                }
                                break;
                            case 14:
                                {
                                    g.DrawImage(Grape, RectDest[i]);
                                    g.DrawRectangle(new Pen(Color.Black, 3), RectDest[i]);
                                    RectMatch[i] = true;
                                    CurrentClick[clickcount - 1] = i;
                                    timer2.Start();
                                }
                                break;
                            case 15:
                                {
                                    g.DrawImage(Watermelon, RectDest[i]);
                                    g.DrawRectangle(new Pen(Color.Black, 3), RectDest[i]);
                                    RectMatch[i] = true;
                                    CurrentClick[clickcount - 1] = i;
                                    timer2.Start();
                                }
                                break;
                            case 16:
                                {
                                    g.DrawImage(Tomato, RectDest[i]);
                                    g.DrawRectangle(new Pen(Color.Black, 3), RectDest[i]);
                                    RectMatch[i] = true;
                                    CurrentClick[clickcount - 1] = i;
                                    timer2.Start();
                                }
                                break;
                        }
                        if (clickcount == 2)
                        {
                            clickcount = 0;
                            Click = false;
                        }
                    }
                }
            }
        }
            Boolean ImageExsist()
        {
            if (All != null && Apple != null && Banana != null && Cherry != null && Grape != null && Orange != null && Pieapple != null && Tomato != null && Watermelon != null)
                return true;
            else
                return false;
        }

        Boolean Match(int []input)
        {
            for(int i=0; i<8; i++)
            {
                if ((input[0] == Compare[i, 0] && input[1] == Compare[i, 1]) || input[1] == Compare[i, 0] && input[0] == Compare[i, 1])
                {
                    return true; 
                }
            }
            return false;
        }

        Boolean AllMatch()
        {
            if (RectMatch[1] == true && RectMatch[11] == true && RectMatch[2] == true && RectMatch[10] == true && RectMatch[3] == true && RectMatch[8] == true && RectMatch[4] == true && RectMatch[6] == true &&
                RectMatch[5] == true && RectMatch[14] == true && RectMatch[7] == true && RectMatch[12] == true && RectMatch[9] == true && RectMatch[16] == true && RectMatch[13] == true && RectMatch[15] == true)
                return true;
            else
                return false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
         filptime=0;
            filptime++;
            Graphics g = this.CreateGraphics();
            if (CurrentClick[0] != 0 && CurrentClick[1] != 0)
            {
                if (Match(CurrentClick) == false)
                {
                    timer2.Interval = 1000;
                    timer2.Start();
                    if (filptime == 1)
                    {
                        Click = false;
                        filptime = 0;
                        timer2.Stop();
                        g.DrawImage(All, RectDest[CurrentClick[0]]);
                        g.DrawRectangle(new Pen(Color.Black, 3), RectDest[CurrentClick[0]]);
                        g.DrawImage(All, RectDest[CurrentClick[1]]);
                        g.DrawRectangle(new Pen(Color.Black, 3), RectDest[CurrentClick[1]]);
                    }
                    RectMatch[CurrentClick[0]] = false;
                    RectMatch[CurrentClick[1]] = false;
                    CurrentClick[0] = 0;
                    CurrentClick[1] = 0;
                }
                else if (Match(CurrentClick) == true)
                {
                    RectMatch[CurrentClick[0]] = true;
                    RectMatch[CurrentClick[1]] = true;
                    CurrentClick[0] = 0;
                    CurrentClick[1] = 0;
                    filptime = 0;
                }
            }
            if (AllMatch())
            {
                timer1.Stop();
                timer2.Stop();
            }
            Click = true;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
             this.Invalidate();
            time = 0;
            x = 0; y = 30;
            clickcount = 0;
            filptime = 0;
            for (int i = 1; i < 17; i++)
                RectMatch[i] = false;
            CurrentClick[0] = 0; CurrentClick[1] = 0;
            timer1.Interval = 1000;
            timer1.Start();
            Click = true;
        }
        
    }
}
