using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9_Circle
{
    class CircleApp
    {
        private double Radius;
        

        public CircleApp(double radius)
        {
            Radius = radius;
        }
        public CircleApp()
        {
            
        }
        public double GetCircumference(double r)
        {
            double Circumference = 2 * Math.PI * Radius;
            return Circumference;
        }
        public double GetArea(double r)
        {
            double Area = Math.Pow(Radius, 2)* Math.PI;
            return Area;
        }
        private string FormatNumber(double n)
        {
            double Format = Math.Round(n, 2);
            string Formatted = Format.ToString();
            return Formatted;
        }
        public string GetFormattedCircumference(double n)
        {
            double cir = GetCircumference(Radius);
            string FormattedCircumference = FormatNumber(cir);
            return FormattedCircumference;
        }
        public string GetFormattedArea(double n)
        {
            double area = GetArea(Radius);
            string FormattedArea = FormatNumber(area);
            return FormattedArea;
        }
    }
}

