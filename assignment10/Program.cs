using System;
using System.Collections.Generic;

namespace assignment10
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              * Write a program to accept a set of 10 names from the keyboard 
                and then arrange the names alphabetically 
            */
            List<string> names = new List<string>();

            while (names.Count != 10)
            {
                Console.WriteLine("Enter names here: ");
                names.Add(Console.ReadLine());
            }


            names.Sort();
            Console.WriteLine("\nList of names after sorting: ");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }



        }
    }
}
