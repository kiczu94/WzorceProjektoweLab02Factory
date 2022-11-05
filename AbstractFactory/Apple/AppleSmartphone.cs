using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Apple
{
    public class AppleSmartphone : ISmartphone
    {
        private string _name;
        public string Name { get => _name; set => _name = value; }

        public AppleSmartphone(string name)
        {
            _name = name;
        }

        public void ShowSmartphoneName()
        {
            Console.WriteLine($"My name is {Name}");
        }
    }
}
