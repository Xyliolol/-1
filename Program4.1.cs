using System;

namespace дз4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetFullName());
            Console.WriteLine(GetFullName());
            Console.WriteLine(GetFullName());

        }
        static (string firstName, string lastName, string patronymic) GetFullName()
        {
            Console.WriteLine("Ведите имя");
            string firstName = Console.ReadLine();
            Console.WriteLine("Введите фамилию");
            string lastName = Console.ReadLine();
            Console.WriteLine("Введите отчество");
            string patronymic = Console.ReadLine();
            return (firstName,lastName,patronymic);
        }
        


    }
    
}

