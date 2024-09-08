using System.Numerics;
using Xunit;

namespace Geometry.UnitTests
{
    public class Geometry_rotatePointShould
    {
        [Fact]
        public void RotatePoint_Works()
        {
            var point = new Vector2(5,-1);
            var center =  new Vector2(0,0);
            var rotation = -90;


            var calc = new Calculator();
            var rotationRadians = calc.DegreesToRadians(rotation);
            var rotatedPoint = calc.RotatePoint(point, center, rotationRadians);
            Assert.Equal(rotatedPoint, new Vector2());
        }
    }
}
