using System;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Write a program to compute the average salary of 10 staffs of a firm
            */

            // Declaring single dimensional array
            int[] Staffs = new int[10];
            Staffs[0] = 1000;
            Staffs[1] = 2000;
            Staffs[2] = 3000;
            Staffs[3] = 4000;
            Staffs[4] = 5000;
            Staffs[5] = 6000;
            Staffs[6] = 7000;
            Staffs[7] = 8000;
            Staffs[8] = 9000;
            Staffs[9] = 10000;

            int sum = 0; 
            
            foreach (var staff in Staffs)
            {                
                sum += staff;                
            }
            
            int averageSalary = sum / Staffs.Length;

            Console.WriteLine($"The average salary of 10 staffs above is: {averageSalary}");
        }
    }
}
