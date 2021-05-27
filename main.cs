using System;
using AdapterExample.Features;
using AdapterExample.Legacy;

class MainClass 
{
  public static void Main (string[] args) 
  {
    var god = new GodClass();
    god.AddFigure(new Square(10));
    god.AddFigure(new Circle(10));

    god.GetFiguresInfo();

    Console.WriteLine("Add outher class, sphere");

    god.AddFigure(new FigureAdapter(new Sphere(){Radius = 10}));
    god.GetFiguresInfo();

    Console.ReadLine();
  }
}