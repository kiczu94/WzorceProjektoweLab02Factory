using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public interface ITablet
    {
        public string Name { get; set; }

        void ShowTabletName();
    }
}
