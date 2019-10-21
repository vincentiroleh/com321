using System;

namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
                Write a program to read the elements of a 2 by 3 matrices 
                as given by A =
             
                8          5           1
                7          2           6
            */
            int[,] intArray = new int [2, 3] 
            {
                {8, 5, 1},
                {7, 2, 6}
            };

            for (int i = 0; i < 2; i++)
            {
                for (int j =0; j < 3; j++) 
                {
                    Console.Write(intArray[i,j]+ "\t");
                }
                Console.WriteLine();
            }
            
        }
    }
}
