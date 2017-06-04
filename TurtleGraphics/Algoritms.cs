using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurtleGraphics
{
    class Algoritms
    {
        public static void KochSnowflake(int n, double step, Turtle turtle)
        {
            if (n == 0)
            {
                turtle.GoForward(step);
                return;
            }

            KochSnowflake(n - 1, step, turtle);
            turtle.TurnLeft(60.0);
            KochSnowflake(n - 1, step, turtle);
            turtle.TurnLeft(-120.0);
            KochSnowflake(n - 1, step, turtle);
            turtle.TurnLeft(60.0);
            KochSnowflake(n - 1, step, turtle);
        }

        public static  void SierpinskiTriangle(Turtle turtle, int order, double size)
        {
            if (order == 0)
            {

                turtle.GoForward(size);
                turtle.TurnLeft(120);
                turtle.GoForward(size);
                turtle.TurnLeft(120);
                turtle.GoForward(size);
                turtle.TurnLeft(120);
            }
            else
            {
                SierpinskiTriangle(turtle, order - 1, size / 2);
                turtle.GoForward(size / 2);
                SierpinskiTriangle(turtle, order - 1, size / 2);
                turtle.GoForward(size / 2);
                turtle.TurnLeft(120);
                turtle.GoForward(size);
                turtle.TurnLeft(120);
                turtle.GoForward(size / 2);
                turtle.TurnLeft(120);
                SierpinskiTriangle(turtle, order - 1, size / 2);
                turtle.TurnRight(120);
                turtle.GoForward(size / 2);
                turtle.TurnLeft(120);
            }
        }

        public static void Rosetta(Turtle turtle, int n)
        {
            for (var j = 0; j < 20; j++)
            {
                for (var i = 0; i < n; i++)
                {
                    turtle.GoForward(600 / n);
                    turtle.TurnLeft(360 / n);
                }

                turtle.TurnLeft(123);
            }
        }
        
        public static void HilbertCurve(Turtle turtle, int n)
        {
            if (n == 0)
            {
                return;
            }

            turtle.TurnLeft(90);
            Treblih(turtle, n - 1);
            turtle.GoForward(10.0);
            turtle.TurnLeft(-90);
            HilbertCurve(turtle, n - 1);
            turtle.GoForward(10.0);
            HilbertCurve(turtle, n - 1);
            turtle.TurnLeft(-90);
            turtle.GoForward(10.0);
            Treblih(turtle, n - 1);
            turtle.TurnLeft(90);
        }

        private static void Treblih(Turtle turtle, int n)
        {
            if (n == 0)
            {
                return;
            }
           
            turtle.TurnLeft(-90);
            HilbertCurve(turtle, n - 1);
            turtle.GoForward(10.0);
            turtle.TurnLeft(90);
            Treblih(turtle, n - 1);
            turtle.GoForward(10.0);
            Treblih(turtle, n - 1);
            turtle.TurnLeft(90);
            turtle.GoForward(10.0);
            HilbertCurve(turtle, n - 1);
            turtle.TurnLeft(-90);
        }
    }
}
