using System;

namespace Lab10
{
    class Circle
    {
        public Circle(double radius)
        {
            Radius = radius;
            FormatNumber(Radius);
        }

        public double CalculateCircumference()
        {

            double calculatedCircumference = (_radius * 2) * Math.PI;
            return calculatedCircumference;

        }

        public string CalculateFormattedCircumference()
        {
            string formattedCircumference = $"Circumference: {CalculateCircumference().ToString("##.##")}";
            return formattedCircumference;
        }

        public double CalculateArea()
        {
            double circleArea = Math.Pow(_radius, 2) * Math.PI;
            return circleArea;
        }

        public string CalculateFormattedArea()
        {
            string areaFormatted = $"Area: {CalculateArea().ToString("##.##")}";
            return areaFormatted;

        }

        private string FormatNumber(double x)
        {
            string formatedNumberRadius = $"Radius: {Radius}";
            return formatedNumberRadius;
        }

        private double _radius;

        public double Radius
        { get { return _radius; }
          set { _radius = value; }
        }


    }


}


