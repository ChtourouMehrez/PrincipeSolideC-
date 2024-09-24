using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    public class SurfaceCalculator
    {
        public int ComputeAllSize(IEnumerable<Shape> shapes)
        {
            int result = 0;
            foreach (var shape in shapes)
            {
                //ancien code 
                //result += ComputeSize(shape);
                result += shape.Surface;
            }
            return result;
        }
        private int ComputeSize(Shape shape)
        {
            if (shape is Rectangle r)
            {
                return r.Width * r.Height;

            }
            else if (shape is Square s)
                return s.SideSize * s.SideSize;
            else
                throw new InvalidOperationException();

        }
        private int ComputeSizeWithSwitch(Shape shape)
        {
            return shape switch
            {
                Square s => s.SideSize * s.SideSize,
                Rectangle r => r.Height * r.Width,
                _ => throw new InvalidOperationException()
            };

        }
    }
}
