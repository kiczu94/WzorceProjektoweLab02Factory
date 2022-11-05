using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Apple
{
    public class AppleTv : ITv
    {
        private string _name;
        public string Name { get => _name; set => _name = value; }

        public AppleTv(string name)
        {
            _name = name;
        }

        public void ShowTvName()
        {
            Console.WriteLine($"My name is {Name}");
        }
    }
}
