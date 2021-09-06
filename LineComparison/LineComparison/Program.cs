using System;

namespace LineComparison
{
    class Program
    {
        static int Compare()
        {
            Console.WriteLine("Welcome to Line Comparison Computation.");

            Console.WriteLine("Enter values x1 and y1 for Line 1");
            Console.WriteLine("Enter values x1 for Line 1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter values y1 for Line 1");
            int y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter values x2 and y2 for Line 1");
            Console.WriteLine("Enter values x2 for Line 1");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter values y2 for Line 1");
            int y2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter values x3 and y3 for Line 2");
            Console.WriteLine("Enter values x3 for Line 2");
            int x3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter values y3 for Line 2");
            int y3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter values x4 and y4 for Line 2");
            Console.WriteLine("Enter values x4 for Line 2");
            int x4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter values y4 for Line 2");
            int y4 = Convert.ToInt32(Console.ReadLine());
            double length_of_line1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double length_of_line2 = Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));

            int line_difference = length_of_line1.CompareTo(length_of_line2);

            if (line_difference == 0)
                Console.WriteLine("Lines are equal in length");
            else if (line_difference > 0)
                Console.WriteLine("Line1 is greater in length than Line2");
            else
                Console.WriteLine("Line1 is smaller in length than Line2");

            return line_difference;
        }
        static void Main(string[] args)
        {
            Compare();
        }
    }
}
