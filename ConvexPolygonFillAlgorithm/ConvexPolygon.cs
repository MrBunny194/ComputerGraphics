using System.Drawing;

namespace ConvexPolygonFillAlgorithm
{
    class ConvexPolygon
    {
        private static int FindEdge(ref int i, int dir, int n, Point[] pon, Point[] _P)
        {
            for (;;)
            {
                int i1 = i + dir;
                if (i1 < 0)
                    i1 = n - 1;
                else
                    if (i1 >= n) i1 = 0;
                if (_P[i1].Y < _P[i].Y) return -1; // ребро [i,i1]  идет вверх
                else
                    if (_P[i1].Y == _P[i].Y) i = i1; // горизонтальное ребро
                else return i1; // ребро [i,i1]  идет вниз
            }
        }
        //*******************************************************************************
        public static void Fill(Point[] points, int c, Point[] _P, Graphics graphics)
        {
            int yMin = points[0].Y, yMax = points[0].Y, topPointIndex = 0;
            for (int i = 1; i < c; i++)
            {
                if (points[i].Y < points[topPointIndex].Y)
                {
                    topPointIndex = i;
                }
                else
                {
                    if (points[i].Y > yMax)
                    {
                        yMax = points[i].Y;
                    }
                }
            }
            yMin = points[topPointIndex].Y;

            if (yMin == yMax)
            {
                return;
            }

            int i1, i1next, i2, i2next;
            i1 = topPointIndex;
            i1next = FindEdge(ref i1, -1, c, points, _P);
            i2 = topPointIndex;
            i2next = FindEdge(ref i2, 1, c, points, _P);
            int x1, x2;

            for (int y = yMin; y <= yMax; y++)
            {
                x1 = points[i1].X + (y - points[i1].Y) * (points[i1next].X - points[i1].X) / (points[i1next].Y - points[i1].Y);
                x2 = points[i2].X + (y - points[i2].Y) * (points[i2next].X - points[i2].X) / (points[i2next].Y - points[i2].Y);

                graphics.DrawLine(new Pen(Color.Black), x1, y, x2, y);

                if (y + 1 == points[i1next].Y)
                {
                    i1 = i1next;
                    i1next = i1next - 1 < 0 ? c - 1 : i1next - 1;
                    if (points[i1].Y == points[i1next].Y)
                    {
                        break;
                    }
                }
                if (y + 1 == points[i2next].Y)
                {
                    i2 = i2next;
                    i2next = i2next + 1 >= c ? 0 : i2next + 1;
                    if (points[i2].Y == points[i2next].Y)
                    {
                        break;
                    }
                }
            }
        }
    }
}
