using System;

namespace дз2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int ker = 5800;
            int cem = 5400;
            int sheb = 2400;
            int gvozdi = 652;
            DateTime data = DateTime.Now;
            int itog = (ker + cem + sheb + gvozdi);
            Console.WriteLine("      ООО'СуперЧек.ру'");
            Console.WriteLine("          Чек №4201 ");
            Console.WriteLine("       Кассир:Иванов");
            Console.WriteLine( "1.Кирпич пустотелый одинарный");
            Console.WriteLine( "М-150 580 Х 10");
            Console.WriteLine($"Стоимость................{ker}");
            Console.WriteLine( "Цемент ПЦ-400 Д 20 (мешках)");
            Console.WriteLine($"Стоимость................{cem}");
            Console.WriteLine( "Щебень фракция 20х40 т.");
            Console.WriteLine( "5 Х 480.00");
            Console.WriteLine($"Стоимость................{sheb}");
            Console.WriteLine( "Гвозди жидкие/ 310 мл");
            Console.WriteLine( "4 Х 163.00");
            Console.WriteLine($"Стоимость................{gvozdi}");
            Console.WriteLine("=============================");
            Console.WriteLine($"Всего................{itog}.00");
            Console.WriteLine( "КММ 0000000 ИНН 0000000 №4201");
            Console.WriteLine($"{data}    ИВАНОВ");
            Console.WriteLine( "ПРОДАЖА                 №2890 ");
            Console.WriteLine($"ИТОГ                   ={itog}") ;
            Console.WriteLine($"НАЛИЧНЫМИ              ={itog} ") ;
        }
    }
}
