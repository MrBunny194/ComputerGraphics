using System.Collections.Generic;
using System.Drawing;

namespace B_spline
{
    class Spline
    {
        public static void Draw2nd(List<Point> pointList, Graphics graphics)
        {
            var counter = pointList.Count;
            int oldX, oldY, newX, newY;
            var i = 0;
            oldX = (pointList[i].X + pointList[i + 1].X) / 2;
            oldY = (pointList[i].Y + pointList[i + 1].Y) / 2;

            for (i = 0; i < counter - 2; i++)
            {
                for (var u = 0.0f; u < 1.0f; u += 0.1f)
                {
                    newX = (int)(0.5 * (1 - u) * (1 - u) * pointList[i].X + (0.75 - (u - 0.5) * (u - 0.5)) * pointList[i + 1].X + 0.5 * u * u * pointList[i + 2].X);
                    newY = (int)(0.5 * (1 - u) * (1 - u) * pointList[i].Y + (0.75 - (u - 0.5) * (u - 0.5)) * pointList[i + 1].Y + 0.5 * u * u * pointList[i + 2].Y);
                    graphics.DrawLine(new Pen(Color.Red, 2f), oldX, oldY, newX, newY);
                    oldX = newX;
                    oldY = newY;
                }
            }
        }

        public static void Draw3rd(List<Point> pointList, Graphics graphics)
        {
            int oldX , oldY , newX, newY;
            var counter = pointList.Count;
            var i = 0;
            oldX = (pointList[i].X + pointList[i + 1].X) /2;
            oldY = (pointList[i].Y + pointList[i + 1].Y )/2;
           
            for( i = 0; i < counter - 3; i++)
            {
                 for(var u = 0.0f; u < 1.0f; u+= 0.1f)
                 {
                     newX = (int)(pointList[i].X * (((1 - u) * (1 - u) * (1 - u)) / 6)
                            + pointList[i + 1].X * ((3 * u * u * u - 6 * u * u + 4) / 6)
                            + pointList[i + 2].X * ((-3 * u * u * u + 3 * u * u + 3 * u + 1) / 6)
                            + pointList[i + 3].X * ((u * u * u) / 6));
                    
                     newY = (int)(pointList[i].Y * (((1 - u) * (1 - u) * (1 - u)) / 6)
                            + pointList[i + 1].Y * ((3 * u * u * u - 6 * u * u + 4) / 6)
                            + pointList[i + 2].Y * ((-3 * u * u * u + 3 * u * u + 3 * u + 1) / 6)
                            + pointList[i + 3].Y * ((u * u * u) / 6));

                    graphics.DrawLine(new Pen(Color.Green, 2f), oldX, oldY, newX, newY);
                     oldX = newX;
                     oldY = newY;
                 }
            }
        }

        public static void Draw4th(List<Point> pointList, Graphics graphics)
        {
            int oldX, oldY, newX, newY;
            var counter = pointList.Count;
            var i = 0;
            oldX = (pointList[i].X + pointList[i + 1].X) / 2;
            oldY = (pointList[i].Y + pointList[i + 1].Y) / 2;

            for (i = 0; i < counter - 4; i++)
            {
                for (var u = 0.0f; u < 1.0f; u += 0.1f)
                {

                    newX = (int)(pointList[i].X * (1f - u) * (1f - u) * (1f - u) * (1f - u) / 24f + pointList[i + 1].X * ((u + 3f) * (1f - u) * (1f - u) * (1f - u) +
                        (2f - u) * (u + 2f) * (1f - u) * (1f - u) + (2f - u) * (2f - u) * (u + 1f) * (1f - u) + (2f - u) * (2f - u) * (2f - u) * u) / 24f + pointList[i + 2].X *
                        ((u + 2f) * (u + 2f) * (1f - u) * (1f - u) + (u + 2f) * (2f - u) * (u + 1f) * (1f - u) + (u + 2f) * (2f - u) * (2f - u) * u + (3f - u) * (u + 1f) * (u + 1f) * (1f - u) +
                        (3f - u) * (u + 1f) * (2f - u) * u + (3f - u) * (3f - u) * u * u) / 24f + pointList[i + 3].X * ((u + 1f) * (u + 1f) * (u + 1f) * (1f - u) + (u + 1f) * (u + 1f) * (2f - u) * u +
                        u * u * (3f - u) * (u + 1f) + (4f - u) * u * u * u) / 24f + pointList[i + 4].X * u * u * u * u / 24f);

                    newY = (int)(pointList[i].Y * (1f - u) * (1f - u) * (1f - u) * (1f - u) / 24f + pointList[i + 1].Y * ((u + 3f) * (1f - u) * (1f - u) * (1f - u) +
                        (2f - u) * (u + 2f) * (1f - u) * (1f - u) + (2f - u) * (2f - u) * (u + 1f) * (1f - u) + (2 - u) * (2 - u) * (2 - u) * u) / 24f + pointList[i + 2].Y *
                        ((u + 2f) * (u + 2f) * (1f - u) * (1f - u) + (u + 2f) * (2f - u) * (u + 1f) * (1f - u) + (u + 2f) * (2f - u) * (2f - u) * u + (3 - u) * (u + 1) * (u + 1) * (1 - u) +
                        (3 - u) * (u + 1) * (2 - u) * u + (3 - u) * (3 - u) * u * u) / 24f + pointList[i + 3].Y * ((u + 1) * (u + 1) * (u + 1) * (1 - u) + (u + 1) * (u + 1) * (2 - u) * u +
                        u * u * (3f - u) * (u + 1f) + (4f - u) * u * u * u) / 24f + pointList[i + 4].Y * u * u * u * u / 24f);

                    graphics.DrawLine(new Pen(Color.Blue, 2f), oldX, oldY, newX, newY);
                    oldX = newX;
                    oldY = newY;
                }
            }
        }
    }
}