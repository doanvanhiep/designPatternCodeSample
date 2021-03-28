using System;

namespace AdapterPattern.Adaptee
{
    public class LegacyRectangle
    {
        public void Draw(int x1, int y1, int w, int h)
        {
            Console.WriteLine("Drawing ractangle");
        }
    }
}
