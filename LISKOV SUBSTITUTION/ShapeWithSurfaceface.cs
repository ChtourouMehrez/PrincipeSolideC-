using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISKOV_SUBSTITUTION
{
    public abstract class ShapeWithSurface : Shape
    {
        public abstract int GetSurface { get; }
    }
}
