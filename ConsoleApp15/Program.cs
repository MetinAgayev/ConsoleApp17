using System;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            WordReverser reverser = new WordReverser();
            Console.WriteLine(reverser.ReverseWord("Hello World"));
        }

    }
    
}
