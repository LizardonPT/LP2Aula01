using System;
using System.Collections.Generic;

namespace CatSimulator
{
    public class Cat
    {
        public string Name { get; private set; }
        public int Energy { get; private set; }
        public Mood MoodStatus { get; private set; }
        public Feed FeedStatus { get; private set; }

        private Random random;

        private Cat()
        {
            random = new Random();
        }

        public Cat(string name, int energy, Mood moodStatus, Feed feedStatus) : this()
        {
            Name = name;
            Energy = energy;
            MoodStatus = moodStatus;
            FeedStatus = feedStatus;
        }

        public Cat(string name) : this()
        {
            Name = name;
            Energy = random.Next(1, 21);
            MoodStatus = (Mood)random.Next(0, Enum.GetNames(typeof(Mood)).Length);
            FeedStatus = (Feed)random.Next(0, Enum.GetNames(typeof(Feed)).Length);
        }
    }
}