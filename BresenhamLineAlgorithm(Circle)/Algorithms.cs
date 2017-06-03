using System;
using System.Drawing;

namespace BresenhamLineAlgorithm_Circle_
{
    class Algorithms 
    {
        public static void Circle(int x1, int y1, int R, IntPtr Handle)
        {
            var graphics = Graphics.FromHwnd(Handle);
            var pen = new Pen(Color.Black, 2);

            // координаты начальной точки (0,R)
            var x = 0; // центр
            var y = R; // точка с которой начинаем рисовать
            var d = 1 - R; // какой пиксель закрасить 
            
            // шаги
            var delta1 = 3;  // f(x+a,y+b)
            var delta2 = -2 * R + 5; //f(y+b,x+a)

            while (x < y)
            {
                if (d < 0) // рисуем ниже линии с шагом delta1
                {
                    d += delta1;
                    delta1 += 2;  // шаг
                    delta2 += 2;
                    x++;
                }
                else // выше delta 2
                {
                    d += delta2;
                    delta2 += 4;
                    delta1 += 2;
                    x++;
                    y--;
                }

                graphics.DrawRectangle(pen, x1 - x, y1 - y, 1, 1); // 1
                graphics.DrawRectangle(pen, x1 + x, y1 - y, 1, 1); // 2
                graphics.DrawRectangle(pen, x1 + y, y1 - x, 1, 1); // 3
                graphics.DrawRectangle(pen, x1 + y, y1 + x, 1, 1); // 4
                graphics.DrawRectangle(pen, x1 + x, y1 + y, 1, 1); // 5
                graphics.DrawRectangle(pen, x1 - x, y1 + y, 1, 1); // 6
                graphics.DrawRectangle(pen, x1 - y, y1 + x, 1, 1); // 7
                graphics.DrawRectangle(pen, x1 - y, y1 - x, 1, 1); // 8
            }
        }

        public static void Ellipse(int x1, int y1, int a, int b, IntPtr Handle)
        {
            if (a == b)
            {
                Circle(x1, y1, a, Handle);
                return;
            }

            var graphics = Graphics.FromHwnd(Handle);
            var pen = new Pen(Color.Black, 2);

            // координаты начальной точки (0,b)
            int x = 0;
            int y = b;
            int d = (4 * b * b) + ((a * a) * (1 - (4 * b)));// какой пиксель закрасить 
            
            // шаги
            int delta1 = 12 * b * b;
            int delta2 = (12 * b * b) + (8 * a * a) - (8 * a * a * b);
            
            // while 1
            while ((a * a * y) > (b * b * x))
            {
                if (d < 0)
                {
                    d = d + delta1;
                    delta1 = delta1 + (8 * b * b);
                    delta2 = delta2 + (8 * b * b);
                    x++;
                }
                else
                {
                    d = d + delta2;
                    delta1 = delta1 + (8 * b * b);
                    delta2 = delta2 + 8 * ((b * b) + (a * a));
                    x++;
                    y--;
                }

                graphics.DrawRectangle(pen, x1 + x, y1 + y, 1, 1);
                graphics.DrawRectangle(pen, x1 + x, y1 - y, 1, 1);
                graphics.DrawRectangle(pen, x1 - x, y1 - y, 1, 1);
                graphics.DrawRectangle(pen, x1 - x, y1 + y, 1, 1);
            }
            
            delta1 = ((8 * b * b) * (1 + x)) + ((4 * a * a) * (3 - 2 * y)); // шаги
            delta2 = (4 * a * a) * (3 - (2 * y));
            
            // while 2
            while (y >= 0)
            {
                if (d < 0)
                {
                    d = d + delta1;
                    delta1 = delta1 + (8 * a * a);
                    delta2 = delta2 + (8 * a * a);
                    y--;
                    x++;
                }
                else
                {
                    d = d + delta2;
                    delta1 = delta1 + (8 * (a * a + b * b));
                    delta2 = delta2 + (8 * a * a);
                    y--;
                }
                graphics.DrawRectangle(pen, x1 + x, y1 + y, 1, 1);
                graphics.DrawRectangle(pen, x1 + x, y1 - y, 1, 1);
                graphics.DrawRectangle(pen, x1 - x, y1 - y, 1, 1);
                graphics.DrawRectangle(pen, x1 - x, y1 + y, 1, 1);
            }
        }
    }
}
