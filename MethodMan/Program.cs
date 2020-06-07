using System;

namespace MethodMan
{
    class Program
    {
        public class Math
        {
            public int Num1 { get; set; }
            public int Num2 { get; set; }
            /*public object Add(int sum)
            {
                int sum = Num1 + Num2;
            }*/
        }

        static void Main(string[] args)
        {
            //I'm going to run some basic math problems by using user inputs for variables
            Console.WriteLine("Alright, now let's get into some math coding.");
            Console.WriteLine("");

            //First up, I'm asking the user for 2 ints that the console adds together
            Console.WriteLine("First up, let's do some addition. Give me a number:");
            var Num1 = Console.ReadLine();
            Console.WriteLine($"Okay, I've got {Num1} down. What's another number?");
            var Num2 = Console.ReadLine();

            Console.WriteLine($"Okay, that's {Num1} and {Num2}. Add them together...");
            Console.WriteLine("");
            //var sum = Math.Sum(Num1, Num2);

            Console.WriteLine($"...and your sum is {Math.Equals(Num1, Num2)}!");
        }

        
    }
}
/* Okay, peep this out: this exercise ties in with the Methods prompt from
 * TrueCoders. First up: the C# program that takes user input and creates a 
 * Mad Libs story. It should read user inputs and use concatenation in its
 * Console.WriteLine or return commands. */