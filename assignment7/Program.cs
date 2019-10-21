using System;

namespace assignment7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                write a program to implement Bubble sorting 
                on set of numbers and print the generated sorted list
            */
            int[] lists = { 3, 0, 2, 5, -1, 4, 1 };
            int t;

            Console.WriteLine("Initial Array: ");
            foreach (var list in lists)
            {
                Console.Write($"{list}  ");
            }
            Console.WriteLine();

            for (int p = 0; p <= lists.Length - 2; p++)
            {
                for (int i = 0; i <= lists.Length - 2; i++)
                {
                    if (lists[i] > lists[i + 1])
                    {
                        t = lists[i + 1];
                        lists[i + 1] = lists[i];
                        lists[i] = t;
                    }
                }
            }
            Console.WriteLine("Sorted array: ");
            foreach (var list in lists)
            {
                Console.Write($"{list}  ");
            }
            Console.WriteLine();
        }
    }
}
