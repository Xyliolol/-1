using System;

namespace дз2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int Enter = Convert.ToInt32(Console.ReadLine());
            if (Enter % 2 == 0)
            {
                Console.WriteLine("Ваше число делится на 2 без остатка");
            }
            else
            {
                Console.WriteLine("Ваше число НЕ делится на 2 без остатка");
            }


        }
    }
}
