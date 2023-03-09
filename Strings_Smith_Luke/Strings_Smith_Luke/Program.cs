using System;

namespace Strings_Smith_Luke
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a character");
            char myChar = Console.ReadKey().KeyChar;
            bool isLetter = Char.IsLetter(myChar);
            Console.WriteLine($"\n {myChar} is a letter {isLetter}");

            Console.WriteLine("Please input some text");
            string string1 = Console.ReadLine();
            Console.WriteLine("Now enter a word for us to search for");
            string string2 = Console.ReadLine();
            bool boolean = string1.Contains(string2);

            Console.WriteLine($"{string2} exists in {string1} {boolean}");
        }
    }
}
