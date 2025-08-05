using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Enter your age (or type Q to quit): ");
            string input = Console.ReadLine();

            if (input.Trim().ToUpper() == "Q")
            {
                Console.WriteLine("Goodbye!");
                break;
            }

            if (int.TryParse(input, out int age))
            {
                if (age < 0)
                {
                    Console.WriteLine("Please enter a valid age.");
                    continue;
                }

                int ticketPrice = (age <= 12 || age >= 65) ? 7 : 10;
                Console.WriteLine($"Ticket price: GHC{ticketPrice}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number or 'Q' to quit.");
            }
        }
    }
}
