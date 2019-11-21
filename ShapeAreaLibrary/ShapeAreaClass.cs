using System;

namespace ShapeAreaLibrary
{
    public abstract class Shape
    {
        protected double area;

        public abstract double CalcArea();
    }

    public class Circle : Shape
    {
        private double radius;

        public Circle(double r)
        {
            radius = r;
        }

        public override double CalcArea()
        {
            area = Math.PI * (Math.Pow(radius, 2));
            return (area);
        }
    }

    public class Rectangle : Shape
    {
        private double cathetus_a;
        private double cathetus_b;
        private double hypotenuse;

        public Rectangle(double a, double b, double h)
        {
            cathetus_a = a;
            cathetus_b = b;
            hypotenuse = h;
        }
        public override double CalcArea()
        {
            double p = (cathetus_a + cathetus_b + hypotenuse) / 2;
            area = Math.Sqrt(p * (p - cathetus_a) * (p - cathetus_b) * (p - hypotenuse));
            return (area);
        }
    }

}
