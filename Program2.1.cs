using System;

namespace дз2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.Today;
            Console.WriteLine(date.ToString("dd.MM.yy"));
            Console.WriteLine("min t");
            string min=Console.ReadLine();
            Console.WriteLine("max t");
            string max = Console.ReadLine();
            int mini = Convert.ToInt32(min);
            int maxi = Convert.ToInt32(max);
            int average = ((mini + maxi) / 2);

            Console.WriteLine($"среднесуточная температура {date.ToString("dd.MM.yy")} составила {average} градусов");
        }
    }
}
