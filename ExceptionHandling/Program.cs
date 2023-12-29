using System;
using System.Collections.Generic;
using System.IO;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr  = new char[] { 'A', 'B', 'C', '1', '2', '3', '4','5','6' };
            var numbers = new List<int>();
            var str = "";

            foreach (var item in arr)
            {
                try
                {
                    str = item.ToString();
                    var number = int.Parse(str);
                    numbers.Add(number);
                }
                catch(Exception e)
                {
                    Console.WriteLine($"Unable to Parse '{item}' ");
                }

            }
            foreach(var num in numbers)
            {
                Console.WriteLine(num);
            }




        }
    }
}