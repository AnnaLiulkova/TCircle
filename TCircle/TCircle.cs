using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TCircle7
{
    public class TCircle
    {
        protected double radius;

        public void CheckingForNegativeNumbersRadius(double radius)
        {
            //if (radius == 0)
            //    throw new ArgumentException("Радіус не може бути нулем");
            if (radius < 0)
                throw new ArgumentException("Радіус не може бути від'ємним");
        }
        public double Radius
        {
            get { return radius; }
            set
            {
                if (value >= 0) radius = value;
            }
        }
        public TCircle()
        {
            radius = 1.0;
        }
        public TCircle(double radius)
        {
            CheckingForNegativeNumbersRadius(radius);
            this.radius = radius;
        }

        public TCircle(TCircle obj)
        {
            this.radius = obj.radius;
        }

        public override string ToString()
        {
            return $"Коло з радіусом {radius}";
        }

        public void Input()
        {
            Console.Write("Введіть радіус кола: ");
            double r = Convert.ToDouble(Console.ReadLine());
            CheckingForNegativeNumbersRadius(r);
            this.radius = r;
        }

        public void Output()
        {
            Console.WriteLine(this.ToString());
        }
        public double Area()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public double SectorArea(double angle)
        {
            return 0.5 * Math.Pow(radius, 2) * angle;
        }

        public double Square() 
        {
            return 2 * Math.PI * radius;
        }

        public bool Equals(TCircle obj) // CompareTo
        {
            return radius == obj.radius;
        }

        public static TCircle operator +(TCircle c1, TCircle c2)
        {
            return new TCircle(c1.radius + c2.radius);
        }

        public static TCircle operator -(TCircle c1, TCircle c2)
        {
            return new TCircle(Math.Abs(c1.Radius - c2.Radius));
        }

        public static TCircle operator *(TCircle c, double number)
        {
            return new TCircle(c.radius * number);
        }
        public static TCircle operator *(double number, TCircle c)
        {
            return new TCircle(number * c.radius);
        }
    }
}