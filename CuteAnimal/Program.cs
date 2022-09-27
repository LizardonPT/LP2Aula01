using System;

namespace CuteAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat c1 = new Cat("Randall", Mood.Grumpy, Feed.Starving);
            Cat c2 = new Cat("JoJo", Mood.HyperActive, Feed.Full);
            Cat c3 = new Cat("Timon", Mood.IgnoringYou, Feed.Satisfied);

            Console.WriteLine(c1.GetName());
            Console.WriteLine(c2.GetName());
            Console.WriteLine(c3.GetName());
        }
    }
}
