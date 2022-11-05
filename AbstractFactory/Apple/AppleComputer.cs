using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Apple
{
    class AppleComputer : IComputer
    {
        private string _name;
        public string Name { get => _name; set => _name=value; }

        public AppleComputer(string name)
        {
            _name = name;
        }

        public void ShowComputerName()
        {
            Console.WriteLine($"My name is {Name}");
        }
    }
}
