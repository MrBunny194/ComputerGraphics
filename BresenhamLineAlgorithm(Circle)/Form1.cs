using System;
using System.Drawing;
using System.Windows.Forms;

namespace BresenhamLineAlgorithm_Circle_
{
    public partial class MyForm : Form
    {
        private int _Xposition;
        private int _Yposition;

        public MyForm() => InitializeComponent();

        private void MyForm_MouseClick(object sender, MouseEventArgs e)
        {
            _Xposition = e.Location.X; // получение расположения указателя мыши
            _Yposition = e.Location.Y;

            // Создает новый объект Graphics из указанного дескриптора окна.
            var graphics = Graphics.FromHwnd(Handle);

            // Рисует прямоугольник, который определен парой координат, шириной и высотой.
            graphics.DrawRectangle(new Pen(Color.Black, 2), e.X, e.Y, 2, 2); 
        }

        private void DrawCircle_Click(object sender, EventArgs e)
        {
            Algorithms.Circle(_Xposition, _Yposition, (int)(CircleNumericUpDown.Value), Handle);
        }

        private void DrawEllipse_Click(object sender, EventArgs e)
        {
            var radiusA = (int)(ElipseNumericUpDown1.Value);
            int radiusB = (int)(ElipseNumericUpDown2.Value);
            Algorithms.Ellipse(_Xposition, _Yposition, radiusA, radiusB, Handle);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Graphics.FromHwnd(Handle).Clear(Color.White);
            CircleNumericUpDown.Value = 0;
            ElipseNumericUpDown1.Value = 0;
            ElipseNumericUpDown2.Value = 0;
        }
    }
}
