using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fractals
{
    public partial class MyForm : Form
    {
        Graphics _graphics;

        public MyForm()
        {
            InitializeComponent();
            _graphics = Graphics.FromHwnd(Handle);
        }

        private void MyForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Refresh();
            }
        }

        private void MyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(MyComboBox.SelectedItem.ToString() == "Sierpinski triangle")
            {
                // http://www.fractalworld.xaoc.ru/Sierpinski_triangle
                Algoritms.SierpinskiTriangle(_graphics, (int)MyNumericUpDown.Value);
            }
            else if (MyComboBox.SelectedItem.ToString() == "Koch snowflake")
            { 
                // http://fractalworld.xaoc.ru/Koch_curve
                Algoritms.KochSnowflake(_graphics, (int)MyNumericUpDown.Value);
            }
            else if (MyComboBox.SelectedItem.ToString() == "Cantor dust")
            {
                Algoritms.CantorDust(_graphics, (int)MyNumericUpDown.Value);
            }
            else if (MyComboBox.SelectedItem.ToString() == "List fern")
            {
                // http://fractalworld.xaoc.ru/Fern
                Algoritms.ListFern(_graphics, (int)MyNumericUpDown.Value);
            }
            else if (MyComboBox.SelectedItem.ToString() == "Kam torus")
            {
                // http://www.opita.net/node/184
                Algoritms.KamTorus(_graphics, 36, this.Width, this.Height);
            }
        }
    }
}
