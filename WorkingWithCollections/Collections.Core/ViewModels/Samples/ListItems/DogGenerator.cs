using System;
using System.Collections.Generic;

namespace Collections.Core.ViewModels.Samples.ListItems
{
    public class DogGenerator
    {
        private readonly List<string> _names = new List<string>
            {
                "Buddy",
                "Toby",
                "Ace",
                "AJ",
                "Max",
                "Aztec",
                "Jake",
                "Byron",
                "Axel",
                "Bentley",
                "Cooper",
                "Fuzzy",
                "Bandit",
                "Bear",
                "Charlie",
                "Duke",
                "Marley",
                "Rocky",
                "Shadow",
                "Biscuit",
                "Blaze",
                "Rocky",
                "Buzz",
                "Oreo",
                "Benji"
            };

        private readonly Random _random = new Random();

        public Dog CreateNewDog()
        {
            int nextIndex = _random.Next(_names.Count);

            return new Dog
            {
                Name = _names[nextIndex],
                ImageUrl = string.Format("http://loremflickr.com/100/100/dog?{0}", nextIndex)
            };
        }
    }
}