using Xunit;
using Geometry.Services;
using System.Numerics;

namespace Geometry.UnitTests.Services
{
    public class GeometryService_RotatePointShould
    {
        [Fact]
        public void RotatePoint_ShouldWork()
        {
            var point = new Vector2(5,-1);
            var center =  new Vector2(0,0);
            var rotation = -90;
            var expectedPoint = new Vector2(-1, -5);


            var geometryService = new GeometryService();
            var rotationRadians = geometryService.DegreesToRadians(rotation);
            var rotatedPoint = geometryService.RotatePoint(point, center, rotationRadians);
            Assert.Equal(expectedPoint, rotatedPoint);
        }
    }
}
