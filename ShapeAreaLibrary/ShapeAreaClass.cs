using System;

namespace ShapeAreaLibrary
{
    //Родительский класс 
    public abstract class Shape
    {
        protected double area;

        public abstract double CalcArea();
    }
    //Класс Круг
    public class Circle : Shape
    {
        private double radius;
        
        //Конструктор, принимающий значение радиуса
        public Circle(double r)
        {
            radius = r;
        }
        //Метод, вычисляющий площадь круга
        public override double CalcArea()
        {
            area = Math.Round(Math.PI,2) * (Math.Pow(radius, 2));
            return (area);
        }
    }
    //Класс Треугольник
    public class Rectangle : Shape
    {
        private double cathetus_a;
        private double cathetus_b;
        private double hypotenuse;

        //Конструктор принимающий значения трех сторон
        public Rectangle(double a, double b, double h)
        {
            cathetus_a = a;
            cathetus_b = b;
            hypotenuse = h;
        }

        //Метод вычисляющий площадь треугольника
        public override double CalcArea()
        {
            double p = (cathetus_a + cathetus_b + hypotenuse) / 2;
            area = Math.Sqrt(p * (p - cathetus_a) * (p - cathetus_b) * (p - hypotenuse));
            return (area);
        }
    }

}
