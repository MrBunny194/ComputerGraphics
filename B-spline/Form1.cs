using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B_spline
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

        private void PictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _pointList.Add(new Point(e.X, e.Y));
                _graphics.DrawRectangle(new Pen(Color.Black, 2f), e.X, e.Y, 1f, 1f);
            }
            
            if (e.Button == MouseButtons.Right)
            {
                if (_pointList.Count > 0)
                {
                    for (int i = 0; i < _pointList.Count - 1; i++)
                    {
                        _graphics.DrawLine(new Pen(Color.Black, 1f), _pointList[i], _pointList[i + 1]);
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_pointList.Count <= 1)
            {
                MessageBox.Show("Мало точек!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (comboBox.SelectedItem.ToString() == "spline of the second order")
            {
                _pointList.Insert(0, _pointList[0]);
                _pointList.Add(_pointList[_pointList.Count - 1]);
                Spline.Draw2nd(_pointList, _graphics);
            }
            else if (comboBox.SelectedItem.ToString() == "spline of the third order")
            {
                _pointList.Insert(0, _pointList[0]);
                _pointList.Add(_pointList[_pointList.Count - 1]);
                _pointList.Insert(0, _pointList[0]);
                _pointList.Add(_pointList[_pointList.Count - 1]);
                Spline.Draw3rd(_pointList, _graphics);
            }
            else if (comboBox.SelectedItem.ToString() == "spline of the fourth order")
            {
               _pointList.Insert(0,_pointList[0]);
               _pointList.Add(_pointList[_pointList.Count - 1]);
               _pointList.Insert(0,_pointList[0]);
               _pointList.Add(_pointList[_pointList.Count - 1]);
               _pointList.Insert(0,_pointList[0]);
               _pointList.Add(_pointList[_pointList.Count - 1]);
                Spline.Draw4th(_pointList, _graphics);
            }
        }
    }
}
