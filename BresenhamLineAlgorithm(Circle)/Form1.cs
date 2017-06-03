using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BresenhamLineAlgorithm_Circle_
{
    public partial class MyForm : Form
    {
        private int _Xposition;
        private int _Yposition;

        public MyForm()
        {
            InitializeComponent();
        }

        private void MyForm_MouseClick(object sender, MouseEventArgs e)
        {
            _Xposition = e.Location.X; // получение расположения указателя мыши
            _Yposition = e.Location.Y;

            // Создает новый объект Graphics из указанного дескриптора окна.
            var graphics = Graphics.FromHwnd(Handle);

            //Инициализирует новый экземпляр класса Pen с указанными свойствами Color и Width(ширина пера).
            var pen = new Pen(Color.Black, 2);

            // Рисует прямоугольник, который определен парой координат, шириной и высотой.
            graphics.DrawRectangle(pen, e.X, e.Y, 2, 2); 
        }

        private void DrawCircle_Click(object sender, EventArgs e)
        {
            var radius = (int)(CircleNumericUpDown.Value);
            Algorithms.Circle(_Xposition, _Yposition, radius, Handle);
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
