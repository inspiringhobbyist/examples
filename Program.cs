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
            values[0] = 1;                  //individual assignment of array value
            values[1] = 2;
            values[2] = 3;
            int[] array1 = { 7,8};          // direct assignment of array
            Console.WriteLine($"{array1[0]}");

            Console.WriteLine($"{values[0]}");  


            // calling class tutorial objects and its methods

            tutorial p1 = new tutorial();
            p1.setutorial(1, ".NET");
            Console.WriteLine(p1.gettutorial());


        }
    }
}
