using System;

namespace Classes___Basics
{
    class Program
    {
        static void Main(string[] args)
        {

            Human ross = new Human("Ross", "Geller", "brown", 35);
            ross.IntroduceMyself();

            Human rachel = new Human("Rachel", "Greene", "blue", 34);
            rachel.IntroduceMyself();

            Human emma = new Human("Emma", "Geller-Greene", 2);
            emma.IntroduceMyself();

            Human joey = new Human("Joey", "Tribianni");
            joey.IntroduceMyself();

            Human chandler = new Human("Chandler");
            chandler.IntroduceMyself();

            Human basicHuman = new Human();
            basicHuman.IntroduceMyself();

            Console.ReadKey();
        }
    }
}
