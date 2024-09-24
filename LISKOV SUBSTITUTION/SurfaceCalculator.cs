using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISKOV_SUBSTITUTION
{
    public class SurfaceCalculator
    {
        public int ComputeAllSize(IEnumerable<ShapeWithSurface> shapes)
        {
            int result = 0;
            foreach (var shape in shapes)
            {
                //ancien code 
                //result += ComputeSize(shape);
                result += shape.GetSurface;
            }
            return result;
        }
        private int ComputeSize(ShapeWithSurface shape)
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
        private int ComputeSizeWithSwitch(ShapeWithSurface shape)
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
