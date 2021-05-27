using AdapterExample.Legacy;

namespace AdapterExample.Features
{
    public class FigureAdapter : IFigure
    {
        private Sphere _sphere;

        public FigureAdapter(Sphere sphere)
        {
            _sphere = sphere;
        }

        public double GetArea()
        {
            return _sphere.Area;
        }

        public int GetCountEdges()
        {
            return 1;
        }

        public string GetName()
        {
            return "Shpere";
        }
    }
}