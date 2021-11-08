using System;

namespace ConsoleApp
{

    class Program
    {
        enum season 
        {  
            Winter,
            Spring,
            Summer,
            Autumn 
        }
        static season Month(int n)
        {
           
                if (n <= 0 || n > 12)
                    Console.WriteLine("Ошибка , Введите число от 1 до 12");
                switch ((n % 12) / 3)
                {
                    case 0:
                        return season.Winter;
                    case 1:
                        return season.Spring;
                    case 2:
                        return season.Summer;
                    case 3:
                        return season.Autumn;
                    default: return season.Autumn;
                    
                }
            
            
        }
        static string Season(season s)
        {
            switch (s)
            {
                case season.Winter:
                    return "Зима";
                case season.Spring:
                    return "Весна";
                case season.Summer:
                    return "Лето";
                case season.Autumn:
                    return "Осень";
                default: return "нет ответа";
            }
        }
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Введите номер месяца: ");
                Console.WriteLine(Season(Month(Convert.ToInt32(Console.ReadLine()))));
            }
            while(true);
        }

    }
}
