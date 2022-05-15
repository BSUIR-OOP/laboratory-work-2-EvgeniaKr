using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Program
    {
        

        static void Main()
        {
           
            Dictionary<string, CreateFigures> FigureDictionary = new Dictionary<string, CreateFigures>()
            {
                { "Ellips", new EllipsCreate("Ellips") },
                { "Circle", new CircleCreate("Circle") },
                { "Polygon", new PolygonCreate("Polygon") },
                { "Line", new LineCreate("Line") },
                { "Rectangle", new RectangleCreate("Rectangle") },
                { "Rhombus", new RhombusCreate("Rhombus") }

            };
            var figures = new List<Figure>();
            

            while (true)
            {
                Console.Clear();
                Console.WriteLine("A - Add figure");
                Console.WriteLine("P - Print figures");
                char key = char.Parse(Console.ReadLine());

                if (key == 'A')
                {
                    Console.Clear();
                    foreach (var f in FigureDictionary)
                    {
                        Console.WriteLine(f.Key+" - "+f.Key);
                    }
                    
                    Console.WriteLine("0 - Back\n");
                    
                    
                    string id = Console.ReadLine();
                    
                    foreach (var f in FigureDictionary)
                    {
                        if (id == f.Key)
                        {
                            CreateFigures figure = f.Value;
                            figures.Add(figure.Create());
                            break;

                        }
                        
                    }
                }
                else if (key == 'P')
                {
                    Console.Clear();
                    foreach (var figure in figures)
                    {
                      
                        figure.printf();
                    }
                    Console.ReadLine();
                }

            }
        }
              
    }
}
