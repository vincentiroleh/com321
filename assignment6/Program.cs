using System;

namespace assignment6
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
                Write a program to compute the product AB, store the result in P and subsequently print P.
            */
510            int productA;
            int productB;
            int resultP;

            Console.WriteLine("Enter product's A value: ");
            productA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter product's B value: ");
            productB = Convert.ToInt32(Console.ReadLine());

            resultP = (productA + productB);
            Console.WriteLine($"The sum of {productA} and {productB} is {resultP}");

        }
    }
}
