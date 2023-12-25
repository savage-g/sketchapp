using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlTypes;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ergasia_1
{
    public partial class Form1 : Form
    {
        string txt;
        int oldX, oldY, width, height, newx, newy, newx2;
        double Mx,My,Nx,Ny,N2x,N2y,diag;
        int shape;
        int count = 0;
        bool move = false;
        bool erase = false;
        bool start = false;
        bool M_UP = false;
        bool tex = false;
        Pen pen, eraser;
        Graphics graphics,graphics2;
        Bitmap bitmap,bitmap2;
        Font f;
       
        //Lists with points of the shapes
        //1
        List<int> arrow = new List<int> { 382, 224, 382, 273, 464, 273, 464, 299, 550, 249, 464, 197, 464, 224, 382, 224 };
        //2
        List<int> star = new List<int>{114,181,191,233,162,148,133,233,210,181,114, 181 };
        //3
        List<int> diamond = new List<int> {75, 70,50, 95,75, 120,100, 95,75, 70};
        //4
        List<int> cross = new List<int>{250, 25, 250, 45,230, 45,230, 65,250, 65,250, 85,270, 85,270, 65,290, 65,290, 45,270, 45,270, 25, 250, 25};
       
        private void Form1_Load(object sender, EventArgs e)
        {
            pen = new Pen(Color.Black, 3);
            eraser = new Pen(Color.GhostWhite, 3);  
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            bitmap2 = new Bitmap(pictureBox2.Width, pictureBox2.Height);
            graphics = Graphics.FromImage(bitmap);
            graphics2 = Graphics.FromImage(bitmap2);
            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox1.Image = bitmap;
            pictureBox2.Image = bitmap2;
            pictureBox1.Parent = pictureBox2;
            graphics2.Clear(BackColor);
            graphics.Clear(BackColor);
            textBox1.Hide();
            label1.Hide();
            label2.Hide();


        }

        private void arrowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shape = 1;
            move = true;
            erase = false;
            tex = false;
            label2.Show();
            for (int i = 0; i < arrow.Count - 2; i = i + 2)
            {
                graphics.DrawLine(pen, arrow[i], arrow[i + 1], arrow[i + 2], arrow[i + 3]);
                
            }
            pictureBox1.Refresh();
            erase = false;
            
        }

       

        private void penColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
               pen.Color = colorDialog1.Color;
            }
        }

       

        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shape = 4;
            label2.Show();
            erase = false;
            tex = false;

        }


        private void starToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shape = 2;
            label2.Show();
            erase = false;
            move = true;
            tex = false;
            for (int i = 0; i < star.Count - 2; i = i + 2)
            {
                graphics.DrawLine(pen, star[i], star[i + 1], star[i + 2], star[i + 3]);

            }
            pictureBox1.Refresh();
        }

        private void ringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shape = 3;
            label2.Show();
            erase = false;
            tex = false;

        }
        private void RingMath(int oldx,int oldy,int nX,int nY) 
        {
            Mx = (nX + oldx) / 2;
            My = (nY + oldy) / 2;
            Nx=(Mx + oldx) / 2;
            Ny=(My + oldy) / 2;
            N2x=(nX + Mx) / 2;
            N2y = (nY + My) / 2;
            
            diag = Math.Sqrt(Math.Pow((N2x-Nx),2.0)+ Math.Pow((N2y - Ny), 2.0));
            width =Convert.ToInt32(diag / (1.4));
            if (M_UP){graphics2.DrawEllipse(pen, Convert.ToInt32(Nx), Convert.ToInt32(Ny), width, width);
                pictureBox2.Refresh();
                M_UP = false;
            }
            else {graphics.DrawEllipse(pen, Convert.ToInt32(Nx), Convert.ToInt32(Ny), width, width);
                pictureBox1.Refresh();
            }        
            
            
        }

        private void ovalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shape = 7;
            erase = false;
            tex = false;
            label2.Show();
        }

        private void smallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pen.Width = 2f;
        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pen.Width = 3f;
        }

        private void bigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pen.Width = 5f;
        }

        private void hugeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pen.Width = 7f;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            count++;
            if (count == 1)
            {
                MessageBox.Show("You can move the shapes with the arrow up,down,left and right");

            }else if (count == 2)
            {
                MessageBox.Show("Can you make a house?");
            }
            else if (count==3)
            {
                MessageBox.Show("Made to make people smile cause i cried to make it work:)");
            }
            else
            {
                MessageBox.Show("Made by a unipi student");
            }
        }

        private void diamondToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shape = 8;
            label2.Show();
            tex = false;
            erase = false;
            move = true;
            for (int i = 0; i < diamond.Count - 2; i=i+2)
            {
                graphics.DrawLine(pen, diamond[i], diamond[i + 1], diamond[i + 2], diamond[i+3]);
            }
            pictureBox1.Refresh();
        }

        private void circleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shape = 9;
            label2.Show();
            tex = false;
            erase = false;
            width = 0;
            height = 0;
            // graphics.DrawEllipse(pen, 20, 20, 80, 80);
            //pictureBox1.Refresh();
        }

        
        private void crossToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tex = false;
            label2.Show();
            shape = 5;
            erase = false;
            move = true;
            for (int i = 0; i < cross.Count - 2; i=i+2)
            {
                graphics.DrawLine(pen, cross[i], cross[i + 1], cross[i + 2], cross[i + 3]);
            }
            pictureBox1.Refresh();
        }

       

        private void isoskelesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shape = 6;
            label2.Show();
            erase = false;
            tex = false;
        }

        

        private void rightAngleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shape = 11;
            label2.Show();
            erase = false;
            tex = false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            txt = e.KeyData.ToString();
            if (move)
            {

                if (shape == 1)
                {
                    if (e.KeyData == Keys.Up)
                    {
                        graphics.Clear(Color.Transparent);
                        arrow[1] -= 5;
                        for (int i = 0; i < arrow.Count - 2; i = i + 2)
                        {
                            arrow[i + 3] -= 5;
                            graphics.DrawLine(pen, arrow[i], arrow[i + 1], arrow[i + 2], arrow[i + 3]);

                        }

                        pictureBox1.Refresh();
                    }
                    else if (e.KeyData == Keys.Down)
                    {
                        arrow[1] += 5;
                        graphics.Clear(Color.Transparent);
                        for (int i = 0; i < arrow.Count - 2; i = i + 2)
                        {
                            arrow[i + 3] += 5;
                            graphics.DrawLine(pen, arrow[i], arrow[i + 1], arrow[i + 2], arrow[i + 3]);
                        }
                        pictureBox1.Refresh();
                    }
                    else if (e.KeyData == Keys.Right)
                    {
                        arrow[0] += 5;
                        graphics.Clear(Color.Transparent);
                        for (int i = 0; i < arrow.Count - 2; i = i + 2)
                        {
                            arrow[i + 2] += 5;
                            graphics.DrawLine(pen, arrow[i], arrow[i + 1], arrow[i + 2], arrow[i + 3]);
                        }
                        pictureBox1.Refresh();
                    }
                    else if (e.KeyData == Keys.Left)
                    {
                        arrow[0] -= 5;
                        graphics.Clear(Color.Transparent);
                        for (int i = 0; i < arrow.Count - 2; i = i + 2)
                        {
                            arrow[i + 2] -= 5;
                            graphics.DrawLine(pen, arrow[i], arrow[i + 1], arrow[i + 2], arrow[i + 3]);
                        }
                        pictureBox1.Refresh();
                    }
                    else if (e.KeyData == Keys.Enter)
                    {
                        graphics.Clear(Color.Transparent);
                        for (int i = 0; i < arrow.Count - 2; i = i + 2)
                        {
                            graphics2.DrawLine(pen, arrow[i], arrow[i + 1], arrow[i + 2], arrow[i + 3]);
                        }
                        pictureBox2.Refresh();
                        move = false;
                        label2.Hide();
                    }
                }
            
            if (shape == 2)
            {
                if (e.KeyData == Keys.Up)
                {
                    graphics.Clear(Color.Transparent);
                    star[1] -= 5;
                    for (int i = 0; i < star.Count - 2; i = i + 2)
                    {
                        star[i + 3] -= 5;
                        graphics.DrawLine(pen, star[i], star[i + 1], star[i + 2], star[i + 3]);

                    }

                    pictureBox1.Refresh();
                }
                else if (e.KeyData == Keys.Down)
                {
                    star[1] += 5;
                    graphics.Clear(Color.Transparent);
                    for (int i = 0; i < star.Count - 2; i = i + 2)
                    {
                        star[i + 3] += 5;
                        graphics.DrawLine(pen, star[i], star[i + 1], star[i + 2], star[i + 3]);
                    }
                    pictureBox1.Refresh();
                }
                else if (e.KeyData == Keys.Right)
                {
                    star[0] += 5;
                    graphics.Clear(Color.Transparent);
                    for (int i = 0; i <star.Count - 2; i = i + 2)
                    {
                        star[i + 2] += 5;
                        graphics.DrawLine(pen, star[i], star[i + 1], star[i + 2], star[i + 3]);
                    }
                    pictureBox1.Refresh();
                }
                else if (e.KeyData == Keys.Left)
                {
                    star[0] -= 5;
                    graphics.Clear(Color.Transparent);
                    for (int i = 0; i < star.Count - 2; i = i + 2)
                    {
                        star[i + 2] -= 5;
                        graphics.DrawLine(pen, star[i], star[i + 1], star[i + 2], star[i + 3]);
                    }
                    pictureBox1.Refresh();
                }
                else if (e.KeyData == Keys.Enter)
                {
                    graphics.Clear(Color.Transparent);
                    for (int i = 0; i < star.Count - 2; i = i + 2)
                    {
                        graphics2.DrawLine(pen, star[i], star[i + 1], star[i + 2], star[i + 3]);
                    }
                    pictureBox2.Refresh();
                    move = false;
                        label2.Hide();
                    }
            }
            else if (shape == 3)
            {
                if (e.KeyData == Keys.Up)
                {
                    graphics.Clear(Color.Transparent);
                    oldY -= 5;
                    graphics.DrawEllipse(pen, oldX, oldY, height, height);
                    RingMath(oldX, oldY, newx, newy);
                    pictureBox1.Refresh();
                }
                else if (e.KeyData == Keys.Down)
                {
                    graphics.Clear(Color.Transparent);
                    oldY += 5;
                    graphics.DrawEllipse(pen, oldX, oldY, height, height);
                    RingMath(oldX, oldY, newx, newy);
                    pictureBox1.Refresh();
                }
                else if (e.KeyData == Keys.Right)
                {
                    graphics.Clear(Color.Transparent);
                    oldX += 5;
                    graphics.DrawEllipse(pen, oldX, oldY, height, height);
                    RingMath(oldX, oldY, newx, newy);
                    pictureBox1.Refresh();
                }
                else if (e.KeyData == Keys.Left)
                {
                    graphics.Clear(Color.Transparent);
                    oldX -= 5;
                    graphics.DrawEllipse(pen, oldX, oldY, height, height);
                    RingMath(oldX, oldY, newx, newy);
                    pictureBox1.Refresh();
                }
                else if (e.KeyData == Keys.Enter)
                {
                    graphics.Clear(Color.Transparent);
                    graphics2.DrawEllipse(pen, oldX, oldY, height, height);
                    M_UP = true;
                    RingMath(oldX, oldY, newx, newy);
                    pictureBox2.Refresh();
                    move = false;
                        label2.Hide();
                    }
            }
            else if (shape == 4)
            {
                if (e.KeyData == Keys.Up)
                {
                    graphics.Clear(Color.Transparent);
                    oldY -= 5;
                    graphics.DrawRectangle(pen, oldX, oldY, width, height);
                    pictureBox1.Refresh();
                }
                else if (e.KeyData == Keys.Down)
                {
                    graphics.Clear(Color.Transparent);
                    oldY += 5;
                    graphics.DrawRectangle(pen, oldX, oldY, width, height);
                    pictureBox1.Refresh();
                }
                else if (e.KeyData == Keys.Right)
                {
                    graphics.Clear(Color.Transparent);
                    oldX += 5;
                    graphics.DrawRectangle(pen, oldX, oldY, width, height);
                    pictureBox1.Refresh();
                }
                else if (e.KeyData == Keys.Left)
                {
                    graphics.Clear(Color.Transparent);
                    oldX -= 5;
                    graphics.DrawRectangle(pen, oldX, oldY, width, height);
                    pictureBox1.Refresh();
                }
                else if (e.KeyData == Keys.Enter)
                {
                    graphics.Clear(Color.Transparent);
                    graphics2.DrawRectangle(pen, oldX, oldY, width, height);
                    pictureBox2.Refresh();
                    move = false;
                        label2.Hide();
                    }
            }
                if (shape == 5)
                {
                    if (e.KeyData == Keys.Up)
                    {
                        graphics.Clear(Color.Transparent);
                        cross[1] -= 5;
                        for (int i = 0; i < cross.Count - 2; i = i + 2)
                        {
                            cross[i + 3] -= 5;
                            graphics.DrawLine(pen, cross[i], cross[i + 1], cross[i + 2], cross[i + 3]);

                        }

                        pictureBox1.Refresh();
                    }
                    else if (e.KeyData == Keys.Down)
                    {
                        cross[1] += 5;
                        graphics.Clear(Color.Transparent);
                        for (int i = 0; i < cross.Count - 2; i = i + 2)
                        {
                            cross[i + 3] += 5;
                            graphics.DrawLine(pen, cross[i], cross[i + 1], cross[i + 2], cross[i + 3]);
                        }
                        pictureBox1.Refresh();
                    }
                    else if (e.KeyData == Keys.Right)
                    {
                        cross[0] += 5;
                        graphics.Clear(Color.Transparent);
                        for (int i = 0; i < cross.Count - 2; i = i + 2)
                        {
                            cross[i + 2] += 5;
                            graphics.DrawLine(pen, cross[i], cross[i + 1], cross[i + 2], cross[i + 3]);
                        }
                        pictureBox1.Refresh();
                    }
                    else if (e.KeyData == Keys.Left)
                    {
                        cross[0] -= 5;
                        graphics.Clear(Color.Transparent);
                        for (int i = 0; i < cross.Count - 2; i = i + 2)
                        {
                            cross[i + 2] -= 5;
                            graphics.DrawLine(pen, cross[i], cross[i + 1], cross[i + 2], cross[i + 3]);
                        }
                        pictureBox1.Refresh();
                    }
                    else if (e.KeyData == Keys.Enter)
                    {
                        graphics.Clear(Color.Transparent);
                        for (int i = 0; i < cross.Count - 2; i = i + 2)
                        {
                            graphics2.DrawLine(pen, cross[i], cross[i + 1], cross[i + 2], cross[i + 3]);
                        }
                        pictureBox2.Refresh();
                        label2.Hide();
                        move = false;
                    }
                }
                else if (shape == 6)
            {
                if (e.KeyData == Keys.Up)
                {
                    graphics.Clear(Color.Transparent);
                    oldY -= 5;
                    newy -= 5;

                    graphics.DrawLine(pen, oldX, oldY, newx2, newy);
                    graphics.DrawLine(pen, newx2, newy, newx, newy);
                    graphics.DrawLine(pen, newx, newy, oldX, oldY);
                    pictureBox1.Refresh();
                }
                else if (e.KeyData == Keys.Down)
                {
                    graphics.Clear(Color.Transparent);
                    oldY += 5;
                    newy += 5;
                    graphics.DrawLine(pen, oldX, oldY, newx2, newy);
                    graphics.DrawLine(pen, newx2, newy, newx, newy);
                    graphics.DrawLine(pen, newx, newy, oldX, oldY);
                    pictureBox1.Refresh();
                }
                else if (e.KeyData == Keys.Right)
                {
                    graphics.Clear(Color.Transparent);
                    oldX += 5;
                    newx += 5;
                    newx2 += 5;
                    graphics.DrawLine(pen, oldX, oldY, newx2, newy);
                    graphics.DrawLine(pen, newx2, newy, newx, newy);
                    graphics.DrawLine(pen, newx, newy, oldX, oldY);
                    pictureBox1.Refresh();
                }
                else if (e.KeyData == Keys.Left)
                {
                    graphics.Clear(Color.Transparent);
                    oldX -= 5;
                    newx -= 5;
                    newx2 -= 5;
                    graphics.DrawLine(pen, oldX, oldY, newx2, newy);
                    graphics.DrawLine(pen, newx2, newy, newx, newy);
                    graphics.DrawLine(pen, newx, newy, oldX, oldY);
                    pictureBox1.Refresh();
                }
                else if (e.KeyData == Keys.Enter)
                {
                    graphics.Clear(Color.Transparent);
                    graphics2.DrawLine(pen, oldX, oldY, newx2, newy);
                    graphics2.DrawLine(pen, newx2, newy, newx, newy);
                    graphics2.DrawLine(pen, newx, newy, oldX, oldY);
                    pictureBox2.Refresh();
                        label2.Hide();
                        move = false;
                }
            }
            else if (shape == 7)
            {
                if (e.KeyData == Keys.Up)
                {
                    graphics.Clear(Color.Transparent);
                    oldY -= 5;
                    graphics.DrawEllipse(pen, oldX, oldY, width, height);
                    pictureBox1.Refresh();
                }
                else if (e.KeyData == Keys.Down)
                {
                    graphics.Clear(Color.Transparent);
                    oldY += 5;
                    graphics.DrawEllipse(pen, oldX, oldY, width, height);
                    pictureBox1.Refresh();
                }
                else if (e.KeyData == Keys.Right)
                {
                    graphics.Clear(Color.Transparent);
                    oldX += 5;
                    graphics.DrawEllipse(pen, oldX, oldY, width, height);
                    pictureBox1.Refresh();
                }
                else if (e.KeyData == Keys.Left)
                {
                    graphics.Clear(Color.Transparent);
                    oldX -= 5;
                    graphics.DrawEllipse(pen, oldX, oldY, width, height);
                    pictureBox1.Refresh();
                }
                else if (e.KeyData == Keys.Enter)
                {
                    graphics.Clear(Color.Transparent);
                    graphics2.DrawEllipse(pen, oldX, oldY, width, height);
                    pictureBox2.Refresh();
                        label2.Hide();
                        move = false;
                }
            }
                if (shape == 8)
                {
                    if (e.KeyData == Keys.Up)
                    {
                        graphics.Clear(Color.Transparent);
                        diamond[1] -= 5;
                        for (int i = 0; i < diamond.Count - 2; i = i + 2)
                        {
                            diamond[i + 3] -= 5;
                            graphics.DrawLine(pen, diamond[i], diamond[i + 1], diamond[i + 2], diamond[i + 3]);

                        }

                        pictureBox1.Refresh();
                    }
                    else if (e.KeyData == Keys.Down)
                    {
                        diamond[1] += 5;
                        graphics.Clear(Color.Transparent);
                        for (int i = 0; i < diamond.Count - 2; i = i + 2)
                        {
                            diamond[i + 3] += 5;
                            graphics.DrawLine(pen, diamond[i], diamond[i + 1], diamond[i + 2], diamond[i + 3]);
                        }
                        pictureBox1.Refresh();
                    }
                    else if (e.KeyData == Keys.Right)
                    {
                        diamond[0] += 5;
                        graphics.Clear(Color.Transparent);
                        for (int i = 0; i < diamond.Count - 2; i = i + 2)
                        {
                            diamond[i + 2] += 5;
                            graphics.DrawLine(pen, diamond[i], diamond[i + 1], diamond[i + 2], diamond[i + 3]);
                        }
                        pictureBox1.Refresh();
                    }
                    else if (e.KeyData == Keys.Left)
                    {
                        diamond[0] -= 5;
                        graphics.Clear(Color.Transparent);
                        for (int i = 0; i < diamond.Count - 2; i = i + 2)
                        {
                            diamond[i + 2] -= 5;
                            graphics.DrawLine(pen, diamond[i], diamond[i + 1], diamond[i + 2], diamond[i + 3]);
                        }
                        pictureBox1.Refresh();
                    }
                    else if (e.KeyData == Keys.Enter)
                    {
                        graphics.Clear(Color.Transparent);
                        for (int i = 0; i < diamond.Count - 2; i = i + 2)
                        {
                            graphics2.DrawLine(pen, diamond[i], diamond[i + 1], diamond[i + 2], diamond[i + 3]);
                        }
                        pictureBox2.Refresh();
                        label2.Hide();
                        move = false;
                    }
                }
                else if (shape == 9)
            {
                if (e.KeyData == Keys.Up)
                {
                    graphics.Clear(Color.Transparent);
                    oldY -= 5;
                    graphics.DrawEllipse(pen, oldX, oldY, height, height);
                    pictureBox1.Refresh();
                }
                else if (e.KeyData == Keys.Down)
                {
                    graphics.Clear(Color.Transparent);
                    oldY += 5;
                    graphics.DrawEllipse(pen, oldX, oldY, height, height);
                    pictureBox1.Refresh();
                }
                else if (e.KeyData == Keys.Right)
                {
                    graphics.Clear(Color.Transparent);
                    oldX += 5;
                    graphics.DrawEllipse(pen, oldX, oldY, height, height);
                    pictureBox1.Refresh();
                }
                else if (e.KeyData == Keys.Left)
                {
                    graphics.Clear(Color.Transparent);
                    oldX -= 5;
                    graphics.DrawEllipse(pen, oldX, oldY, height, height);
                    pictureBox1.Refresh();
                }
                else if (e.KeyData == Keys.Enter)
                {
                    graphics.Clear(Color.Transparent);
                    graphics2.DrawEllipse(pen, oldX, oldY, height, height);
                    pictureBox2.Refresh();
                        label2.Hide();
                        move = false;
                }
            }
            else if (shape == 11)
            {
                if (e.KeyData == Keys.Up)
                {
                    graphics.Clear(Color.Transparent);
                    oldY -= 5;
                    newy -= 5;

                    graphics.DrawLine(pen, oldX, oldY, newx, newy);
                    graphics.DrawLine(pen, newx, newy, oldX, newy);
                    graphics.DrawLine(pen, oldX, newy, oldX, oldY);
                    pictureBox1.Refresh();
                }
                else if (e.KeyData == Keys.Down)
                {
                    graphics.Clear(Color.Transparent);
                    oldY += 5;
                    newy += 5;
                    graphics.DrawLine(pen, oldX, oldY, newx, newy);
                    graphics.DrawLine(pen, newx, newy, oldX, newy);
                    graphics.DrawLine(pen, oldX, newy, oldX, oldY);
                    pictureBox1.Refresh();
                }
                else if (e.KeyData == Keys.Right)
                {
                    graphics.Clear(Color.Transparent);
                    oldX += 5;
                    newx += 5;
                    newx2 += 5;
                    graphics.DrawLine(pen, oldX, oldY, newx, newy);
                    graphics.DrawLine(pen, newx, newy, oldX, newy);
                    graphics.DrawLine(pen, oldX, newy, oldX, oldY);
                    pictureBox1.Refresh();
                }
                else if (e.KeyData == Keys.Left)
                {
                    graphics.Clear(Color.Transparent);
                    oldX -= 5;
                    newx -= 5;
                    newx2 -= 5;
                    graphics.DrawLine(pen, oldX, oldY, newx, newy);
                    graphics.DrawLine(pen, newx, newy, oldX, newy);
                    graphics.DrawLine(pen, oldX, newy, oldX, oldY);
                    pictureBox1.Refresh();
                }
                else if (e.KeyData == Keys.Enter)
                {
                    graphics.Clear(Color.Transparent);
                    graphics2.DrawLine(pen, oldX, oldY, newx, newy);
                    graphics2.DrawLine(pen, newx, newy, oldX, newy);
                    graphics2.DrawLine(pen, oldX, newy, oldX, oldY);
                    pictureBox2.Refresh();
                    move = false;
                        label2.Hide();
                    }
            }
        }
            }
            
            
        
        

        private void cleatAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            graphics2.Clear(BackColor);
            graphics.Clear(BackColor);


            pictureBox1.Refresh();
        }

        private void eraserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            erase = true;
            
            //pictureBox1.BackColor = Color.White;
            //pictureBox2.BackColor= Color.White;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            oldX = e.X;
            oldY = e.Y;
            if (tex)
            {
               
                SolidBrush brush = new SolidBrush(pen.Color);
                graphics2.DrawString(textBox1.Text, f, brush, new PointF(e.X, e.Y));
                graphics.DrawString(textBox1.Text, f, brush, new PointF(e.X, e.Y));
                label1.Hide();
                textBox1.Hide();
                pictureBox2.Refresh();
                pictureBox1.Refresh();
                
            }
            else {start = true; }
            

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            
            start = false;
            if (erase)
            {

            }else if (shape==3) 
            {
                newx = e.X;
                newy = e.Y;
                pictureBox1.Refresh();
                move = true;
            }
            else if(shape==6)
            {
                newx = (2 * oldX) - e.X;
                newx2 = e.X;
                newy = e.Y;
                
                pictureBox1.Refresh();
                move=true;
            }
            else if (shape == 4)
            {
                pictureBox1.Refresh();
                move = true;
            }
            else if (shape == 9)
            {
                pictureBox1.Refresh();
                move = true;

            }else if (shape == 7)
            {
                pictureBox1.Refresh();
                move = true;

            }else if (shape == 11)
            {
                newx = e.X;
                newy = e.Y;
                graphics.DrawLine(pen, oldX, oldY, newx, newy);
                graphics.DrawLine(pen, newx, newy, oldX, newy);
                graphics.DrawLine(pen, oldX, newy, oldX, oldY);
                pictureBox1.Refresh();
                move = true;
            }

           // height = 0;
            //width = 0;
        }

        private void saveFIleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            pictureBox2.BackColor = Color.White;
            pictureBox2.Refresh();
            
            if(saveFileDialog1.ShowDialog()== DialogResult.OK)
                {
                   pictureBox2.Image.Save(saveFileDialog1.FileName, ImageFormat.Png);
                }
        }

        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tex = true;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                f = fontDialog1.Font;
            }
            label1.Show();
            textBox1.Show();
            
         // pictureBox2.Refresh();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (start)
            {
                if (erase)
                {
                    graphics.DrawLine(eraser, oldX, oldY, e.X, e.Y);
                    graphics2.DrawLine(eraser, oldX, oldY, e.X, e.Y);

                    oldX = e.X;
                    oldY = e.Y;
                    pictureBox1.Refresh();
                    pictureBox2.Refresh();
                    

                }else if (shape == 3)
                {
                    graphics.Clear(Color.Transparent);
                    
                    height = Math.Abs(e.X - oldX);
                    graphics.DrawEllipse(pen, oldX, oldY, height, height);
                    RingMath(oldX,oldY,e.X,e.Y);
                    
                    pictureBox1.Refresh();

                }
                else if(shape==4)
                {
                    graphics.Clear(Color.Transparent);
                    
                    width = Math.Abs(e.X - oldX);
                    height = Math.Abs(e.Y - oldY);
                    graphics.DrawRectangle(pen, oldX, oldY, width, height);
                    pictureBox1.Refresh();
                }
                else if (shape == 6)
                {
                    graphics.Clear(Color.Transparent);

                    newx =(2*oldX)-e.X;
                    graphics.DrawLine(pen,oldX,oldY,e.X,e.Y);
                    graphics.DrawLine(pen,e.X,e.Y,newx,e.Y);
                    graphics.DrawLine(pen,newx,e.Y,oldX,oldY);
                    pictureBox1.Refresh();

                }
                else if (shape == 9)
                {
                    graphics.Clear(Color.Transparent);

                    height = Math.Abs(e.X-oldX);
                    graphics.DrawEllipse(pen, oldX, oldY, height,height);
                    pictureBox1.Refresh();

                }else if (shape == 7)
                {
                    graphics.Clear(Color.Transparent);

                    width = Math.Abs(e.X - oldX);
                    height = Math.Abs(e.Y - oldY);
                    graphics.DrawEllipse(pen, oldX, oldY, width, height);
                    pictureBox1.Refresh();
                }
                else if (shape == 11)
                {
                    graphics.Clear(Color.Transparent);

                    graphics.DrawLine(pen, oldX, oldY, e.X, e.Y);
                    graphics.DrawLine(pen, e.X, e.Y, oldX, e.Y);
                    graphics.DrawLine(pen, oldX, e.Y, oldX, oldY);
                    pictureBox1.Refresh();

                }
               

            }
        }

        public Form1()
        {
            InitializeComponent();
        }
    }
}
