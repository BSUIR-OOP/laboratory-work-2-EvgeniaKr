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
        public virtual int F { get { return FA; } set { FA = value; } }
        public virtual int T { get { return TA; } set { TA = value; } }
        public int kx { get { return x; } set { x = value; } }
        public int ky { get { return y; } set { y = value; } }

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
            Console.Write(": ");
            FA = int.Parse(Console.ReadLine());
            Console.Write(": ");
            TA = int.Parse(Console.ReadLine());
        }
    }
}
