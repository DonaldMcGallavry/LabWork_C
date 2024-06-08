namespace Lab4_1_Triangle
{
    class Operation
    {
        public static double Square(double x, double y, double z)
        {
             x = double.Parse(Console.ReadLine());
             y = double.Parse(Console.ReadLine());
             z = double.Parse(Console.ReadLine());
            double p = (x + y + z) / 2;
            bool ok = true;
            double s = 0;
            ok = Operation.Possible(x,y,z);
            if (ok)
                s = Math.Sqrt(p * (p - x) * (p - y) * (p - z));
            else Console.WriteLine("Треугольника не существует");
                return s;
        }
         private static bool Possible(in double x,in double y,in double z)
          {
            bool ok = true;
            if (x + y <= z || x + z <= y || y + z <= x)
                ok = false;
            else if (x< 0 || y <0 || z <0)
                ok = false;
            else ok = true;
              return ok;
          }
        public static double Square(double a)
        {
            a = double.Parse(Console.ReadLine());
            double p = a * 3 / 2;
            double s = (p * (p - a) * (p - a) * (p - a));
            return s;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double s = 0;
            char restart;
            Console.WriteLine("Треугольник равносторонний? y/n");
            restart = Convert.ToChar(Console.ReadLine());
            if (restart == 'y')
                s = Operation.Square(1);
            else s = Operation.Square(1,2,3);
            Console.WriteLine($"Площадь треугольника = {s}");
        }
    }
}
