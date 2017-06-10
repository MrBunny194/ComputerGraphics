using System.Collections.Generic;
using System.Drawing;

namespace PolygonalChain
{
    class MyBezierCurve
    {
        public static void Draw(List<Point> pointList, Graphics graphics)
        {
            float t, ax, ay, tau, sx, sy;
            int newX, newY;
            var oldX = pointList[0].X;
            var oldY = pointList[0].Y;
            var s = pointList.Count;
            
            for (t = 0; t < 0.5; t += 0.001f)
            {
                ax = 1.0f;
                ay = 1.0f;
                sx = pointList[0].X;
                sy = pointList[0].Y;
                tau = 1.0f;

                for (var i = 1; i < s; i++)
                {
                    tau = tau * (1 - t);
                    ax = ax * t * (s - i) / (i * (1 - t));
                    ay = ay * t * (s - i) / (i * (1 - t));
                    sx = sx + ax * pointList[i].X;
                    sy = sy + ay * pointList[i].Y;
                }

                newX = (int)(sx * tau);
                newY = (int)(sy * tau);
                graphics.DrawLine(new Pen(Color.Red, 3f), oldX, oldY, newX, newY);

                oldX = newX;
                oldY = newY;
            }
            
            oldX = pointList[s - 1].X;
            oldY = pointList[s - 1].Y;

            for (t = 1; t >= 0.5; t -= 0.001f)
            {
                sx = pointList[s - 1].X;
                sy = pointList[s - 1].Y;
                ax = 1.0f;
                ay = 1.0f;
                tau = 1.0f;

                for (var i = s - 2; i >= 0; i--)
                {
                    tau = tau * t;
                    ax = ax * (1 - t) * (i + 1) / ((s - 1 - i) * t);
                    ay = ax;
                    sx = sx + ax * pointList[i].X;
                    sy = sy + ay * pointList[i].Y;
                }

                newX = (int)(sx * tau);
                newY = (int)(sy * tau);
                graphics.DrawLine(new Pen(Color.Red, 3f), oldX, oldY, newX, newY);

                oldX = newX;
                oldY = newY;
            }
        }
    }
}