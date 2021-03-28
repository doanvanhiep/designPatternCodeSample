using AdapterPattern.Interface;
using System;

namespace AdapterPattern.Adaptee
{
    public class LineAdapter : IShape
    {
        readonly LegacyLine _legacyLine;
        public LineAdapter(LegacyLine legacyLine)
        {
            this._legacyLine = legacyLine;
        }
        public void Draw(int x1, int x2, int y1, int y2)
        {
            _legacyLine.Draw(x1, x2, y1, y2);
        }
    }
}
