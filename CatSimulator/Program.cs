using System;

namespace CatSimulator
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Cat cat1 = new Cat("Whiskers");
            Cat cat2 = new Cat("Mittens");

            Console.WriteLine($"Cat 1: {cat1.Name}, Energy: {cat1.Energy}, Mood: {cat1.MoodStatus}, Feed: {cat1.FeedStatus}");
            Console.WriteLine($"Cat 2: {cat2.Name}, Energy: {cat2.Energy}, Mood: {cat2.MoodStatus}, Feed: {cat2.FeedStatus}");

        }
    }
}
