using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Apple
{
    public class AppleTablet: ITablet
    {
        private string _name;
        public string Name { get => _name; set => _name = value; }

        public AppleTablet(string name)
        {
            _name = name;
        }

        public void ShowTabletName()
        {
            Console.WriteLine($"My name is {Name}");
        }
    }
}
