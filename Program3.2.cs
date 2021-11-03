using System;

namespace дз3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] a = new string [5, 2];
            a[0,0] = "Вова";//0 1 
            a[1,0] = "Саша";//0 1 
            a[2,0] = "Леша";//0 1 
            a[3,0] = "Дима";//0 1 
            a[4,0] = "Петя";//0 1 
            a[0,1] = "00000000";
            a[1,1] = "11111111";
            a[2,1] = "22222222";
            a[3,1] = "33333333";
            a[4,1] = "44444444";

            int height = a.GetLength(0);
            int great = a.GetLength(1);
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < great; x++)
                {

                    Console.Write(a[y, x] + "\t");

                }
                Console.WriteLine();
            }
        }
    }
}