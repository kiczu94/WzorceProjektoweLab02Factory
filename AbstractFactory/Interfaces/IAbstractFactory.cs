using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public interface IAbstractFactory
    {
        public string FactoryName { get; set; }
        public ITv CreateTV();
        public ISmartphone CreateSmartphone();
        public ITablet CreateTablet();
        public IComputer CreateComputer();

        void ShowFactoryName();
    }
}
