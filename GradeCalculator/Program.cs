using System;

namespace GradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int countA = 0, countB = 0, countC = 0, countD = 0, countF = 0;

            while (true)
            {
                Console.Write("Enter the numeric grade (0–100), or type Q to quit: ");
                string input = Console.ReadLine() ?? "";

                if (string.Equals(input, "Q", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }

                if (!int.TryParse(input, out int score) || score < 0 || score > 100)
                {
                    Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
                    continue;
                }

                string letter;
                if (score >= 90)       letter = "A";
                else if (score >= 80)  letter = "B";
                else if (score >= 70)  letter = "C";
                else if (score >= 60)  letter = "D";
                else                   letter = "F";

                // increment tally
                switch (letter)
                {
                    case "A": countA++; break;
                    case "B": countB++; break;
                    case "C": countC++; break;
                    case "D": countD++; break;
                    case "F": countF++; break;
                }

                Console.WriteLine($"A score of {score} corresponds to a letter grade of {letter}.");
                Console.WriteLine();
            }

            // after quitting, print the tally
            Console.WriteLine("\nGrade tally:");
            Console.WriteLine($"A: {countA}");
            Console.WriteLine($"B: {countB}");
            Console.WriteLine($"C: {countC}");
            Console.WriteLine($"D: {countD}");
            Console.WriteLine($"F: {countF}");
        }
    }
}
