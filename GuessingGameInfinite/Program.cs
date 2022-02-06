using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int cpu = rnd.Next(1, 11);
            bool loopActive = true;
            while(loopActive)
            {
                Console.WriteLine("Palun sisesta number.");
                int userNumber = Convert.ToInt32(Console.ReadLine());
                if(userNumber == cpu)
                {
                    Console.WriteLine("Oled mängu võitja.");
                    loopActive = false;
                }
                else
                {
                    Console.WriteLine("Proovi uuesti.");
                }
            }
            Console.WriteLine("Kena päeva!");
        }
    }
}
