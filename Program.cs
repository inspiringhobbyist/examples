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


            // calling constructor example 
             
            employee p2 = new employee();
            p2.setemployeedetails(007, "James");
            Console.WriteLine(p2.getemployeename());

            employee p3 = new employee();
            Console.WriteLine(p3.getemployeename());    // this gives us default name since we have new p3 instance of class and without setting id and 
                                                        // name we are directly calling its method getemployeename so it will print default values assigned
                                                        // to properties in consstructor basically constructor is initializing properties 



        }
    }
}
