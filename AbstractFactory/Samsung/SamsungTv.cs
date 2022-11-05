using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Samsung
{
    public class SamsungTv:ITv
    {
        private string _name;
        public string Name { get => _name; set => _name = value; }

        public SamsungTv(string name)
        {
            _name = name;
        }

        public void ShowTvName()
        {
            Console.WriteLine($"My name is {Name}");
        }
    }
}
