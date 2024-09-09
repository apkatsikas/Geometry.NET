using System.Security.Cryptography;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Geometry.Services;
using System.Numerics;

namespace Benchmarker
{
    public class RotatePointVsRotatePointDeux
    {
        private readonly float[] data;

        private readonly GeometryService geometryService = new GeometryService();

        public RotatePointVsRotatePointDeux()
        {
            var seed = 666; 
            Random random = new Random(seed);
            data = [
                random.Next(-100, 101), random.Next(-100, 101), 
                random.Next(-100, 101), random.Next(-100, 101), 
                random.Next(-7, 7)
            ];
        }

        [Benchmark]
        public Vector2 RotatePoint() => geometryService.RotatePoint( new Vector2(data[0],data[1]), new Vector2(data[2],data[3]), data[4] );

        [Benchmark]
        public Vector2 RotatePointDeux() => geometryService.RotatePointDeux( new Vector2(data[0],data[1]), new Vector2(data[2],data[3]), data[4] );
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<RotatePointVsRotatePointDeux>();
        }
    }
}
