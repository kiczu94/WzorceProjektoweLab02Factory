using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Lg
{
    public class LgTablet : ITablet
    {
        private string _name;
        public string Name { get => _name; set => _name = value; }

        public LgTablet(string name)
        {
            _name = name;
        }

        public void ShowTabletName()
        {
            Console.WriteLine($"My name is {Name}");
        }
    }
}
