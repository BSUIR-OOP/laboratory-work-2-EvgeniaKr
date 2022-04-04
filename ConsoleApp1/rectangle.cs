using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class rectangle : polygon
    {
        public override int kx3 { get { return x3; } }
        public override int kx4 { get { return x4; } }
        public override int ky3 { get { return y3; } }
        public override int ky4 { get { return y4; } }
        public rectangle(int x1, int y1, int x2, int y2) : base(x1, y1, x1, y2, x2, y2, x2, y1)
        {

        }
        public rectangle() : base()
        {

        }
        public override string name() { return "rectangle"; }

        public override void printf()
        {
            Console.WriteLine(
                 $"{name()} ({this.x1},{this.y1}),({this.x2},{this.y2})");
        }

        public override void coor()
        {
            Console.Write("x1: ");
            x1 = int.Parse(Console.ReadLine());
            Console.Write("y1: ");
            y1 = int.Parse(Console.ReadLine());
            Console.Write("x2: ");
            x2 = int.Parse(Console.ReadLine());
            Console.Write("y2: ");
            y2 = int.Parse(Console.ReadLine());
        }
    }
}
