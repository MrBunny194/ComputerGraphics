using System.Drawing;

namespace FillingTriangle
{
    class Triangle
    {
        private static void Swap<T>(ref T a, ref T b, ref T c, ref T d)
        {
            T temp;
            temp = a;
            a = b;
            b = temp;
            temp = c;
            c = d;
            d = temp;
        }

        public static void Fill(Graphics graphics, int[] X, int[] Y)
        {
            // координаты точки по y
            // ищем самую верхнюю точку (та у которой самый маленький Y)
            //определили какая точка выше, потом поменяли координаты этих точек
            //У(0) и У(1) это координата по У точки 0 и 1 соответственно. 
            // Если т. 0 больше, чем т.1 по У , то мы меняем координаты точек 0 и 1
            if (Y[0] > Y[1])
            {
                Swap(ref Y[0], ref Y[1], ref X[0], ref X[1]); // ищем самую верхнюю точку (та у которой самый маленький Y)
            }
            if (Y[1] > Y[2])
            {
                Swap(ref Y[1], ref Y[2], ref X[1], ref X[2]);
            }
            if (Y[0] > Y[1])
            {
                Swap(ref Y[0], ref Y[1], ref X[0], ref X[1]);
            }
            if ((Y[0] == Y[1]) && (Y[1] == Y[2]))
            {
                return;
            }

            for (var line = Y[0]; line < Y[1]; line++) // рисуем от низа  до середины
            {
                //проход с последующим закрашиванием У между точками 0 и 1
                // координаты отрезка, которым мы будем закрашивать линию. хе - начало, хб - конец
                var xb = X[1] + (line - Y[1]) * (X[0] - X[1]) / (Y[0] - Y[1]);
                var xa = X[2] + (line - Y[2]) * (X[0] - X[2]) / (Y[0] - Y[2]);
                graphics.DrawLine(new Pen(Color.Black, 1), xb, line, xa, line);
            }

            // 1 и 2 с середины до верху
            for (var line = Y[1]; line <= Y[2]; line++)
            {
                var xb = X[2] + (line - Y[2]) * (X[1] - X[2]) / (Y[1] - Y[2]);
                var xa = X[2] + (line - Y[2]) * (X[0] - X[2]) / (Y[0] - Y[2]);

                graphics.DrawLine(new Pen(Color.Black, 1), xb, line, xa, line);
            }
        }
    }
}
