using System;
using ShapesLibrary;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Ring ring = new Ring(new Point(5, 5), 20, 15);
            Console.WriteLine(ring);

            Console.ReadKey();
        }
    }
}
