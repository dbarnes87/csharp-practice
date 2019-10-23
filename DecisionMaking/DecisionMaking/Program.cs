using System;

namespace DecisionMaking
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Whats the temperature like");

            string temperature = Console.ReadLine();
            int numTemp;
            int number;
            bool ifUserEnteredANumber = int.TryParse(temperature, out number);
            if (ifUserEnteredANumber)
            {
                numTemp = number;
            } else
            {
                numTemp = 0;
                Console.WriteLine("Value entered was not a number.  Temp set at 0.");

            }

            if (numTemp < 20)
            {
                Console.WriteLine("Take a coat");
            }
            else if (numTemp == 20)
            {
                Console.WriteLine("Pants and pullover is fine");
            }
            else if (numTemp >= 30)
            {
                Console.WriteLine("Its hot");
            }
            else
            {
                Console.WriteLine("Shorts are enough today");
            }

             
            Console.Read();
        }
    }
}
