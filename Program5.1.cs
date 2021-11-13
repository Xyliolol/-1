using System.IO;
using System;

namespace дз_5._1
{

    class Program
    {
        


        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string filename = "text.txt";
            File.WriteAllText(filename,$"{text}");
        }
    }
}






    