using System;
using System.Drawing;
using System.Windows.Forms;

namespace TurtleGraphics
{
    public partial class MyForm : Form
    {
        private Graphics _graphics;
       
        public MyForm()
        {
            InitializeComponent();
            _graphics = Graphics.FromHwnd(Handle);
        }

        private void MyForm_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                Refresh();
            }
        }

        private void MyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(MyComboBox.SelectedItem.ToString() == "Koch snowflake")
            {
                Algoritms.KochSnowflake(
                    (int)MynumericUpDown.Value,
                    1.0 / 3.0, 
                    new Turtle(800.0, 500.0, 180.0, _graphics));
            }
            else if(MyComboBox.SelectedItem.ToString() == "Sierpinski triangle")
            {
                Algoritms.SierpinskiTriangle(
                    new Turtle(800.0, 500.0, 180.0, _graphics), 
                    (int)MynumericUpDown.Value, 
                    500);
            }
            else if(MyComboBox.SelectedItem.ToString() == "Rosetta")
            {
                Algoritms.Rosetta(
                    new Turtle(500.0, 300.0, 180.0, _graphics), 
                    (int)MynumericUpDown.Value);
            }
            else if(MyComboBox.SelectedItem.ToString() == "Hilbert curve")
            {
                Algoritms.HilbertCurve(
                    new Turtle(800.0, 500.0, 180.0, _graphics), 
                    (int)MynumericUpDown.Value);
            }
        }
    }
}
