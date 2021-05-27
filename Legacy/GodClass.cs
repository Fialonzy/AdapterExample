using System;
using System.Collections.Generic;

namespace AdapterExample.Legacy
{
	public class GodClass
	{
		private List<IFigure> _figures = new List<IFigure>();

		public void AddFigure(IFigure newFigure){
			if(newFigure == null) throw new ArgumentNullException(nameof(newFigure));
			if(_figures == null) throw new NullReferenceException();
			
			_figures.Add(newFigure);
		}

		public void GetFiguresInfo()
		{
			if(_figures == null) throw new NullReferenceException();
			
			foreach (var figure in _figures)
			{
				System.Console.WriteLine($"Figure -- {figure.GetName()}; Area: {figure.GetArea()}; Edges: {figure.GetCountEdges()}");
			}
		}
	}
}