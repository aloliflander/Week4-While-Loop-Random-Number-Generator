using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int cpu = rnd.Next(1, 11);
            int i = 0;
            while (i < 3)
            {
                Console.WriteLine("Palun sisesta number.");
                int userNumber = Convert.ToInt32(Console.ReadLine());
                if (userNumber == cpu)
                {
                    Console.WriteLine("Oled mängu võitja.");
                    break;
                }
                else
                {
                    i = i + 1;
                    Console.WriteLine($"Sul on jäänud {3-i} katset");
                }
            }
            Console.WriteLine("Kena päeva!");
        }
    }
}
