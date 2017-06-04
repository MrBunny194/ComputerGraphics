using System;
using System.Drawing;
using System.Windows.Forms;

namespace ConvexPolygonFillAlgorithm
{
    public partial class MyForm : Form
    {
        private int _xMouseDown;
        private int _yMouseDown;
        private Point[] _P;
        private int _count; 
        private int _check;
        private bool _OffOn;

        public MyForm()
        {
            _P = new Point[50];
            _count = 0;
            _check = 0;

            InitializeComponent();
        }

        private void MyForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _xMouseDown = e.X;
                _yMouseDown = e.Y;
                _OffOn = true;
            }
        }

        private void MyForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _P[_count].X = e.Location.X;
                _P[_count].Y = e.Location.Y;
                _OffOn = false;
            }
        }

        private void MyForm_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                var graphics = Graphics.FromHwnd(Handle);
                if (_OffOn == true)
                {
                    Refresh();
                    graphics.DrawLine(new Pen(Color.Black), _xMouseDown, _yMouseDown, e.X, e.Y);
                }
            }
        }

        private void MyForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Graphics.FromHwnd(Handle).DrawLine(new Pen(Color.Black), e.X, e.Y, _P[_count].X, _P[_count].Y);
                _count++;
                _check++;
                _P[_count].X = e.Location.X;
                _P[_count].Y = e.Location.Y;
            }
        }

        private void ToClose_Click(object sender, EventArgs e)
        {
            Graphics.FromHwnd(Handle).DrawLine(
                new Pen(Color.Black), 
                _xMouseDown, 
                _yMouseDown, 
                _P[_count].X, 
                _P[_count].Y);

            _P[_check + 1].X = _xMouseDown;
            _P[_check + 1].Y = _yMouseDown;
            _check++;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Graphics.FromHwnd(Handle).Clear(Color.White);
            Refresh();
            _count = 0;
            _check = 0;
        }

        private void Fill_Click(object sender, EventArgs e)
        {
            var P1 = new Point[_check + 1];
            for (var i = 0; i < P1.Length; i++)
            {
                P1[i].X = _P[i].X;
                P1[i].Y = _P[i].Y;
            }
            ConvexPolygon.Fill(P1, P1.Length, _P, Graphics.FromHwnd(Handle));
        }
    }
}
