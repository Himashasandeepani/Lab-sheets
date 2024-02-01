using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_sheet_1_Q1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length: ");
            double length = double.Parse(Console.ReadLine());

            Console.Write("Enter the width: ");
            double width = double.Parse(Console.ReadLine());

            double area = Area(length, width);

            Console.WriteLine("The area of the rectangle is: " + area);
            Console.ReadLine();
        }
        //we use static here becaouse we have used 2 parameters
        static double Area(double length, double width)
        {
            return length * width;
        }
    }
}
