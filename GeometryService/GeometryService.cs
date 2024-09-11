using System.Drawing;
using System.Numerics;

namespace Geometry.Services
{
    public class Shape {
        public Vector2[] points;

        public Shape(Vector2[] points) {
            this.points = points;
        }
        public Shape() {

        }
        public bool Equals(Shape other)
        {
            var pointsCount = points.Count();
            var otherShapePointsCount = other.points.Count();

            if (pointsCount != otherShapePointsCount) {
                return false;
            }
            for (int i=0; i<pointsCount;i++) {
                var equal = Math.Abs(points[i].X - other.points[i].X) < 1e-4 
                    && Math.Abs(points[i].Y - other.points[i].Y) < 1e-4;
                if (!equal) {
                    return false;
                }
            }
            return true;
        }

        public override bool Equals(object? obj)
        {
            if (obj is Shape other)
            {
                return Equals(other);
            }
            return false;
        }

        public override int GetHashCode()
        {
            // Create a hash code by combining the hash codes of all points
            int hash = 19;
            foreach (var point in points)
            {
                hash = hash * 31 + point.GetHashCode();
            }
            return hash;
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
            var rotatedShape = new Shape();
            var pointsCount = shape.points.Count();
            rotatedShape.points = new Vector2[pointsCount];

            for (int i=0; i<pointsCount; i++) {
                var rotatedPoint = RotatePoint(shape.points[i], center, rotationRadians);
                rotatedShape.points[i] = rotatedPoint;
            }

            return rotatedShape;
        }

        public Vector2 RotatePointDeux(Vector2 point, Vector2 center, float rotationRadians)
        {
            var xDiffFromCenter = point.X - center.X;
            var yDiffFromCenter = point.Y - center.Y;

            var rotationCos = (float)Math.Cos(rotationRadians);
            var rotationSin = (float)Math.Sin(rotationRadians);

            var newX = (xDiffFromCenter * rotationCos) - (yDiffFromCenter * rotationSin) + center.X;
            var newY = (xDiffFromCenter * rotationSin) + (yDiffFromCenter * rotationCos) + center.Y;
            return new Vector2(newX, newY);
        }

        public float DegreesToRadians(float rotation)
        {
            return rotation * ((float)Math.PI / 180);
        }
    }
}
