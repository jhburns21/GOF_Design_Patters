using GOF_Design_Patters.AbstractFactory;
using System;

namespace GOF_Design_Patters
{
    class Program
    {
        static void Main(string[] args)
        {
            WidgetFactory factory;
            Console.WriteLine("Press p for PM or m for Motif");

            var data = Console.ReadKey(true);
            if (data.KeyChar == 'p')
                factory = new PMFactory();
            else if (data.KeyChar == 'm')
                factory = new MotifFactory();
            else
            {
                Console.WriteLine("Bad entry detected. Exiting...");
                return;
            }

            factory.CreateScrollBar();
            factory.CreateWindow();

            //Console.WriteLine("Press any key to end...");
            //Console.ReadKey(false);
        }
    }
}
