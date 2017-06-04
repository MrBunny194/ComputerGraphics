using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FillingTriangle
{
    public partial class MyForm : Form
    {
        private int[] _x;
        private int[] _y;
        private int _point;

        public MyForm()
        {
            _x = new int[3];
            _y = new int[3];
            _point = 0;

            InitializeComponent();
        }

        private void MyForm_MouseClick(object sender, MouseEventArgs e)
        {
            var graphics = Graphics.FromHwnd(Handle);

            if (e.Button == MouseButtons.Left)
            {
                if (_point < 3)
                {
                    _x[_point] = e.X;
                    _y[_point] = e.Y;

                    graphics.DrawRectangle(new Pen(Color.Black, 1), e.X, e.Y, 1, 1);
                    _point++;
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                if(_point == 3)
                {
                    Graphics.FromHwnd(Handle).DrawLine(new Pen(Color.Black, 1), _x[0], _y[0], _x[1], _y[1]);
                    Graphics.FromHwnd(Handle).DrawLine(new Pen(Color.Black, 1), _x[1], _y[1], _x[2], _y[2]);
                    Graphics.FromHwnd(Handle).DrawLine(new Pen(Color.Black, 1), _x[2], _y[2], _x[0], _y[0]);
                    Triangle.Fill(Graphics.FromHwnd(Handle), _x, _y);
                }
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Refresh();
            _point = 0;
        }
    }
}
