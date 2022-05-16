using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Circle : Ellips
    {
        public int radius { get { return FA; } set { FA = value; TA = value; } }

        public Circle(int x1, int y1, int r, string namew) : base(x1, y1, r, r, namew)
        {
            
        }
        
        public override string name() { return "Circle"; }
        public override void printf()
        {
            Console.WriteLine(
                $"{name()}  - {namea} :({x},{y},{radius})");
        }
        
    }
}
