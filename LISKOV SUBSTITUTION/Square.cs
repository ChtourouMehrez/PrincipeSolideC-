using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISKOV_SUBSTITUTION
{
    public class Square : ShapeWithSurface
    {
        public int SideSize { get; set; }

        public override int GetSurface => SideSize * SideSize;

        public override void sayHello()
        {
            Console.WriteLine("Im Square");
        }
    }
}
