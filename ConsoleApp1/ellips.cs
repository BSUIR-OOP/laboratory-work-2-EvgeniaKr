using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ellips : list
    {
        private protected int FA, TA;
        private protected int x, y;

        public ellips(int x1, int y1, int a1, int a2)
        {
            id = ++i;
            FA = a1;
            TA = a2;
            x = x1;
            y = y1;
        }

        public ellips()
        {
            id = ++i;
        }


        public override string name() { return "ellips"; }
        public override void printf()
        {
            Console.WriteLine(
                $"{name()} ({x},{y})({FA},{TA})");
        }
        public override void coor()
        {
            Console.Write("x: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("y: ");
            y = int.Parse(Console.ReadLine());
            Console.Write("a1: ");
            FA = int.Parse(Console.ReadLine());
            Console.Write("a2: ");
            TA = int.Parse(Console.ReadLine());
        }
    }
}
