using System.Numerics;

namespace Lab4_2_Discriminant
{
    class Root
    {
        public static double Disc(double a, double b, double c, out double x1,out double x2)
        {
            
            x1 = x2 = 0;
            
            double D = (b * b - 4 * a * c);
            if (D < 0)
            {
                D = 0;
            }
            else if (D == 0)
            {
                x1 = -b / (2 * a);
                x2 = x1;
                D = -1;
            }
            else
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                D = 1;
            }
                return D;
            }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            double F = 0;
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            F = Root.Disc(a, b, c, out double x1, out double x2);
            if (F == 0)
                Console.WriteLine($" Корней уравнения с коэффициентами a = {a}, b = {b}, c = {c} нет");
            else if (F == -1) Console.WriteLine($"Корень уравнения с коэффициентами a = {a}, b = {b}, c = {c} один: x1 = x2 = {x1}");
            else Console.WriteLine($"Корней уравнения с коэффициентами a = {a}, b = {b}, c = {c} равны: x1 = {x1}, x2 = {x2}");
        }
    }
}
