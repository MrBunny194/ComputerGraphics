using System;
using System.Windows.Forms;

namespace Sets
{
    public partial class MyForm : Form
    {
        public MyForm()
        {
            InitializeComponent();
        }

        private void MyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(MyComboBox.SelectedItem.ToString() == "Julia set")
            {
                pictureBox.Image = JuliaSet.Draw(pictureBox, 2, -2, 2, -2);
            }
            if (MyComboBox.SelectedItem.ToString() == "Mandelbrot set")
            {
                pictureBox.Image = MandelbrotSet.Draw(pictureBox, 1, -2, 1, -1);
            }
        }
    }
}