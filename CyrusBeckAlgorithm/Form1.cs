using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyrusBeckAlgorithm
{
    public partial class MyForm : Form
    {
        private int[] _x;
        private int[] _y;
        private int _i;

        public MyForm()
        {
            _x = new int[50];
            _y = new int[50];
            _i = 0;

            InitializeComponent();
        }

        private void MyForm_MouseClick(object sender, MouseEventArgs e)
        {
            var graphics = Graphics.FromHwnd(Handle);

            if (e.Button == MouseButtons.Left)
            {
                _x[_i] = e.X;
                _y[_i] = e.Y;

                graphics.DrawRectangle(new Pen(Color.Black), e.X, e.Y, 1, 1);

                if (++_i == 2)
                {
                    graphics.DrawLine(new Pen(Color.Black), _x[0], _y[0], _x[1], _y[1]);
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                for (var j = 2; j < _i - 1; j++)
                {
                    graphics.DrawLine(new Pen(Color.Black), _x[j], _y[j], _x[j + 1], _y[j + 1]);
                }

                graphics.DrawLine(new Pen(Color.Black), _x[_i - 1], _y[_i - 1], _x[2], _y[2]);
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Refresh();
            _i = 0;
        }

        private void Draw_Click(object sender, EventArgs e)
        {
            CyrusBeck.Draw(Graphics.FromHwnd(Handle), _x, _y, _i);
        }
    }
}
