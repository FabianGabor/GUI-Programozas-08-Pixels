using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pixels
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Rectangle> rectanglesRed = new List<Rectangle>();
        List<Rectangle> rectanglesWhite = new List<Rectangle>();

        private void Form1_Paint(object sender, PaintEventArgs pe)
        {
        }

        private void drawBtn_Click(object sender, EventArgs e)
        {
            switch (listBox.SelectedIndex)
            {
                case 0:
                    fillArea();
                    break;
                case 1:
                    checkerbox(5);
                    break;
                case 2:
                    checkerbox(50);
                    break;
                case 3:
                    noise(2);
                    break;
            }
        }

        private void fillArea()
        {
            drawPanel.BackColor = Color.Red;
            this.Invalidate(); // force Redraw the form
        }

        private void checkerbox(int size)
        {
            rectanglesRed.Clear();
            rectanglesWhite.Clear();
            
            var countX = drawPanel.Width / size;
            var countY = drawPanel.Height / size;

            for (int i = 0; i <= countX; i++)
            {
                for (int j = 0; j <= countY; j+=2)
                {
                    var rectangle = new Rectangle(new Point(i * size, j * size + size * (i%2)), new Size(size, size));
                    this.rectanglesRed.Add(rectangle);
                    
                    rectangle = new Rectangle(new Point(i * size, j * size + size * ((i+1)%2)), new Size(size, size));
                    this.rectanglesWhite.Add(rectangle);
                }
            }

            this.Invalidate(); // force Redraw the form
        }
        
        private void noise(int size)
        {
            rectanglesRed.Clear();
            rectanglesWhite.Clear();
            
            var countX = drawPanel.Width / size;
            var countY = drawPanel.Height / size;

            Random random = new Random();
            for (int i = 0; i <= countX; i++)
            {
                for (int j = 0; j <= countY; j++)
                {
                    var rectangle = new Rectangle(new Point(i * size, j * size), new Size(size, size));
                    
                    if (random.NextDouble() > 0.5)
                        this.rectanglesRed.Add(rectangle);
                    else
                    {
                        this.rectanglesWhite.Add(rectangle);
                    }
                }
            }

            this.Invalidate(); // force Redraw the form
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            this.Paint += drawPanel_Paint;
        }

        private void drawPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = drawPanel.CreateGraphics();
            
            SolidBrush sb = new SolidBrush(Color.Red);

            drawPanel.BackColor = Color.White;
            foreach (var rectangle in this.rectanglesRed)
            {
                g.FillRectangle(sb, rectangle);
            }
            
            sb = new SolidBrush(Color.White);
            foreach (var rectangle in this.rectanglesWhite)
            {
                g.FillRectangle(sb, rectangle);
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}