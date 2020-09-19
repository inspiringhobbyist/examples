using System;

namespace examples
{
    class Program
    {
        enum days { sun=1, mon, tue, wed, thurs,fri,sat}

       
        static void Main(string[] args)
        {
            int[] values;
            Console.WriteLine("Hello World!");
            Console.WriteLine($"this is enum para {days.sun}");
            values = new int[3];
            values[0] = 1;
            values[1] = 2;
            values[2] = 3;
            
            Console.WriteLine($"{values[0]}");

        }
    }
}
