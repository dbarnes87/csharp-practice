using System;

namespace TernaryOperator
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            int temperature = -5;
            string stateOfMatter;

            if (temperature < 0)
            {
                stateOfMatter = "solid";
            }
            else
            {
                stateOfMatter = "liquid";
            }

            Console.WriteLine("State of matter is {0}", stateOfMatter);

            temperature += 200;

            //stateOfMatter = temperature < 0 ? "solid" : "liquid";

            stateOfMatter = temperature > 100 ? "gas" : temperature < 0 ? "solid" : "liquid";

            Console.WriteLine("State of matter is {0}", stateOfMatter);
            Console.ReadKey();

        }
    }
}
