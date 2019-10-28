using System;

namespace AverageChallenge
{
    class MainClass

    {

        static double runningScoresTotal;

        public static void Main(string[] args)
        {

            int numCurrentScore = 0;
            int counter = 0;
            string currentScore = "";

            while (numCurrentScore != -1)
            {
                Console.WriteLine("Please enter a student score.");
                currentScore = Console.ReadLine();

                if (currentScore != "-1")
                {
                    numCurrentScore = int.Parse(currentScore);
                    runningScoresTotal += numCurrentScore;
                    counter++;
                    continue;
                }

                break;
            }

            double averageScore = runningScoresTotal / counter;

            Console.WriteLine(averageScore);




        }

        
    }
}
