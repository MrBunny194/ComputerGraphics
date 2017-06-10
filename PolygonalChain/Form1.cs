using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PolygonalChain
{
    public partial class MyForm : Form
    {
        private Graphics _graphics;
        private List<Point> _pointList;

        public MyForm()
        {
            InitializeComponent();
            _graphics = pictureBox.CreateGraphics();
            _pointList = new List<Point>();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Refresh();
            _pointList.Clear();
        }

        private void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _pointList.Add(new Point(e.X, e.Y));
                _graphics.DrawRectangle(new Pen(Color.Black, 2f), e.X, e.Y, 2f, 2f);
            }

            if (e.Button == MouseButtons.Right)
            {
                if (_pointList.Count > 0)
                {
                    for (var i = 0; i < _pointList.Count - 1; i++)
                    {
                        _graphics.DrawLine(new Pen(Color.Black, 1f), _pointList[i], _pointList[i + 1]);
                    }
                }
            }
        }

        private void BezierCurve_Click(object sender, EventArgs e)
        {
            if (_pointList.Count <= 1)
            {
                MessageBox.Show("Мало точек!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MyBezierCurve.Draw(_pointList, _graphics);
            }
                
        }

        private void DeCasteljausAlgorithm_Click(object sender, EventArgs e)
        {
            if(_pointList.Count <= 1)
            {
                MessageBox.Show("Мало точек!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MyDeCasteljausAlgorithm.Draw(_pointList, _graphics);
            }
        }
    }
}
