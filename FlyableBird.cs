using System;

namespace LSP
{
    public class FlyableBird : Bird, IFlyableBird
    {
        public FlyableBird(string birdName)
       :base(birdName){}
        public void Fly()
        {
            Console.WriteLine($"{ _birdName } flys");
        }
    }
}
