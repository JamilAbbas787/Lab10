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

        }
    }

    class Circle
    {
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculateCircumference()
        {

            double calculatedCircumference = (_radius * 2) * Math.PI;
            return calculatedCircumference;

        }

        public string CalculateFormattedCircumference()
        {
            string formattedCircumference = $"Circumference: {CalculateCircumference()}";
            return formattedCircumference;
        }

        public double CalculateArea()
        {
            double circleArea = Math.Pow(_radius, 2) * Math.PI;
            return circleArea;
        }

        public string CalculateFormattedArea()
        {
            string areaFormatted = $"Area: {CalculateArea()}";
            return areaFormatted;

        }

        private string FormatNumber(double x)
        {

        }

        private double _radius;

        public double Radius
        { get { return _radius; }
          set { _radius = value; }
        }


    }

    class Validator
    {
        public static bool Verify(string radius)
        {
            bool converstionToInt =  int.TryParse(radius, out int radiusToNumber);
            if (converstionToInt)
            {
                return true;
            }
            return false;
        }

    }


}


