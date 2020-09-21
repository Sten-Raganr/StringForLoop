using System;

namespace StringForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            string helloworld = "Hello World!";

            Console.WriteLine(helloworld[0]);
            Console.WriteLine(helloworld[6]);

            int stringlength = helloworld.Length;

            Console.WriteLine($"Your text is {stringlength} symbols long:");

            char searchcriteria = 'o';

            int counter = 0;

            foreach (char letter in helloworld)

                if (letter == searchcriteria)

                    counter = counter += 1;

            Console.WriteLine($"There are {counter} Os in your text.");



        }
    }
}
