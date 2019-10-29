using System;

namespace _07c__Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare 2d array
            string[,] matrix;

            // Declare 3d array
            int[,,] threeD;

            // 2d Array
            int[,] array2D = {

                {1,2,3},
                {4,5,6},
                {7,8,9}
            };

            Console.WriteLine("Central value is {0}", array2D[1,1]);
            Console.WriteLine("Bottom left value is {0}", array2D[2, 0]);

            string[,,] array3d = {
                {
                    {"000", "001" },
                    {"010", "011" },
                    {"Hi there", "Whats up" }
                },
                {
                    {"100", "101" },
                    {"110", "111" },
                    {"Another one", "Last entry" }
                }
            };

            Console.WriteLine("Central value is {0}", array3d[0, 2, 0]);

            string[,] array2DString =
                {
                    { "one", "two" },
                    { "three", "four" },
                    { "five", "six" }
            };

            array2DString[1, 1] = "chicken";

            int dimensions = array2DString.Rank;

            Console.WriteLine("New value is - {0}", array2DString[1, 1]);
            Console.WriteLine(dimensions);


        }
    }
}
