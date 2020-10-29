using System;

namespace LSP
{
    class Program
    {
        static void Main(string[] args)
        {

            var penguin = new Bird("Penguin");
            penguin.Eat();
            var pegin = new FlyableBird("Dove");
            pegin.Fly();
            pegin.Eat();
            Console.ReadLine();
        }
    }
}
