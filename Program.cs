using System;

namespace examples
{
    class Program
    {
        enum days { sun, mon, tue, wed, thurs,fri,sat}
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine($"this is enum para {days.sun}");
        }
    }
}
