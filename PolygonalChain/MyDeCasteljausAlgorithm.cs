using System.Collections.Generic;
using System.Drawing;

namespace PolygonalChain
{
    class MyDeCasteljausAlgorithm
    {
        public static void Draw(List<Point> pointList, Graphics graphics)
        {
            var n = pointList.Count;
            var RX = new float[n];
            var RY = new float[n];
            var QX = new float[n];
            var QY = new float[n];
            float PXnew, PYnew, PXold = pointList[0].X, PYold = pointList[0].Y;
            var count = n;

            for (var t = 0.0f; t < 1f; t += 0.01f)
            {
                n = count;

                for (int i = 0; i < count; i++)
                {
                    RX[i] = pointList[i].X;
                    RY[i] = pointList[i].Y;
                }

                while (n > 0)
                {
                    for (int j = 0; j < n - 1; j++)
                    {
                        QX[j] = RX[j] + t * (RX[j + 1] - RX[j]);
                        QY[j] = RY[j] + t * (RY[j + 1] - RY[j]);
                    }

                    n--;

                    for (int j = 0; j < n; j++)
                    {
                        RX[j] = QX[j];
                        RY[j] = QY[j];
                    }
                }

                PXnew = RX[0];
                PYnew = RY[0];

                graphics.DrawLine(new Pen(Color.Green, 3f), PXold, PYold, PXnew, PYnew);

                PXold = PXnew;
                PYold = PYnew;
            }
        }
    }
}