﻿using System.Numerics;

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
