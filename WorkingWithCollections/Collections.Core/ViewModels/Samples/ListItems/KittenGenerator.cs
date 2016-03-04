using System;
using System.Collections.Generic;

namespace Collections.Core.ViewModels.Samples.ListItems
{
    public class KittenGenerator
    {
        private readonly List<string> _names = new List<string>
            {
                "Tiddles",
                "Amazon",
                "Pepsi",
                "Solomon",
                "Butler",
                "Snoopy",
                "Harry",
                "Holly",
                "Paws",
                "Polly",
                "Dixie",
                "Fern",
                "Cousteau",
                "Frankenstein",
                "Bazooka",
                "Casanova",
                "Fudge",
                "Comet"
            };

        private readonly Random _random = new Random();

        public Kitten CreateNewKitten()
        {
            int nextIndex = _random.Next(_names.Count);

            return new Kitten
            {
                Name = _names[nextIndex],
                NickName = string.Empty,
                ImageUrl = string.Format("http://loremflickr.com/100/100/cats?{0}", nextIndex)
            };
        }
    }
}