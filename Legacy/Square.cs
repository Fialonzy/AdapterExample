using System;

namespace AdapterExample.Legacy
{
    public class Square : IFigure
    {
        public double Width { get; private set; }

        public Square(double width, string name = null)
        {
            if(width <= 0) throw new ArgumentException("width cannot be less than or equal to 0",nameof(width));
            Width = width;
            _name = name;
        }
        public double GetArea()
        {
            return Width * Width;
        }

        public int GetCountEdges()
        {
            return 4;
        }

        public string GetName()
        {
            return "Square" + _name ?? "";
        }

        private string _name;
    }
}