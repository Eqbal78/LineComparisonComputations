using System;

namespace practiceLineCompare
{
    public interface IComparison
    {
        public void CompareLine();
    }

    public class Line
    {
        public int x1, y1, x2, y2, x3, y3, x4, y4;

        public Line()
        {

        }

        public void Input()
        {
            Console.WriteLine("Welcome to Line Comparison Computation.");

            Console.WriteLine("Enter values x1 and y1 for Line 1");
            Console.WriteLine("Enter values x1 for Line 1");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter values y1 for Line 1");
            y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter values x2 and y2 for Line 1");
            Console.WriteLine("Enter values x2 for Line 1");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter values y2 for Line 1");
            y2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter values x3 and y3 for Line 2");
            Console.WriteLine("Enter values x3 for Line 2");
            x3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter values y3 for Line 2");
            y3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter values x4 and y4 for Line 2");
            Console.WriteLine("Enter values x4 for Line 2");
            x4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter values y4 for Line 2");
            y4 = Convert.ToInt32(Console.ReadLine());

        }

        public void CompareLine()
        {
            double length_of_line1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double length_of_line2 = Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));

            int line_difference = length_of_line1.CompareTo(length_of_line2);

            if (line_difference == 0)
                Console.WriteLine("Lines are equal in length");
            else if (line_difference > 0)
                Console.WriteLine("Line1 is greater in length than Line2");
            else
                Console.WriteLine("Line1 is smaller in length than Line2");

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Line obj = new Line();
            obj.Input();
            obj.CompareLine();

        }
    }
}
