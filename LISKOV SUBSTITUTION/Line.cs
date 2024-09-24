using System;

namespace LISKOV_SUBSTITUTION
{
    public class Line : Shape
    {
        public override void sayHello()
        {
            Console.WriteLine("Im Line");
        }
    }
}
