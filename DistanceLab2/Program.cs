namespace DistanceLab2
{
    public struct Distance
    {
        public double F;
        public double D;
    }
    internal class Program
    {
        static void Main()
        {
            Distance First, Second, Third;
            First.F = double.Parse(Console.ReadLine());
            First.D = double.Parse(Console.ReadLine());
            Second.F = double.Parse(Console.ReadLine());
            Second.D = double.Parse(Console.ReadLine());
            Third.F = (First.F + Second.F) + (int)(First.D + Second.D)/12;
            Third.D = (First.D + Second.D)%12;
            Console.WriteLine($"Расстояние {Third.F}' - {Third.D}''");
        }
    }
}
