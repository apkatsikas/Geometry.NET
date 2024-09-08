using Xunit;
using Geometry.Services;
using System.Numerics;

namespace Geometry.UnitTests.Services
{
    public class GeometryService_RotatePointShould
    {
        [Theory]
        [MemberData(nameof(TestData))]
        public void RotatePoint_ShouldWork(
            Vector2 point, Vector2 center, double rotation, Vector2 expectedPoint)
        {
            var geometryService = new GeometryService();
            var rotationRadians = geometryService.DegreesToRadians(rotation);
            var rotatedPoint = geometryService.RotatePoint(point, center, rotationRadians);
            Assert.Equal(expectedPoint, rotatedPoint);
        }

        public static IEnumerable<object[]> TestData =>
            new List<object[]>
            {
                new object[] { new Vector2(5,-1), new Vector2(0,0), -90, new Vector2(-1, -5) },
            };
    }
}
