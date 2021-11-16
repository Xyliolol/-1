using System;
using System.Diagnostics;

namespace дз6
{
    class Program
    {
        static void Main(string[] args)
        {
            var TaskManager = Process.GetProcesses();
            foreach (Process process1 in TaskManager)
                Console.WriteLine($"{process1.Id} {process1.ProcessName}");
            {

                Console.WriteLine("Введите 1,если хотите завершить процесс по имени");
                Console.WriteLine("Введите 2,если хотите завершить процесс по ID");
                var input = Console.ReadLine();
                if (input == "1")
                {
                    Console.WriteLine("введите имя процесса");
                    var name = Console.ReadLine();
                    Process[] processes = Process.GetProcessesByName(name);
                    foreach (Process proc in processes) proc.Kill();
                    Console.WriteLine($"{name} был закрыт");

                }
                
                if (input == "2")
                {
                    try
                    {
                        Console.WriteLine("введите ID процесса");
                        var numbers = int.Parse(Console.ReadLine());
                        Process process = Process.GetProcessById(numbers);
                        process.Kill();
                        Console.WriteLine($"процесс c ID {numbers} был закрыт");
                    }
                    catch
                    {
                        Console.WriteLine("ТРЕБУЕТСЯ ВВОД ЦИФРАМИ");
                    }
                }
                Console.WriteLine(input);
                
            }
        }
    }
}
