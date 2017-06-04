using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractals
{
    class Algoritms
    {
        public static void SierpinskiTriangle(Graphics graphics, int iter)
        {
            int N = 0;
            var r = new Random();

            var p = new Point[]
            {
                new Point(600, 10),
                new Point(300, 650),
                new Point(900, 650)
            };

            int i = r.Next(3);//берем случайную из трех

            Point newPt;
            Point pp = p[i];

            if (iter == 0 || iter < 0)
            {
                return;
            }

            do
            {
                graphics.DrawRectangle(new Pen(Color.Black), pp.X, pp.Y, 1, 1);
                i = r.Next(3);
                newPt = new Point((pp.X + p[i].X) / 2, (pp.Y + p[i].Y) / 2); // середина между двумя точками
                pp = newPt;
                N++;
            }
            while (N != iter);
        }

        public static void KochSnowflake(Graphics graphics, int iter)
        {
            var random = new Random();
            var point = new Point(10, 650);

            var N = 0;
            var rad = 1000;
            double x = 0, y = 0, p = 0, t = 0;

            if (iter == 0 || iter < 0)
            {
                return;
            }

            do
            {
                p = random.NextDouble(); // от 0 - 1
                t = x; // координата по x

                if (p <= 0.5) // типо середина
                {
                    x = 0.5 * x + 1 / (2 * Math.Pow(3, 0.5)) * y;
                    y = 1 / (2 * Math.Pow(3, 0.5)) * t - 0.5 * y;
                }
                else
                {
                    x = 0.5 * x - 1 / (2 * Math.Sqrt(3)) * y + 0.5;
                    y = -1 / (2 * Math.Sqrt(3)) * t - 0.5 * y + 1 / (2 * Math.Sqrt(3));
                }

                N++;
                graphics.DrawRectangle(new Pen(Color.Black), (float)(point.X + Math.Round(rad * x)), (float)(point.Y - Math.Round(rad * y)), 1, 1);

            } while (N != iter);
        }

        public static void CantorDust(Graphics graphics, int iter)
        {
            var point = new Point[]
            {
                new Point(50, 50),
                new Point(50, 900),
                new Point(900, 50),
                new Point(900, 900)
            };

            int N = 0;
            Point newPt;
            var random = new Random();
            var i = random.Next(4);
            var pp = point[i];

            if (iter == 0 || iter < 0)
            {
                return;
            }

            do
            {
                graphics.DrawRectangle(new Pen(Color.Black), pp.X, pp.Y, 1, 1);
                i = random.Next(4);
                newPt = new Point((pp.X + point[i].X) / 3, (pp.Y + point[i].Y) / 3);
                pp = newPt;
                N++;

            } while (N != iter);
        }

        public static void ListFern(Graphics graphics, int N)
        {
            var random = new Random();
            int W = 500; // зум 
            int kmax = 20; // четкость

            if (N == 0 || N < 0)
            {
                return;
            }

            for (int i = 0; i < N; i++)
            {
                float x = (float)(random.NextDouble() * 0.5);// рандом координат
                float y = (float)(random.NextDouble() * 0.5);

                double nx, ny;

                for (int k = 0; k < kmax; k++)
                {
                    double dice = random.NextDouble();

                    if (dice < 0.01)
                    {
                        nx = 0.0;
                        ny = 0.16 * y;
                    }
                    else if (dice < 0.86)
                    {
                        nx = 0.85 * x + 0.04 * y;
                        ny = -0.04 * x + 0.85 * y + 1.6;
                    }
                    else if (dice < 0.93)
                    {
                        nx = 0.2 * x - 0.26 * y;
                        ny = 0.23 * x + 0.22 * y + 1.6;
                    }
                    else
                    {
                        nx = -0.15 * x + 0.28 * y;
                        ny = 0.26 * x + 0.24 * y + 0.44;
                    }
                    
                    x = (float)nx;
                    y = (float)ny;
                }

                graphics.DrawRectangle(
                    new Pen(Color.Green), 
                    (float)(W - (5.0 - x) * W / 10.0), 
                    (float)((10.0 - y) * W / 10.0), 
                    0.5f, 
                    0.5f);
            }
        }

        public static void KamTorus(Graphics graphics, int iter, int Width, int Height)
        {
            long a, nx, ny;
            double an, can, san, can1, san1, ax, ay;
            double x, xa, x1, x2, x3, y, y1, y2, y3, rand1, rand2;

            // находим координаты середины окна
            nx = Width / 2;
            ny = Height / 2;

            // начальное значение. от куда начинаем
            ax = 600.0;
            ay = ax;

            // рандомим
            Random ran = new Random();
            rand1 = ran.Next(20000);
            rand2 = ran.Next(20000);
            rand1 = 50000 - 5 * rand1;
            rand2 = 50000 - 5 * rand2;
            //еще рандомим значения, чтобы увеличить шанс выпадения случайной величины
            an = 10.0 * (rand1 - rand2); // ищим разницу 

            // вычисление синусов и косинусов для поворотов
            can = 0.99 * Math.Cos(an);
            san = 0.99 * Math.Sin(an);
            can1 = 1.01 * Math.Cos(an);
            san1 = 1.01 * Math.Sin(an);

            //начальные значения относительно которых рисуем внешнее ядро
            x3 = 0.01;
            y3 = 0.01;

            if (iter == 0)
            {
                return;
            }

            do
            {
                //для внешней части
                xa = x3 * x3 - y3;
                x2 = x3 * can1 + xa * san1;
                y2 = x3 * san1 - xa * can1;
                x3 = x2;
                y3 = y2;
                x = x2;
                y = y2;
                a = 0;

                // внутренняя
                do
                {
                    // рисуем орбиту
                    // вычисляем координаты текущей точки
                    xa = x * x - y;
                    x1 = x * can + xa * san;
                    y1 = x * san - xa * can;
                    x = x1;
                    y = y1;
                    a++;

                    graphics.DrawLine(new Pen(Color.Black), (int)Math.Round(ax * x + nx), (int)Math.Round(ay * y + ny), (int)Math.Round(ax * x + nx) - 1, (int)Math.Round(ay * y + ny) + 1);

                } while ((Math.Abs(x1) <= iter * iter) && (Math.Abs(y1) <= iter * iter) && a <= iter); //разброс

            } while ((Math.Abs(x2) <= iter) && (Math.Abs(y2) <= iter)); // разброс

        }
    }
}
