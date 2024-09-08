namespace Geometry
{
  class Calculator
  {
    public void rotatePoint(double pointX, double pointY, double centerX, double centerY, double rotation)
    {;
      var rad = degreesToRadians(rotation);
      var newX = (pointX-centerX)*Math.Cos(rad) - (pointY-centerY)*Math.Sin(rad) + centerX;
      var newY = (pointX-centerX)*Math.Sin(rad) + (pointY-centerY)*Math.Cos(rad) + centerY;
      Console.WriteLine("{0},{1}", newX, newY);
    }

    private double degreesToRadians(double rotation) {
      return rotation * (Math.PI/180);
    }

    static void Main(string[] _)
    {
      var calc = new Calculator();
      calc.rotatePoint(5,-1, 0,0, -90);
    }
  }
}
