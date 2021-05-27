using System;

namespace AdapterExample.Legacy
{
    public class Circle : IFigure
    {
        public double Radius { get; private set; }

        public double Diameter => Radius * 2;

        public Circle(double radius, string name = null)
        {
            if(radius <= 0) throw new ArgumentException("Radius cannot be less than or equal to 0",nameof(radius));
            Radius = radius;
            _name = name;
        }

        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        public int GetCountEdges()
        {
            return 1;
        }

        public string GetName()
        {
            return "Circle" + _name ?? "";
        }

        private string _name;
    }
}