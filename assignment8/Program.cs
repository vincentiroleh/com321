using System;
using System.Linq;

namespace assignment8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*write a program to determine the 
            smallest and the biggest number in a list of 15 number */

            int[] lists = { 19, 21, 30, 47, 50, 6, 17, 8, 9, 10, 11, 12, 13, 14, 15};

            int maximumNum = lists.Max();
            Console.WriteLine($" The maximum number from the list is {maximumNum}");

            int minimumNum = lists.Min();
            Console.WriteLine($" The minimum number from the list is {minimumNum}");
        }
    }
}
