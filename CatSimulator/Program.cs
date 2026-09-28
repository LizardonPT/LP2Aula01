using System;

namespace CatSimulator
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Cat cat1 = new Cat("Whiskers");
            Cat cat2 = new Cat("Mittens");

            Console.WriteLine($"Cat 1: {cat1.GetName()}, Energy: {cat1.GetEnergy()}, Mood: {cat1.GetMoodStatus()}, Feed: {cat1.GetFeedStatus()}");
            Console.WriteLine($"Cat 2: {cat2.GetName()}, Energy: {cat2.GetEnergy()}, Mood: {cat2.GetMoodStatus()}, Feed: {cat2.GetFeedStatus()}");

        }
    }
}
