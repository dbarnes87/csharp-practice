using System;

namespace TicTacToeClone
{
    class Program
    {
        static void Main(string[] args)
        {
            SetField();
        }

        public static void SetField()
        {
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", 1, 2, 3);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", 1, 2, 3);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", 1, 2, 3);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");



            Console.WriteLine("\nPlayer 1, please choose a field: ");
            string input = Console.ReadLine();
            int fieldChoice = int.Parse(input);

            Console.ReadKey();
        }
    }
}
