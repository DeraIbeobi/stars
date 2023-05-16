using System;

namespace Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter height of the triangle: ");
            int height = Convert.ToInt32(Console.ReadLine());
            for (int row = 1; row <= height; row++)
            {
                for (int blank = height - row; blank > 0; blank--)
                {
                    System.Console.Write(" ");
                }
                for (int column = 1; column <= (row * 2) - 1; column++)
                {
                    System.Console.Write("*");
                }
                System.Console.WriteLine();
            }

            System.Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
