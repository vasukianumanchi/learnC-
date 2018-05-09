

using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your Name");
            String name = Console.ReadLine();

            Console.WriteLine("How many hours of sleep did you get last night ??");
            int hourofSleep = int.Parse(Console.ReadLine());

            
            Console.WriteLine("Hello " + name);
            if(hourofSleep >=8)
            {
                Console.WriteLine("You Have Enough Sleep");
            }
            else
            {
                Console.WriteLine("You need more sleep");
            }
        }
    }
}
