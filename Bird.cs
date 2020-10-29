using System;
using System.Collections.Generic;
using System.Text;

namespace LSP
{
    public class Bird
    {
        protected string _birdName;
        public Bird(string birdName)
        {
            this._birdName = birdName;
        }
        public void Eat()
        {
            Console.WriteLine($"{_birdName} eats");
        }
    }
}
