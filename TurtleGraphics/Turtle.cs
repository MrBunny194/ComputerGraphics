using System;
using System.Drawing;

namespace TurtleGraphics
{
    class Turtle
    {
        private double _x;
        private double _y;
        private double _angle;
        private Graphics _graph;

        public Turtle(double x0, double y0, double a0, Graphics graphics)
        {
            _x = x0;
            _y = y0;
            _angle = a0;
            _graph = graphics;
        }

        public void TurnLeft(double delta) => _angle += delta;
        
        public void TurnRight(double delta) => _angle -= delta;
        
        public void GoForward(double step)
        {
            var oldx = _x;
            var oldy = _y;

            _x += step * Math.Cos((Math.PI / 180) * _angle);
            _y += step * Math.Sin((Math.PI / 180) * _angle);

            _graph.DrawLine(
                new Pen(Color.Black), 
                new PointF((float)oldx, (float)oldy), 
                new PointF((float)_x, (float)_y));
        }
    }
}
