using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CuteAnimal
{
    public class Cat
    {
        public string Name {get; }
        private int energy;
        private Mood mood;
        private Feed feed;
        private Random rng;

        private Cat()
        {
            rng = new Random();
            energy = rng.Next(101);
        }
        
        public Cat(string name, Mood mood, Feed feed) : this()
        {
            Name = name;
            this.mood = mood;
            this.feed = feed;
        }

        public Cat(string name) : this(name, Mood.Happy, Feed.AboutToExplode)
        {
            
        }
    }
}