using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_sheet_1_Q2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            for (int i = 0; i < 10; i++)
            {
                Console.Write("\n Enter a number: ");
                number = int.Parse(Console.ReadLine());
                if (number % 2 == 0)
                {
                    Console.Write("It is a even number");
                }
                else
                {
                    Console.Write("It is a odd number");
                }
            }
        }
    }
}