using System.Numerics;

namespace Geometry.Services
{
    public class GeometryService
    {
        public Vector2 RotatePoint(Vector2 point, Vector2 center, double rotationRadians)
        {
            var newX = (point.X - center.X) * Math.Cos(rotationRadians) - (point.Y - center.Y) * Math.Sin(rotationRadians) + center.X;
            var newY = (point.X - center.X) * Math.Sin(rotationRadians) + (point.Y - center.Y) * Math.Cos(rotationRadians) + center.Y;
            return new Vector2((float)newX, (float)newY);
        }

        public double DegreesToRadians(double rotation)
        {
            return rotation * (Math.PI / 180);
        }
    }
}
