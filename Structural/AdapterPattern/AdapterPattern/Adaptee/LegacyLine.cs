using System;

namespace AdapterPattern.Adaptee
{
    public class LegacyLine
    {
        public void Draw(int x1, int x2, int y1, int y2)
        {
            Console.WriteLine("Drawing line");
        }
    }
}
