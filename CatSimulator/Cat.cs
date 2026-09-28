using System;
using System.Collections.Generic;

namespace CatSimulator
{
    public class Cat
    {
        private string _name;
        private int _energy;
        private Mood _moodStatus;
        private Feed _feedStatus;

        private Random random;

        private Cat()
        {
            random = new Random();
        }

        public Cat(string name, int energy, Mood moodStatus, Feed feedStatus) : this()
        {
            _name = name;
            _energy = energy;
            _moodStatus = moodStatus;
            _feedStatus = feedStatus;
        }

        public Cat(string name) : this()
        {
            _name = name;
            _energy = random.Next(1, 21);
            _moodStatus = (Mood)random.Next(0, Enum.GetNames(typeof(Mood)).Length);
            _feedStatus = (Feed)random.Next(0, Enum.GetNames(typeof(Feed)).Length);
        }

        public string GetName() => _name;
        public int GetEnergy() => _energy;
        public Mood GetMoodStatus() => _moodStatus;
        public Feed GetFeedStatus() => _feedStatus;
    }
}