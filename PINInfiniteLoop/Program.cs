using System;

namespace PINInfiniteLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loopActive = true;
            int i = 0;
            while (loopActive)
            {
                Console.WriteLine("Siseta PIN");
                int userPin = Convert.ToInt32(Console.ReadLine());
                if (userPin == 1234)
                {
                    Console.WriteLine("Tere tulemast");
                    loopActive = false;
                }
                else
                {
                    i = i+1;
                    Console.WriteLine("Vale PIN, proovi uuesti");
                    Console.WriteLine($"Oled vale PIN-koodi {i} korda sisestanud.");
                }
            }
            Console.WriteLine("Kena päeva!");
        }
    }
}
