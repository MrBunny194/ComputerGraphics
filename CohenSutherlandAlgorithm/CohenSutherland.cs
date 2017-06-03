using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CohenSutherlandAlgorithm
{
    class CohenSutherland
    {
        private static int _codeLeft = 1;      // 0001 (лево)
        private static int _codeRight = 2;     // 0010 (право)
        private static int _codeButtom = 4;    // 0100 (низ)
        private static int _codeTop = 8;       // 1000 (верх)

        // определяем где находится точка относительно прямоугольника
        private static int OutCode(int x, int y, int left, int right, int top, int buttom)
        {
            int code = 0;
            if (x < left) //x1
            {
                code |= _codeLeft;
            }
            if (x > right) //x2
            {
                code |= _codeRight;
            }
            if (y < top) //y1
            {
                code |= _codeTop;
            }
            if (y > buttom) //y2
            {
                code |= _codeButtom;
            }
            return code;
        }

        public static void Draw(int P1x, int P1y, int P2x, int P2y, int left, int right, int top, int buttom, Graphics graphics)
        {
            int c; // далее будем в нее сохранять С1 и перезаписывать в нее же с2
            
            // начало и конец отрзка с1 ----- с2
            var c1 = OutCode(P1x, P1y, left, right, top, buttom);
            var c2 = OutCode(P2x, P2y, left, right, top, buttom);

            // точка пересечения с прямоугольником 
            int px = 0;
            int py = 0; 

            while (c1 != 0 || c2 != 0) // если отрезок только не внутри и только не снаружи
            {
                if ((c1 & c2) != 0) // случай 1
                {
                    P1x = 0;
                    P1y = 0;
                    P2x = 0;
                    P2y = 0;
                    break;
                }

                c = c1;
                if (c1 == 0) // случай 2
                {
                    c = c2;
                }

                if ((c & _codeLeft) != 0) // 5
                {
                    px = left;
                    py = P1y + (int)(Convert.ToDouble(P2y - P1y) / (P2x - P1x) * (left - P1x));
                }
                else if ((c & _codeRight) != 0) // 4 
                {
                    px = right;
                    py = P1y + (int)(Convert.ToDouble(P2y - P1y) / (P2x - P1x) * (right - P1x));
                }
                else if ((c & _codeTop) != 0) // 6
                {
                    py = top;
                    px = P1x + (int)(Convert.ToDouble(P2x - P1x) / (P2y - P1y) * (top - P1y));
                }
                else if ((c & _codeButtom) != 0)  // 3
                {
                    py = buttom;
                    px = P1x + (int)(Convert.ToDouble(P2x - P1x) / (P2y - P1y) * (buttom - P1y));
                }

                if (c == c1)//  запоминаем координаты точки пересечения и еще раз проверяем внутри ли они нашего квадрата 
                {
                    P1x = px;
                    P1y = py;
                    c1 = OutCode(P1x, P1y, left, right, top, buttom); // обновляем код для c1
                }
                else
                {
                    P2x = px;
                    P2y = py;
                    c2 = OutCode(P2x, P2y, left, right, top, buttom); // обновляем код для с2
                }
            }

            var pen = new Pen(Color.Red, 3);
            graphics.DrawLine(pen, new Point(P1x, P1y), new Point(P2x, P2y));
        }
    }
}
