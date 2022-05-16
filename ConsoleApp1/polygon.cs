using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Polygon : Figure
    {
        private protected int x1, y1;
        private protected int x2, y2;
        private protected int x3, y3;
        private protected int x4, y4;
        private protected string namew;
        public int px1 { get { return x1; } set { x1 = value; } }
        public int px2 { get { return x2; } set { x2 = value; } }
        public virtual int px3 { get { return x3; } set { x3 = value; } }
        public virtual int px4 { get { return x4; } set { x4 = value; } }
        public int py1 { get { return y1; } set { y1 = value; } }
        public int py2 { get { return y2; } set { y2 = value; } }
        public virtual int py3 { get { return y3; } set { y3 = value; } }
        public virtual int py4 { get { return y4; } set { y4 = value; } }

        public Polygon(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4, string namew)
        {
            
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.x3 = x3;
            this.y3 = y3;
            this.x4 = x4;
            this.y4 = y4;
            this.namew = namew;
        }

      

        public override string name() { return "Polygon"; }
        public override void printf()
        {
            Console.WriteLine(
               $"{name()} - {namew} : ({x1},{y1}),({x2},{y2}),({x3},{y3}),({x4},{y4})");
        }

       
    }
}
