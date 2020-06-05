using System;

namespace MethodMan
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Hello handsome! What's your name");

            var name = Console.ReadLine();

            Console.WriteLine($"Good day to you, {name}!");
        }
    }
}
/* Okay, peep this out: this exercise ties in with the Methods prompt from
 * TrueCoders. First up: the C# program that takes user input and creates a 
 * Mad Libs story. It should read user inputs and use concatenation in its
 * Console.WriteLine or return commands. */