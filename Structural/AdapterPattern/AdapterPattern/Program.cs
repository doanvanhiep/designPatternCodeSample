using AdapterPattern.Adaptee;
using AdapterPattern.Interface;
using System.Collections.Generic;

namespace AdapterPattern
{
    class Program
    {
        //Legacy is adaptee
        static void Main(string[] args) 
        {
            List<IShape> shaps = new List<IShape>() { new LineAdapter(new LegacyLine()), new RectangleAdapter(new LegacyRectangle()) };
            int x1 = 5, y1 = 10, x2 = -3, y2 = 2;
            shaps.ForEach(shape => shape.Draw(x1,x2,y1,y2));
        }
    }
}
