using System.Numerics;

namespace Geometry
{
  class Calculator
  {
    public void rotatePoint(Vector2 point, Vector2 center, double rotationRadians)
    {
      var newX = (point.X - center.X)*Math.Cos(rotationRadians) - (point.Y-center.Y)*Math.Sin(rotationRadians) + center.X;
      var newY = (point.X-center.X)*Math.Sin(rotationRadians) + (point.Y-center.Y)*Math.Cos(rotationRadians) + center.Y;
      Console.WriteLine("{0},{1}", newX, newY);
    }

    private double degreesToRadians(double rotation) {
      return rotation * (Math.PI/180);
    }

    static void Main(string[] _)
    {
      var point = new Vector2(5,-1);
      var center =  new Vector2(0,0);
      var rotation = -90;


      var calc = new Calculator();
      calc.rotatePoint(point, center, calc.degreesToRadians(rotation));
    }
  }
}
