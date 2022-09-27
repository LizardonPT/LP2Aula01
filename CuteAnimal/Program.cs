using System;

namespace CuteAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat c1 = new Cat("Randall", Mood.Grumpy, Feed.Starving);
            Cat c2 = new Cat("JoJo", Mood.HyperActive, Feed.Full);
        }
    }
}
