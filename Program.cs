using System;

namespace Week3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Start the program with Clear();
            Console.Clear();
            
            // const int count = 5;

            // for (var i = 0; i < count; i++)
            // {
            //     Console.WriteLine("Hello World");
            // }

            // for (var i = 0; i < count; i++)
            // {
            //     var a = i + 1;
            //     Console.WriteLine($"Hello World {a}");
            // }

            // const int count = 50;

            // for (int i = 0; i < count; i++)
            // {
            //     var a = i + 1;
            //     if (a % 2 == 0)
            //     {
            //         Console.WriteLine(a);
            //     }
            // }

            // const int count = 50;
            // var i = 0;

            // while (i < count)
            // {
            //     var a = i + 1;
            //     if (a % 2 != 0)
            //     {
            //         Console.WriteLine(a);
            //     }
            //     i++;
            // }

            // With this method, not sure if I comprehended instructions properly,
            //  this is my implementation of my interpretation
            const int count = 100;
            var i = 200;

            do
            {
                if (i % 25 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            } while (i < count);
            
            //End the program with blank line and instructions
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Press <Enter> to quit the program");
            Console.ReadKey();
        }
    }
}
