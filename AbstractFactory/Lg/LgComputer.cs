using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Lg
{
    public class LgComputer:IComputer
    {
        private string _name;
        public string Name { get => _name; set => _name = value; }

        public LgComputer(string name)
        {
            _name = name;
        }

        public void ShowComputerName()
        {
            Console.WriteLine($"My name is {Name}");
        }
    }
}
