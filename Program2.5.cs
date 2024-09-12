using System;

namespace дз2._5
{
    class Program
    {
        enum month
        {
            Декабрь,
            Январь,
            Февраль
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Введите минимальную температуру: ");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите максимальную температуру");
            int max = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите месяц: ");
            string a = Console.ReadLine();
            int average = (min + max) / 2;
            if ((a == Convert.ToString(month.Декабрь))||(a == Convert.ToString(month.Январь))||(a == Convert.ToString(month.Февраль)) && (min + max / 2 > 0))
            {
                Console.WriteLine("Дождливая зима");

            }
            else
                Console.WriteLine($" Средняя температура составила {average} ");
        }
    }
}

