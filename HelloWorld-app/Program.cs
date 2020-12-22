using System;

namespace C__Crash_Course
{
    public class HelloWorld
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name? ");
            var firstName = Console.ReadLine();
            int age = 25;
            double rate = .02;
            char middleInitial = 'R';
            bool isUnderstanding = false;
            string lastName = "McCann";
            var date = DateTime.Now;
            string stringTwo = "HelloWorld";
            string greeting = "Hello, I'm communicating through the console.";
            Console.WriteLine(($"Hello, {firstName} {middleInitial} {lastName}, you are {age} years old. You are understanding this lang at a rate of {rate}, which means that it is {isUnderstanding} that you know anything. This is as of {date:d} at {date:t}!!! Oh and {stringTwo}.").ToLower());
            Console.WriteLine($"string lastName contains ann? {lastName.Contains("ann")}");
            Console.WriteLine($"The sum of 5 and 8 is {5 + 8}");
            Console.WriteLine($"greeting to upper :  {greeting.ToUpper()}");
            Console.WriteLine(greeting.Substring(7));
            Console.Write("Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}
