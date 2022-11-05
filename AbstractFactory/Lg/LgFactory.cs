using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Lg
{
    public class LgFactory : IAbstractFactory
    {
        private string _factoryName;
        public string FactoryName { get => _factoryName; set => _factoryName = value; }

        public LgFactory()
        {
            _factoryName = "Lg";
        }
        public IComputer CreateComputer()
        {
            return new LgComputer("Lg Computer");
        }

        public ISmartphone CreateSmartphone()
        {
            return new LgSmartphone("Lg Smartphone");
        }

        public ITablet CreateTablet()
        {
            return new LgTablet("Lg Tablet");
        }

        public ITv CreateTV()
        {
            return new LgTv("Lg Tv");
        }

        public void ShowFactoryName()
        {
            Console.WriteLine($"My factory name is {FactoryName}");
        }
    }
}
