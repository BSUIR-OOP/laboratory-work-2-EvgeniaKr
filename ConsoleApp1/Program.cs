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
            var figures = new List<Figure>();
            var figuresContainer = new List<Figure>();

            figuresContainer.Add(new Ellips());
            figuresContainer.Add(new Circle());
            figuresContainer.Add(new Polygon());
            figuresContainer.Add(new Line());            
            figuresContainer.Add(new Rectangle());
            figuresContainer.Add(new Rhombus());

            while (true)
            {
                Console.Clear();
                Console.WriteLine("A - Add figure");
                Console.WriteLine("P - Print figures");
                char key = char.Parse(Console.ReadLine());

                if (key == 'A')
                {
                    Console.Clear();
                    Console.WriteLine("1 - Ellips");
                    Console.WriteLine("2 - Circle");
                    Console.WriteLine("3 - Polygon");
                    Console.WriteLine("4 - Line");
                    Console.WriteLine("5 - Rectangle");
                    Console.WriteLine("6 - Rhombus");
                    Console.WriteLine("0 - Back\n");
                    
                    
                    int id = int.Parse(Console.ReadLine());
                    int i = 1;
                    foreach (var f in figuresContainer)
                    {
                        if (i == id)
                        {
                            Figure figure = f;
                            figure.coor();
                            figures.Add(figure);
                            break;

                        }
                        i++;
                    }
                }
                else if (key == 'P')
                {
                    Console.Clear();
                    foreach (var figure in figures)
                    {
                        Console.Write($"{figure.Id}: ");
                        figure.printf();
                    }
                    Console.ReadLine();
                }

            }
        }
              
    }
}
