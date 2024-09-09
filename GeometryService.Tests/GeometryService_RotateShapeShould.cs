using Geometry.Services;
using System.Numerics;

namespace Geometry.UnitTests.Services
{
    public class GeometryService_RotateShapeShould
    {
        [Theory]
        [MemberData(nameof(TestData))]
        public void RotateShape_ShouldWork(
            Shape shape, Vector2 center, float rotation, Shape expectedShape)
        {
            var geometryService = new GeometryService();
            var rotationRadians = geometryService.DegreesToRadians(rotation);
            var rotatedShape = geometryService.RotateShape(shape, center, rotationRadians);

            for (int i=0; i<rotatedShape.points.Count(); i++) {
                Assert.Equal(expectedShape.points[i].X, rotatedShape.points[i].X, 4);
                Assert.Equal(expectedShape.points[i].Y, rotatedShape.points[i].Y, 4);
            }
        }

        public static IEnumerable<object[]> TestData =>
            new List<object[]>
            {
                new object[] {
                    new Shape([
                        new Vector2(4,5),
                        new Vector2(4,2),
                        new Vector2(6,4),
                ]),
                new Vector2(10,4),
                90,
                new Shape([
                        new Vector2(9,-2),
                        new Vector2(12,-2),
                        new Vector2(10,0),
                ])},
                
                new object[] {
                    new Shape([
                        new Vector2(4,5),
                        new Vector2(4,2),
                        new Vector2(6,2),
                        new Vector2(6,5),
                ]),
                new Vector2(10,4),
                90,
                new Shape([
                        new Vector2(9,-2),
                        new Vector2(12,-2),
                        new Vector2(12,-2),
                        new Vector2(12,0),
                ])},
            };
    }
}
