using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BresenhamLineAlgorithm
{
    public partial class MyForm : Form
    {
        private Bitmap _bitmap;
        private List<Point> _points;

        public MyForm()
        {
            InitializeComponent();
            _bitmap = new Bitmap(Width, Height);
            _points = new List<Point>();
        }

        private void MyPanel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(_bitmap, 0, 0);
        }

        private void MyPanel_MouseClick(object sender, MouseEventArgs e)
        {
            _bitmap.SetPixel(e.X, e.Y, Color.Black);
            _points.Add(new Point(e.X, e.Y));
            Refresh();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            _points.Clear();
            _bitmap = new Bitmap(Width, Height);
            Refresh();
        }

        private void DrawLine_Click(object sender, EventArgs e)
        {
            for (var i = 1; i < _points.Count; i++)
            {
                Bresenham.DrawLine(_bitmap, _points[i - 1].X, _points[i - 1].Y, _points[i].X, _points[i].Y);
            }

            var newStart = _points.Last();
            _points.Clear();
            _points.Add(newStart);
            Refresh();
        }
    }
}
