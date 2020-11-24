using System;
using System.Collections.Generic;
using System.Text;

namespace GOF_Design_Patters.AbstractFactory
{
    public class PMFactory : WidgetFactory
    {
        public override void CreateScrollBar()
        {
            Console.WriteLine("PM Scrollbar");
        }

        public override void CreateWindow()
        {
            Console.WriteLine("PM Window");
        }
    }
}
