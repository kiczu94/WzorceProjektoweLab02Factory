using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Samsung
{
    public class SamsungFactory : IAbstractFactory
    {
        private string _factoryName;
        public string FactoryName { get => _factoryName; set => _factoryName = value; }

        public SamsungFactory()
        {
            _factoryName = "Samsung";
        }
        public IComputer CreateComputer()
        {
            return new SamsungComputer("Samsung Computer");
        }

        public ISmartphone CreateSmartphone()
        {
            return new SamsungSmartphone("Samsung Smartphone");
        }

        public ITablet CreateTablet()
        {
            return new SamsungTablet("Samsung Tablet");
        }

        public ITv CreateTV()
        {
            return new SamsungTv("Samsung Tv");
        }

        public void ShowFactoryName()
        {
            Console.WriteLine($"My factory name is {FactoryName}");
        }
    }
}
