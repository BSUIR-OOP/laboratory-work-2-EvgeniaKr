using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class line : list
    {
        private int x1, y1;
        private int x2, y2;

        public line(int x1, int y1, int x2, int y2)
        {
            id = ++i;
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }
        public line()
        {
            id = ++i;
        }

        public override string name() { return "line"; }
        public override void printf()
        {
            Console.WriteLine(
                $"{name()} ({x1},{y1}),({x2},{y2})");
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
