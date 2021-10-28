using System;

namespace дз1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Привет");
            string name = Console.ReadLine();
            Console.WriteLine($"{name} сегодня [{DateTime.Now}] !");
        }
    }
}
