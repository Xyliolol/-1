using System;

namespace дз2._2
{
    class Program
    {
        


        static void Main(string[] args)
        {
            Console.WriteLine("Введите текущий месяц");
            int i = Convert.ToInt32(Console.ReadLine());
            int Month = Convert.ToInt32(DateTime.Now.ToString("MM"));
            string MonthTitle = "";
            switch (Month)
            {
              
                case 1:
                    MonthTitle = "Январь";
                    break;
                case 2:
                    MonthTitle = "Февраль";
                    break;
                case 3:
                    MonthTitle = "Март";
                    break;
                case 4:
                    MonthTitle = "Апрель";
                    break;
                case 5:
                    MonthTitle = "Май";
                    break;
                case 6:
                    MonthTitle = "Июнь";
                    break;
                case 7:
                    MonthTitle = "Июль";
                    break;
                case 8:
                    MonthTitle = "Август";
                    break;
                case 9:
                    MonthTitle = "Сентябрь";
                    break;
                case 10:
                    MonthTitle = "Октябрь";
                    break;
                case 11:
                    MonthTitle = "Ноябрь";
                    break;
                case 12:
                    MonthTitle = "Декабрь";
                    break;
            }

            Console.WriteLine(MonthTitle);

            

            
        }
    }
}


    


