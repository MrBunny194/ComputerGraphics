using System;
using System.Drawing;

namespace BresenhamLineAlgorithm
{
    class Bresenham
    {
        public static void DrawLine(Bitmap bitmap, int x1, int y1, int x2, int y2)
        { 
            // |x2 - x1| и |y2 -y1| - расстояние между центрамии первого и последнего пикселя
            // Подсчитывваем длины отрзка по осям координат
            var lengthX = Math.Abs(x2 - x1); 
            var lengthY = Math.Abs(y2 - y1);
            var length = Math.Max(lengthX, lengthY); // Выбираем большее из них
            
            //4)Вычислим изминения по осям x  и y ( как растет прямая снизу вверх или наоборот)
            var dx = (x2 - x1 >= 0 ? 1 : -1);
            var dy = (y2 - y1 >= 0 ? 1 : -1);
            
            // Если длина по y меньше или равна длины по x то рисуются только отрезки которые находятся 
            // под углом меньше 45 градусов в противном случае рисуются отрезки которые больше 45 градусов
            if (lengthY <= lengthX)
            {
                var x = x1; // Начальные точки
                var y = y1;
                var d = lengthX;

                while (Convert.ToBoolean(length--))
                {
                    bitmap.SetPixel(x, y, Color.Black); // закрашиваем пиксели с координатами
                    
                    x += dx; // координата по х увеличивается на 
                    d += 2 * lengthY;  // по y
                    
                    if (d > 0) //проверка  как  растет если  > 0 то по y  
                    {
                        d -= 2 * lengthX;
                        y += dy;
                    }
                }
            }
            else
            {
                var x = x1;
                var y = y1;
                var d = lengthY;

                while (Convert.ToBoolean(length--))
                {
                    bitmap.SetPixel(x, y, Color.Black);

                    y += dy;
                    d += 2 * lengthX;

                    if (d > 0)
                    {
                        d -= 2 * lengthY;
                        x += dx;
                    }
                }
            }
        }
    }
}
