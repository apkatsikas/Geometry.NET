using System.Numerics;

namespace Geometry.Services
{
    public class Shape {
        public Vector2[] points;

        public Shape(Vector2[] points) {
            this.points = points;
        }
    }
    public class GeometryService
    {
        public Vector2 RotatePoint(Vector2 point, Vector2 center, float rotationRadians)
        {
            var newX = (point.X - center.X) * Math.Cos(rotationRadians) - (point.Y - center.Y) * Math.Sin(rotationRadians) + center.X;
            var newY = (point.X - center.X) * Math.Sin(rotationRadians) + (point.Y - center.Y) * Math.Cos(rotationRadians) + center.Y;
            return new Vector2((float)newX, (float)newY);
        }

        public Shape RotateShape(Shape shape, Vector2 center, float rotationRadians)
        {
            var rotatedShape = new Shape([]);
            foreach(var point in shape.points) {
                var rotatedPoint = RotatePoint(point, center, rotationRadians);
                rotatedShape.points.Append(rotatedPoint);
            }
            return rotatedShape;
        }

        public float DegreesToRadians(float rotation)
        {
            return rotation * ((float)Math.PI / 180);
        }
    }
}
