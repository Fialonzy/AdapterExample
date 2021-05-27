using System;

namespace AdapterExample.Features
{
    public class Sphere
    {
        private double _diameter;
        private double _radius;

        public double Radius
        {
            get => _radius; set
            {
                if(value >= 0.0)
                {
                    _radius = value;
                    _diameter = 2 * _radius;
                }
            }
        }

        public double Diameter
        {
            get => _diameter; set
            {
                if (value >= 0.0)
                {
                    _diameter = value;
                    _radius = _diameter / 2.0;
                }
            }
        }

        public double Volume => 4.0 * Math.PI * _radius * _radius * _radius / 3.0 ;

        public double Area => 4.0 * Math.PI * _radius * _radius;
    }
}