using System;
using System.Drawing;
using System.Windows.Forms;

namespace Sets
{
    class JuliaSet
    {
        public static Bitmap Draw(PictureBox pictureBox, double maxr, double minr, double maxi, double mini)
        {
            var bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            double zx = 0;
            double zy = 0;
            double cx = -0.7;
            double cy = 0;
            double xjump = ((maxr - minr) / Convert.ToDouble(bitmap.Width));
            double yjump = ((maxi - mini) / Convert.ToDouble(bitmap.Height));
            double tempzx = 0;
            int max = 300;
            int go = 0;

            for (var x = 0; x < bitmap.Width; x++)
            {
                for (var y = 0; y < bitmap.Height; y++)
                {
                    zx = (xjump * x) - Math.Abs(minr);
                    zy = (yjump * y) - Math.Abs(mini);
                    cy = -0.29;
                    go = 0;

                    while (zx * zx + zy * zy <= 4 && go < max)
                    {
                        go++;
                        tempzx = zx;
                        zx = (zx * zx) - (zy * zy) + cx;
                        zy = (2 * tempzx * zy) + cy;
                    }

                    if (go != max)
                    {
                        bitmap.SetPixel(x, y, Color.FromArgb(go % 128 * 2, go % 3 * 34, go % 2 * 66));
                    }
                    else
                    {
                        bitmap.SetPixel(x, y, Color.Red);
                    }
                }
            }
            return bitmap;
        }
    }
}