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
                    int figure = int.Parse(Console.ReadLine());
                    Add(figure, figures);
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
        static void Add(int id, List<Figure> figures)
        {
            switch (id)
            {
                // Back
                case 0:
                    break;
                case 1:
                    Figure figure = new Ellips();
                    figure.coor();
                    figures.Add(figure);
                    break;
                case 2:
                    figure = new Circle();
                    figure.coor();
                    figures.Add(figure);
                    break;
                case 3:
                    figure = new Polygon();
                    figure.coor();
                    figures.Add(figure);
                    break;
                case 4:
                    figure = new Line();
                    figure.coor();
                    figures.Add(figure);
                    break;
                case 5:
                    figure = new Rectangle();
                    figure.coor();
                    figures.Add(figure);
                    break;
                case 6:
                    figure = new Rhombus();
                    figure.coor();
                    figures.Add(figure);
                    break;  
                
            }
        }        
    }
}
