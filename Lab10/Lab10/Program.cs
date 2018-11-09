using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Circle Tester");
            Console.WriteLine("Enter radius:  ");
            bool callToVerification = false;
            string userInput = Console.ReadLine();
            string userContinue = "y";
            int circlesCreated = 1;

            while(userContinue.Equals("y", StringComparison.OrdinalIgnoreCase))
            {
                while (!callToVerification)
                {
                    callToVerification = Validator.Verify(userInput);
                    if (!callToVerification)
                    {
                        userInput = Console.ReadLine();
                    }
                }

                double.TryParse(userInput, out double userEnteredRadius);
                var circleTester = new Circle(userEnteredRadius);
                Console.WriteLine($"Radius: {circleTester.Radius}");
                Console.WriteLine(circleTester.CalculateFormattedCircumference());
                Console.WriteLine(circleTester.CalculateFormattedArea());

                Console.WriteLine("Continue? (y/n):  ");
                userContinue = Console.ReadLine();
                if (userContinue.Equals("y", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Enter radius:  ");
                    userInput = Console.ReadLine();
                    circlesCreated++;
                }
            }

            Console.WriteLine($"Goodbye. You created {circlesCreated} Circle object(s)");

            Console.ReadKey();
        }
    }

}


