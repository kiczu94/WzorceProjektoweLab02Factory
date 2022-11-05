using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Lg
{
    public class LgSmartphone:ISmartphone
    {
        private string _name;
        public string Name { get => _name; set => _name = value; }

        public LgSmartphone(string name)
        {
            _name = name;
        }

        public void ShowSmartphoneName()
        {
            Console.WriteLine($"My name is {Name}");
        }
    }
}
