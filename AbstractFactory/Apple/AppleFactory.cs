using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Apple
{
    public class AppleFactory : IAbstractFactory
    {
        private string _factoryName;
        public string FactoryName { get => _factoryName; set => _factoryName = value; }

        public AppleFactory()
        {
            _factoryName = "Apple";
        }
        public IComputer CreateComputer()
        {
            return new AppleComputer("Apple Computer");
        }

        public ISmartphone CreateSmartphone()
        {
            return new AppleSmartphone("Apple Smartphone");
        }

        public ITablet CreateTablet()
        {
            return new AppleTablet("Apple Tablet");
        }

        public ITv CreateTV()
        {
            return new AppleTv("Apple Tv");
        }

        public void ShowFactoryName()
        {
            Console.WriteLine($"My factory name is {FactoryName}");
        }
    }
}
