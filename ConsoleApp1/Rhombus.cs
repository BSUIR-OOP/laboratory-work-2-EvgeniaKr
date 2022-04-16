using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Rhombus : Polygon
    {
        public override int px4 { get { return x4; } }
        public override int py4 { get { return y4; } }
        public Rhombus(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4) : base(x1, y1, x2, y2, x3, y3, x4, y4)
        {
        }
        public Rhombus() : base()
        {
        }
        public override string name() { return "Rhombus"; }
    }
}
