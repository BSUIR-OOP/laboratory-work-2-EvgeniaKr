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
            var list = new List<list>();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("A - Add figure");
                Console.WriteLine("P - Print figures");
                char key = char.Parse(Console.ReadLine());

                if (key == 'A')
                {
                    Console.Clear();
                    Console.WriteLine("1 - ellips");
                    Console.WriteLine("2 - circle");
                    Console.WriteLine("3 - polygon");
                    Console.WriteLine("4 - line");
                    Console.WriteLine("5 - rectangle");
                    Console.WriteLine("6 - reckv");
                    Console.WriteLine("0 - back\n");
                    int figure = int.Parse(Console.ReadLine());
                    Add(figure, list);
                }
                else if (key == 'P')
                {
                    Console.Clear();
                    foreach (var figure in list)
                    {
                        Console.Write($"{figure.Id}: ");
                        figure.printf();
                    }
                    Console.ReadLine();
                }

            }
        }
        static void Add(int id, List<list> list)
        {
            switch (id)
            {
                // Back
                case 0:
                    break;
                case 1:
                    list figure = new ellips();
                    figure.coor();
                    list.Add(figure);
                    break;
                case 2:
                    figure = new circle();
                    figure.coor();
                    list.Add(figure);
                    break;
                case 3:
                    figure = new polygon();
                    figure.coor();
                    list.Add(figure);
                    break;
                case 4:
                    figure = new line();
                    figure.coor();
                    list.Add(figure);
                    break;
                case 5:
                    figure = new rectangle();
                    figure.coor();
                    list.Add(figure);
                    break;
                case 6:
                    figure = new reckv();
                    figure.coor();
                    list.Add(figure);
                    break;  
                
            }
        }        
    }
}
