using System;

namespace PropertiesC
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Box box = new Box(5, 4, 10);
            Console.WriteLine("Volume is {0}", box.Volume);
            Console.WriteLine("Front surface is {0}", box.FrontSurface);

            box.displayInfo();

        }
    }
}
