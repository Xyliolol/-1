using System;

namespace дз3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = "Hello";
            var array = str.ToCharArray();


            array[4] = 'H';
            array[3] = 'e';
            array[2] = 'l';
            array[1] = 'l';
            array[0] = 'o';


            str = new string(array);
            Console.WriteLine(str);

        }
    }
}