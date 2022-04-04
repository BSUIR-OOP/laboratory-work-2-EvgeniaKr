using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class rectangle : polygon
    {
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
