using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CuteAnimal
{
    public class Cat
    {
        private string name;
        private Mood mood;
        private Feed feed;

        public Cat(string name, Mood mood, Feed feed)
        {
            this.name = name;
            this.mood = mood;
            this.feed = feed;
        }
    }
}