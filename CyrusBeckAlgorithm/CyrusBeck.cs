using System.Drawing;

namespace CyrusBeckAlgorithm
{
    class CyrusBeck
    {
        //(X1 * y2) - (Y1 *x2)
        private static int PsevdoScal(Point edge1, Point edge2) => (edge1.X * edge2.Y) - (edge1.Y * edge2.X);

        private static int Scal(int x0, int y0, int x1, int y1) => (x0 * x1) + (y0 * y1);
        
        private static Point Normalout(Point edge) => new Point(-edge.Y, edge.X);

        private static Point Normalin(Point edge) => new Point(edge.Y, -edge.X);


        public static void Draw(Graphics graphics, int[] x, int[] y, int i)
        {
            // концы отрезка
            var A = new Point(x[0], y[0]);
            var B = new Point(x[1], y[1]);

            // направляющий вектор АВ по формуле (x1 - x2, y1 - y2)
            var vecAB = new Point(B.X - A.X, B.Y - A.Y);

            // Точка входа прямой в многоугольник и точка выхода прямой из многоугольника
            // Точки пересечения ( первая = вход = 0, вторая = выход = 1)
            float tin = 0;
            float tout = 1;

            float d; // н.д.ф
            Point n; // Нормаль линия перпендикулярная поверхности 
            float thit; // н.д.ф
            bool clockwise = true;// определяем как идет обход по вершинам многоугольника: по часовой = true или против часовой = false стрелки

            //Псевдоскаляр позволяет узнать движение по векторам происходит по часовой стрелке или против, для этого мы берем первые 2 ребра многоугольника
            if (PsevdoScal(new Point(x[2] - x[3], y[2] - y[3]), new Point(x[4] - x[3], y[4] - y[3])) < 0)
            {
                clockwise = false;
            }

            // со 2 до предпоследней вершины 
            for (var j = 2; j < i - 1; j++)
            {
                //в зависимости от того, по часовой или против мы движемся, мы по-разному считаем нормаль. 
                if (!clockwise)
                {
                    n = Normalout(new Point(x[j + 1] - x[j], y[j + 1] - y[j]));
                }
                else
                {
                    n = Normalin(new Point(x[j + 1] - x[j], y[j + 1] - y[j]));
                }
                //см. лекцию. Деление скалярных произведений для того, чтобы найти момент времени, в который пересекается прямая с ребром многоугольника
                d = Scal(vecAB.X, vecAB.Y, n.X, n.Y);

                thit = (float)Scal(n.X, n.Y, x[j] - A.X, y[j] - A.Y) / d;

                // из скалярного произведения направляющего вектора отрезка и нормали ребра делаем вывод о том, 
                //что найденный момент времени соответсвует точки входа или выхода.
                //так как нам нужно найти макс. из т. входа и мин. из  т. выхода, меняем, если нужно,  соответвующие значения 
                //tin и tout
                if (d > 0 && thit > tin)
                {
                    tin = thit; // 
                }

                if (d < 0 && thit < tout)
                {
                    tout = thit; // 
                }
            }

            // так как мы прошлиись по всем ребрам многоугольника, кроме последнего 
            if (!clockwise)
            {
                n = Normalout(new Point(x[2] - x[i - 1], y[2] - y[i - 1]));
            }
            else
            {
                n = Normalin(new Point(x[2] - x[i - 1], y[2] - y[i - 1]));
            }

            d = Scal(vecAB.X, vecAB.Y, n.X, n.Y);

            thit = (float)Scal(n.X, n.Y, x[i - 1] - A.X, y[i - 1] - A.Y) / d;


            if (d > 0 && thit > tin)
            {
                tin = thit;
            }

            if (d < 0 && thit < tout)
            {
                tout = thit;
            }

            //если точка входа у нас появилась позже точки выхода, значит никакого  отрезка нет.
            if (tin > tout)
            {
                return;
            }
            

            if (tin < tout)
            {
                // т. пересечения
                var P1 = new Point(A.X + (int)((float)vecAB.X * tin), A.Y + (int)((float)vecAB.Y * tin));
                var P2 = new Point(A.X + (int)((float)vecAB.X * tout), A.Y + (int)((float)vecAB.Y * tout));
                graphics.DrawLine(new Pen(Color.Red, 4), P1.X, P1.Y, P2.X, P2.Y);
            }
        }
    }
}
