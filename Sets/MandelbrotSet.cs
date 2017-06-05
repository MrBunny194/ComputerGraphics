using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sets
{
    class MandelbrotSet
    {
        public static Bitmap Draw(PictureBox pictureBox, double maxr, double minr, double maxi, double mini)
        {
            Bitmap img = new Bitmap(pictureBox.Width, pictureBox.Height);
            // Начальные значения для рисования множества
            double zx = 0;
            double zy = 0;
            double cx = 0;
            double cy = 0;
            // точка шага, на который будет изменяться наше множество.
            //(maxr - minr) масштаб 
            double xjump = ((maxr - minr) / Convert.ToDouble(img.Width));
            double yjump = ((maxi - mini) / Convert.ToDouble(img.Height));

            double tempzx = 0;
            int max = 1000;
            int go = 0;

            for (int x = 0; x < img.Width; x++)
            {
                // https://ru.wikipedia.org/wiki/Множество_Мандельброта#.D0.A0.D0.B0.D1.81.D1.88.D0.B8.D1.80.D0.B5.D0.BD.D0.BD.D0.BE.D0.B5_.D0.BE.D0.BF.D1.80.D0.B5.D0.B4.D0.B5.D0.BB.D0.B5.D0.BD.D0.B8.D0.B5
                // Расширенное определение.
                // Cчитаем значение последовательности в этой точке
                cx = (xjump * x) - Math.Abs(minr);

                for (int y = 0; y < img.Height; y++)
                {
                    zx = 0;
                    zy = 0;
                    cy = (yjump * y) - Math.Abs(mini); //  см. cx
                    go = 0;
                    // dk - размер орбиты |dk|^2 = zx * zx + zy * zy, если значениние  |dk|^2 >= 2 значит орбита взарвется и точки находятся вне этого множества
                    // число итераций время жизни орбиты
                    // c - значение(точка)
                    // z^2 + c.  cx - действительная часть с, cy - мнимая часть с.
                    while (zx * zx + zy * zy <= 4 && go < max)
                    {
                        go++;
                        tempzx = zx;
                        zx = (zx * zx) - (zy * zy) + cx; // вещественная  часть
                        zy = (2 * tempzx * zy) + cy; // мнимая часть
                    }

                    if (go != max)
                    {
                        img.SetPixel(x, y, Color.FromArgb(go % 128 * 2, go % 3 * 34, go % 2 * 66));
                    }
                    else
                    {
                        img.SetPixel(x, y, Color.FromArgb(255, 0, 0));
                    }
                }
            }
            return img;
        }
    }
}