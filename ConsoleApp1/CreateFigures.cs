using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
        internal abstract class CreateFigures
    {
        private string Name { get; set; }

        public CreateFigures(string name)
        {
            Name = name;
        }

        abstract public Figure Create();
    }
    internal class LineCreate : CreateFigures
    {
        public LineCreate(string name) : base(name)
        {
        }

        public override Figure Create()
        {
            Console.Write("Name: ");
            string n = Console.ReadLine();
            Console.Write("x1: ");
            int x1 = int.Parse(Console.ReadLine());
            Console.Write("y1: ");
            int y1 = int.Parse(Console.ReadLine());
            Console.Write("x2: ");
            int x2 = int.Parse(Console.ReadLine());
            Console.Write("y2: ");
            int y2 = int.Parse(Console.ReadLine());
            return new Line(x1,x2,y1,y2,n);
        }
    }
    internal class PolygonCreate : CreateFigures
    {
        public PolygonCreate(string name) : base(name)
        {
        }

        public override Figure Create()
        {
            Console.Write("Name: ");
            string n = Console.ReadLine();
            Console.Write("x1: ");
            int x1 = int.Parse(Console.ReadLine());
            Console.Write("y1: ");
            int y1 = int.Parse(Console.ReadLine());
            Console.Write("x2: ");
            int x2 = int.Parse(Console.ReadLine());
            Console.Write("y2: ");
            int y2 = int.Parse(Console.ReadLine());
            Console.Write("x3: ");
            int x3 = int.Parse(Console.ReadLine());
            Console.Write("y3: ");
            int y3 = int.Parse(Console.ReadLine());
            Console.Write("x4: ");
            int x4 = int.Parse(Console.ReadLine());
            Console.Write("y4: ");
            int y4 = int.Parse(Console.ReadLine());
            return new Polygon(x1,y1,x2,y2,x3,y3,x4,y4, n);
        }
    }
    internal class RectangleCreate : CreateFigures
    {
        public RectangleCreate(string name) : base(name)
        {
        }

        public override Figure Create()
        {
            Console.Write("Name: ");
            string n = Console.ReadLine();
            Console.Write("x1: ");
            int x1 = int.Parse(Console.ReadLine());
            Console.Write("y1: ");
            int y1 = int.Parse(Console.ReadLine());
            Console.Write("x2: ");
            int x2 = int.Parse(Console.ReadLine());
            Console.Write("y2: ");
            int y2 = int.Parse(Console.ReadLine());
            
            return new Rectangle(x1, y1, x2, y2, n);
        }
    }
    internal class RhombusCreate : CreateFigures
    {
        public RhombusCreate(string name) : base(name)
        {
        }

        public override Figure Create()
        {
            Console.Write("Name: ");
            string n = Console.ReadLine();
            Console.Write("x1: ");
            int x1 = int.Parse(Console.ReadLine());
            Console.Write("y1: ");
            int y1 = int.Parse(Console.ReadLine());
            Console.Write("x2: ");
            int x2 = int.Parse(Console.ReadLine());
            Console.Write("y2: ");
            int y2 = int.Parse(Console.ReadLine());
            Console.Write("x3: ");
            int x3 = int.Parse(Console.ReadLine());
            Console.Write("y3: ");
            int y3 = int.Parse(Console.ReadLine());
            Console.Write("x4: ");
            int x4 = int.Parse(Console.ReadLine());
            Console.Write("y4: ");
            int y4 = int.Parse(Console.ReadLine());
            return new Rhombus(x1, y1, x2, y2, x3, y3, x4, y4, n);
        }
    }
    internal class EllipsCreate : CreateFigures
    {
        public EllipsCreate(string name) : base(name)
        {
        }

        public override Figure Create()
        {
            Console.Write("Name: ");
            string n = Console.ReadLine();
            Console.Write("x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("y: ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("a1: ");
            int a1 = int.Parse(Console.ReadLine());
            Console.Write("a2: ");
            int a2 = int.Parse(Console.ReadLine());

            return new Ellips(x, y, a1, a2, n);
        }
    }
    internal class CircleCreate : CreateFigures
    {
        public CircleCreate(string name) : base(name)
        {
        }

        public override Figure Create()
        {
            Console.Write("Name: ");
            string n = Console.ReadLine();
            Console.Write("x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("y: ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("r: ");
            int r = int.Parse(Console.ReadLine());

            return new Circle(x, y, r, n);
        }
    }
}
