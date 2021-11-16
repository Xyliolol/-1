using System;

namespace дз4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string foo = Console.ReadLine();
            string[] tokens = foo.Split(" ");
            int sum = 0;
            for (int i = 0; i < tokens.Length; i++)
            {
                sum += Convert.ToInt32(tokens[i]);
            }
            Console.WriteLine(sum);
        }
    }
}
