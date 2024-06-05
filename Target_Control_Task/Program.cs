namespace Target
{
    internal class Program
    {
        
        static void Main()
        {
 
            int Shot = 0;
            int f;
            int Sum = 0;
            while (Shot != 3)
            {
                Console.WriteLine("x=");
                float x = float.Parse(Console.ReadLine());
                Console.WriteLine("y=");
                float y = float.Parse(Console.ReadLine());
                if (x * x + y * y < 1)
                f = 10;
                else if (x * x + y * y > 1 && x * x + y * y < 4)
                f = 5;
                else 
                   f = 0;
                    Sum = Sum + f;
              Shot++;
                Console.WriteLine($"Сумма очков = {Sum}");
            }
        }
    }
}
