using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public interface ISmartphone
    {
        public string Name { get; set; }
        void ShowSmartphoneName();

    }
}
