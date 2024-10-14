using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TCircle7
{
    class Program
    {
        static void Main()
        {
            try
            {
                //коло
                TCircle circle1 = new TCircle();
                TCircle circle2 = new TCircle();
                circle1.Input();
                circle1.Output();
                Console.WriteLine($"Площа кола: {circle1.Area()}");
                Console.WriteLine($"Довжина кола: {circle1.Square()}");
                Console.WriteLine($"Площа сектора (кут = π/4): {circle1.SectorArea(Math.PI / 4)}");

                Console.WriteLine("\nІнше коло для порівняння ");
                circle2.Input();
                circle2.Output();
                Console.WriteLine($"Чи рівні коло1 і коло2: {circle1.Equals(circle2)}");

                TCircle sumCircle = circle1 + circle2;
                Console.WriteLine($"\nСума радіусів: {sumCircle.Radius}");
                TCircle diffCircle = circle1 - circle2;
                Console.WriteLine($"Різниця радіусів: {diffCircle.Radius}");


                Console.Write("Впишіть множник: ");
                double multiplier = Convert.ToDouble(Console.ReadLine());
                if (multiplier <= 0)
                    throw new ArgumentException("Множник не може бути від'ємним або нулем");
                TCircle scaledCircle = circle1 * multiplier;
                Console.WriteLine($"Множення першого радіуса на {multiplier}: {scaledCircle}");
                TCircle scaledCircle1 = circle2 * multiplier;
                Console.WriteLine($"Множення другого радіуса на {multiplier}: {scaledCircle1}");


                //конус
                Console.WriteLine("\nСтворення конуса:");
                TCone cone1 = new TCone(); 
                TCone cone2 = new TCone();
                cone1.Input();
                cone1.Output();
                Console.WriteLine($"Об'єм конуса: {cone1.Square()}");

                Console.WriteLine("\nІнший конус для порівняння ");
                cone2.Input();
                cone2.Output();
                Console.WriteLine($"Чи рівні конус1 і конус2: {cone1.Equals(cone2)}");

                TCone sumCone = cone1 + cone2;
                Console.WriteLine($"\nСума радіусів та висот: Радіус = {sumCone.Radius}, Висота = {sumCone.Height}");
                TCone diffCone = cone1 - cone2;
                Console.WriteLine($"Різниця радіусів та висот: Радіус = {diffCone.Radius}, Висота = {diffCone.Height}");


                Console.Write("Впишіть множник: ");
                double multiplierCone = Convert.ToDouble(Console.ReadLine());
                if (multiplierCone <= 0)
                    throw new ArgumentException("Множник не може бути від'ємним або нулем");
                TCone scaledCone1 = cone1 * multiplierCone;
                Console.WriteLine($"Множення першого конуса на {multiplierCone}: Радіус = {scaledCone1.Radius}, Висота = {scaledCone1.Height}");
                TCone scaledCone2 = cone2 * multiplierCone;
                Console.WriteLine($"Множення другого конуса на {multiplierCone}: Радіус = {scaledCone2.Radius}, Висота = {scaledCone2.Height}");
           
            }
            catch (FormatException)
            {
                Console.WriteLine("Помилка: введено невірний формат числа. Будь ласка, введіть коректне число");
                return;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
                return;
            }
        }
    }
}
