using AdapterPattern.Interface;
using System;

namespace AdapterPattern.Adaptee
{
    public class RectangleAdapter:IShape
    {
        readonly LegacyRectangle _legacyRectangle;
        public RectangleAdapter(LegacyRectangle legacyRectangle)
        {
            this._legacyRectangle = legacyRectangle;
        }
        public void Draw(int x1, int x2, int y1, int y2)
        {
            int x = Math.Min(x1, x2);
            int y = Math.Min(y1, y2);
            int w = Math.Abs(x2 - x1);
            int h = Math.Abs(y2 - y1);
            _legacyRectangle.Draw(x, y, w, h);
        }
    }
}
