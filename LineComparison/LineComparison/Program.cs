using System;

namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcom to Line Comparison Computation.");


            Console.WriteLine("Enter the value of x1 : ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of y1 : ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of x2 : ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of y2 : ");
            int y2 = Convert.ToInt32(Console.ReadLine());

            double length_of_line = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine("The Length of 2 Points(" + x1 + "," + y1 + ") and (" + x2 + "," + y2 + ") is " + length_of_line);
        }
    }
}
