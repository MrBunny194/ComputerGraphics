using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CohenSutherlandAlgorithm
{
    public partial class MyForm : Form
    {
        private Point _point1;
        private Point _point2;
        private Point _click;

        private int _left = 0;
        private int _right = 0;
        private int _top = 0;
        private int _buttom = 0;

        public MyForm()
        {
            InitializeComponent();

            _point1 = new Point(0, 0);
            _point2 = new Point(0, 0);
            _click = new Point(0, 0);
        }

        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            // рисуем точку
            if (e.Button == MouseButtons.Left)
            {
                var graphics = PictureBox.CreateGraphics();
                var pen = new Pen(Color.Black);
                graphics.DrawRectangle(pen, e.X, e.Y, 1, 1);
                _point1.X = e.X;
                _point1.Y = e.Y;
            }
            else
            {
                if (e.Button == MouseButtons.Right)
                {
                    _click.X = e.X;
                    _click.Y = e.Y;
                }
            }
        }

        private void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // рисум линию
            {
                var graphics = PictureBox.CreateGraphics();
                var pen = new Pen(Color.Black);
                graphics.DrawRectangle(pen, e.X, e.Y, 1, 1);
                graphics. DrawLine(pen, _point1.X, _point1.Y, e.X, e.Y);
                _point2.X = e.X;
                _point2.Y = e.Y;
            }
            if (e.Button == MouseButtons.Right) // рисуем прямоугольник
            {
                _left = _click.X;
                _top = _click.Y;
                _right = e.X;
                _buttom = e.Y;
                var graphics = PictureBox.CreateGraphics();
                var pen = new Pen(Color.Black);
                graphics.DrawLine(pen, new Point(_left, _top), new Point(_right, _top));
                graphics.DrawLine(pen, new Point(_left, _top), new Point(_left, _buttom));
                graphics.DrawLine(pen, new Point(_right, _top), new Point(_right, _buttom));
                graphics.DrawLine(pen, new Point(_right, _buttom), new Point(_left, _buttom));
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
           PictureBox.CreateGraphics().Clear(Color.White);
        }

        private void Draw_Click(object sender, EventArgs e)
        {
            var graphics = PictureBox.CreateGraphics();
            graphics.DrawLine(new Pen(Color.Black), _point1, _point2);

            CohenSutherland.Draw(_point1.X, _point1.Y, _point2.X, _point2.Y, _left, _right, _top, _buttom, PictureBox.CreateGraphics());
        }
    }
}