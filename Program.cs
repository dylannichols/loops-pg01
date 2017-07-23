using System;

namespace Week3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Start the program with Clear();
            Console.Clear();
            
            const int count = 5;

            for (var i = 0; i < count; i++)
            {
                var a = i + 1;
                Console.WriteLine($"Hello World {a}");
            }
            
            //End the program with blank line and instructions
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Press <Enter> to quit the program");
            Console.ReadKey();
        }
    }
}
