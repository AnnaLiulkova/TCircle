using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCircle7
{
    public class TCone : TCircle
    {
        private double height;

        public static void CheckingForNegativeNumbersHeight(double height)
        {
            //if (height == 0)
            //    throw new ArgumentException("Висота не може бути нулем");
            if (height < 0)
                throw new ArgumentException("Висота не може бути від'ємним");
        }
        public double Height
        {
            get { return height; } 
            set 
            {
                if (value >= 0) 
                    height = value;
            }
        }

        public TCone() : base()
        {
            height = 13.0;
        }

        public TCone(double radius, double height) : base(radius)
        {
            CheckingForNegativeNumbersHeight(height);
            this.height = height;
        }

        public TCone(TCone obj) : base(obj)
        {
            height = obj.height;
        }
        public new void Input()
        {
            base.Input();  // без цього буде викликати констуктор без параметрів 
            Console.Write("Введіть висоту конуса: ");
            double h = Convert.ToDouble(Console.ReadLine());
            CheckingForNegativeNumbersHeight(h);
            this.height = h;
        }

        public bool Equals(TCone obj) 
        {
            return radius == obj.radius && height == obj.height;
        }

        public override string ToString()
        {
            return $"Конус з радіусом: {radius} і висотою: {height}";
        }

        public new double Area() // oб'єм конуса(Volume)
        {
            return (1.0 / 3) * base.Area() * height;
        }

        public static TCone operator +(TCone c1, TCone c2)
        {
            return new TCone(c1.radius + c2.radius, c1.height + c2.height);
        }

        public static TCone operator -(TCone c1, TCone c2)
        {
            return new TCone(Math.Abs(c1.radius - c2.radius), Math.Abs(c1.height - c2.height));
        }

        public static TCone operator *(TCone c, double number)
        {
            return new TCone(c.radius * number, c.height * number);
        }

        public static TCone operator *(double number, TCone c)
        {
            return new TCone(c.radius * number, c.height * number);
        }
    }
}

