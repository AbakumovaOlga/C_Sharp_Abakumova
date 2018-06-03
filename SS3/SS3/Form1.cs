using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SS3
{
    public partial class Form1 : Form
    {
        int N = 3;
        Play p;
        Bitmap bitmap;
        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            p = new Play(N);
        }

        private void button00_Click(object sender, EventArgs e)
        {
            try
            {
                paint(p.step(0, 0));
            }
            catch (ExWin exW)
            {
                textBox.Text = exW.Message;
                finish();
            }
            catch (Exception ex)
            {
                textBox.Text = ex.Message;
            }
        }

        private void button01_Click(object sender, EventArgs e)
        {
            try
            {
                paint(p.step(0, 1));
            }
            catch (ExWin exW)
            {
                textBox.Text = exW.Message;
                finish();
            }
            catch (Exception ex)
            {
                textBox.Text = ex.Message;
            }
        }

        private void button02_Click(object sender, EventArgs e)
        {
            try
            {
                paint(p.step(0, 2));
            }
            catch (ExWin exW)
            {
                textBox.Text = exW.Message;
                finish();
            }
            catch (Exception ex)
            {
                textBox.Text = ex.Message;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                paint(p.step(1, 0));
            }
            catch (ExWin exW)
            {
                textBox.Text = exW.Message;
                finish();
            }
            catch (Exception ex)
            {
                textBox.Text = ex.Message;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                paint(p.step(1, 1));
            }
            catch (ExWin exW)
            {
                textBox.Text = exW.Message;
                finish();
            }
            catch (Exception ex)
            {
                textBox.Text = ex.Message;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                paint(p.step(1, 2));
            }
            catch (ExWin exW)
            {
                textBox.Text = exW.Message;
                finish();
            }
            catch (Exception ex)
            {
                textBox.Text = ex.Message;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            try
            {
                paint(p.step(2, 0));
            }
            catch (ExWin exW)
            {
                textBox.Text = exW.Message;
                finish();
            }
            catch (Exception ex)
            {
                textBox.Text = ex.Message;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            try
            {
                paint(p.step(2, 1));
            }
            catch (ExWin exW)
            {
                textBox.Text = exW.Message;
                finish();
            }
            catch (Exception ex)
            {
                textBox.Text = ex.Message;
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            try
            {
                paint(p.step(2, 2));
            }
            catch (ExWin exW)
            {
                textBox.Text = exW.Message;
                finish();
            }
            catch (Exception ex)
            {
                textBox.Text = ex.Message;
            }
        }

        private void paint(int[,] r)
        {
            pictureBox.Image = null;

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (r[j, i] == 1)
                        paintX(j, i);
                    if (r[j, i] == 0)
                        paint0(j, i);
                }
            }
            paintField();
            try
            {
                p.hasFree();
            }
            catch (ExWin exW)
            {
                textBox.Text = exW.Message;
            }
            catch (Exception ex)
            {
                textBox.Text = ex.Message;
                finish();
            }
        }

        private void paint0(int x, int y)
        {
            Graphics gr = Graphics.FromImage(bitmap);
            int size = bitmap.Width / 3;
            gr.DrawEllipse(new Pen(Color.Blue, 2), x * size + 10, y * size + 10, size - 20, size - 20);
            pictureBox.Image = bitmap;
        }

        private void paintX(int x, int y)
        {
            Graphics gr = Graphics.FromImage(bitmap);
            int size = bitmap.Width / 3;
            Pen p = new Pen(Color.Red, 2);
            gr.DrawLine(p, x * size + 10, y * size + 10, (1 + x) * size - 10, (1 + y) * size - 10);
            gr.DrawLine(p, (1 + x) * size - 10, y * size + 10, x * size + 10, (1 + y) * size - 10);
            pictureBox.Image = bitmap;
        }

        private void finish()
        {
            button00.Visible = false;
            button01.Visible = false;
            button02.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button20.Visible = false;
            button21.Visible = false;
            button22.Visible = false;
        }

        private void paintField()
        {
            Graphics gr = Graphics.FromImage(bitmap);

            Pen p = new Pen(Color.Black, 2);
            gr.DrawLine(p, bitmap.Width / 3, 0, bitmap.Width / 3, bitmap.Height);
            gr.DrawLine(p, bitmap.Width - bitmap.Width / 3, 0, bitmap.Width - bitmap.Width / 3, bitmap.Height);
            gr.DrawLine(p, 0, bitmap.Height / 3, bitmap.Width, bitmap.Height / 3);
            gr.DrawLine(p, 0, bitmap.Height - bitmap.Height / 3, bitmap.Width, bitmap.Height - bitmap.Height / 3);

            pictureBox.Image = bitmap;
        }
    }
}
