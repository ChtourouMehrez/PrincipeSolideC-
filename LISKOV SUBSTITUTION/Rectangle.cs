using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISKOV_SUBSTITUTION
{
    public class Rectangle : ShapeWithSurface
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public override int GetSurface => Height * Width;

        public override void sayHello()
        {
            Console.WriteLine("Im Rectangle");
        }
    }
}
