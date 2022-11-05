using AbstractFactory.Apple;
using AbstractFactory.Lg;
using AbstractFactory.Samsung;
using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateProduct("Apple", "Computer");
            CreateProduct("Samsung", "Computer");
            CreateProduct("Lg", "Computer");

            CreateProduct("Apple", "Tv");
            CreateProduct("Samsung", "Tv");
            CreateProduct("Lg", "Tv");

            CreateProduct("Apple", "Smartphone");
            CreateProduct("Samsung", "Smartphone");
            CreateProduct("Lg", "Smartphone");

            CreateProduct("Apple", "Tablet");
            CreateProduct("Samsung", "Tablet");
            CreateProduct("Lg", "Tablet");
        }

        public static void CreateProduct(string company, string product)
        {
            if (company == "Apple")
            {
                var factory = new AppleFactory();
                if (product == "Computer")
                {
                    factory.ShowFactoryName();
                    factory.CreateComputer().ShowComputerName();
                }
                if (product == "Tablet")
                {
                    factory.ShowFactoryName();
                    factory.CreateTablet().ShowTabletName();
                }
                if (product == "Smartphone")
                {
                    factory.ShowFactoryName();
                    factory.CreateSmartphone().ShowSmartphoneName();
                }
                if (product == "Tv")
                {
                    factory.ShowFactoryName();
                    factory.CreateTV().ShowTvName();
                }
            }
            if (company == "Samsung")
            {
                var factory = new SamsungFactory();
                if (product == "Computer")
                {
                    factory.ShowFactoryName();
                    factory.CreateComputer().ShowComputerName();
                }
                if (product == "Tablet")
                {
                    factory.ShowFactoryName();
                    factory.CreateTablet().ShowTabletName();
                }
                if (product == "Smartphone")
                {
                    factory.ShowFactoryName();
                    factory.CreateSmartphone().ShowSmartphoneName();
                }
                if (product == "Tv")
                {
                    factory.ShowFactoryName();
                    factory.CreateTV().ShowTvName();
                }
            }
            if (company == "Lg")
            {
                var factory = new LgFactory();
                if (product == "Computer")
                {
                    factory.ShowFactoryName();
                    factory.CreateComputer().ShowComputerName();
                }
                if (product == "Tablet")
                {
                    factory.ShowFactoryName();
                    factory.CreateTablet().ShowTabletName();
                }
                if (product == "Smartphone")
                {
                    factory.ShowFactoryName();
                    factory.CreateSmartphone().ShowSmartphoneName();
                }
                if (product == "Tv")
                {
                    factory.ShowFactoryName();
                    factory.CreateTV().ShowTvName();
                }
            }
        }
    }
}
