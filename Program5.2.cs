using System.IO;
using System;

namespace дз5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var time = DateTime.Now;
            var filename = "startup.txt";
            
            File.AppendAllLines(filename, new[] { ($"Текущее время {time.ToString("hh:mm:ss")}") });
        }
    }
}
