using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Line : Figure
    {
        private int x1, y1;
        private int x2, y2;
        private string namew;
        public int px1 { get { return x1; } set { x1 = value; } }
        public int px2 { get { return x2; } set { x2 = value; } }
        public int py1 { get { return y1; } set { y1 = value; } }
        public int py2 { get { return y2; } set { y2 = value; } }
        public Line(int x1, int y1, int x2, int y2, string namew)
        {
            
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.namew = namew;
        }
        

        public override string name() { return "Line"; }
        public override void printf()
        {
            Console.WriteLine(
                $"{name()} - {namew} : ({x1},{y1}),({x2},{y2})");
        }

        

    }
}
