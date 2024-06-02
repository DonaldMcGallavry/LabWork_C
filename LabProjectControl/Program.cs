namespace LabProjectControl
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите Периметр");
            double p = double.Parse(Console.ReadLine());
            double a = p / 3;
            double p2 = p / 2;
            double s = Math.Sqrt(p2 * (p2 - a) * (p2 - a) * (p2 - a));
            Console.WriteLine($"Сторона Площадь \v {a:F2}   {s:F2}");
        }
    }
}
