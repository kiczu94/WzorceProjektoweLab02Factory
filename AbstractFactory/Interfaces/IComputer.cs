using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public interface IComputer
    {
        public string Name { get; set; }

        void ShowComputerName();
    }
}
