using System;
using System.Collections.Generic;

namespace ClimbingStairsImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(ClimbingStairs.CalculateClimbingStairs(6));
        }
    }
    public static class ClimbingStairs
    {

        public static int CalculateClimbingStairs(int numberOfStairs)
        {
            if (numberOfStairs <= 0) return 0;
            List<int> numbers = new List<int> { 0, 1 };

            for (int i = 2; i < numberOfStairs + 2; i++)
                numbers.Add(numbers[i-1]+numbers[i-2]);
            return numbers[numberOfStairs + 1];

            // return 99;
            /*
             * 1 Stair = 1 possible way   (1)
             * 2 Stairs = 2 possible ways ( 1-1; 2; )
             * 3 Stairs = 3 possible ways ( 1-1-1; 2-1; 1-2; )
             * 4 Stairs = 5 possible ways ( 1-1-1-1; 2-2; 2-1-1; 1-1-2; 1-2-1; )
             * 5 Stairs = 8 possible ways ( 1-1-1-1-1; 2-1-1-1; 1-2-1-1; 1-1-2-1; 1-1-1-2; 1-2-2; 2-2-1; 2-1-2; )
             * 
             * Looks like every stair++ adds 2 number before. 5 Stairs = 5+3 ways = 8 ways
             * Hey, that also looks like the Fibonacci numbers?
             */




        }
    }
}
