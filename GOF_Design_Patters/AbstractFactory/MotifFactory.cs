using System;

namespace GOF_Design_Patters
{
    public class MotifFactory : WidgetFactory
    {
        public override void CreateScrollBar()
        {
            Console.WriteLine("Motif Scroller.");
        }

        public override void CreateWindow()
        {
            Console.WriteLine("Motif Window.");
        }
    }
}