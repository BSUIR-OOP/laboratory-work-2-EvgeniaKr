using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class circle : ellips
    {
        public int radius { get { return FA; } set { FA = value; TA = value; } }

        public circle(int x1, int y1, int r) : base(x1, y1, r, r)
        {
        }
        public circle() : base()
        {
        }

        public override string name() { return "circle"; }
        public override void printf()
        {
            Console.WriteLine(
                $"{name()} ({x},{y},{radius})");
        }
        public override void coor()
        {
            Console.Write("x: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("y: ");
            y = int.Parse(Console.ReadLine());
            Console.Write("r: ");
            radius = int.Parse(Console.ReadLine());
        }
    }
}
