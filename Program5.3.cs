using System.IO;
using System;

namespace дз5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов массива:\t");
            byte elements = byte.Parse(Console.ReadLine());
            byte[] array = new byte[elements];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Введите элемент массива под индексом {i}:\t");
                array[i] = byte.Parse(Console.ReadLine());
            }
            Console.WriteLine("Вывод массива");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            File.WriteAllBytes("bytes.bin", array);
            byte[] fromFile = File.ReadAllBytes("bytes.bin");

        }


    }
}