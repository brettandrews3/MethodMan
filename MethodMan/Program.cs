using System;

namespace MethodMan
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Hello handsome! What's your name?");
            var name = Console.ReadLine();
            Console.WriteLine($"Good day to you, {name}!");

            Console.WriteLine($"Next up, {name}: name a color that you like:");
            var color = Console.ReadLine();
            Console.WriteLine($"Your color is {color}. Got it. Next...");

            Console.WriteLine("What's your favorite type of animal?");
            var animal = Console.ReadLine();
            Console.WriteLine($"You like {animal}s, too? Awesome!");
        }
    }
}
/* Okay, peep this out: this exercise ties in with the Methods prompt from
 * TrueCoders. First up: the C# program that takes user input and creates a 
 * Mad Libs story. It should read user inputs and use concatenation in its
 * Console.WriteLine or return commands. */