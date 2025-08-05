using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Triangle Type Identifier");

        while (true)
        {
            Console.Write("Enter side 1 (or type Q to quit): ");
            string input1 = Console.ReadLine();
            if (input1.Trim().ToUpper() == "Q") break;

            Console.Write("Enter side 2: ");
            string input2 = Console.ReadLine();

            Console.Write("Enter side 3: ");
            string input3 = Console.ReadLine();

            if (double.TryParse(input1, out double side1) &&
                double.TryParse(input2, out double side2) &&
                double.TryParse(input3, out double side3))
            {
                if (side1 <= 0 || side2 <= 0 || side3 <= 0)
                {
                    Console.WriteLine("All sides must be positive numbers.\n");
                    continue;
                }

                // Check triangle inequality
                if (side1 + side2 > side3 &&
                    side1 + side3 > side2 &&
                    side2 + side3 > side1)
                {
                    if (side1 == side2 && side2 == side3)
                    {
                        Console.WriteLine("This is an Equilateral triangle.\n");
                    }
                    else if (side1 == side2 || side1 == side3 || side2 == side3)
                    {
                        Console.WriteLine("This is an Isosceles triangle.\n");
                    }
                    else
                    {
                        Console.WriteLine("This is a Scalene triangle.\n");
                    }
                }
                else
                {
                    Console.WriteLine("The given sides do not form a valid triangle.\n");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter numeric values.\n");
            }
        }

        Console.WriteLine("Goodbye!");
    }
}
