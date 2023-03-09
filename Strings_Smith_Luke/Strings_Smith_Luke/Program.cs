using System;

namespace Strings_Smith_Luke
{
    class Program
    {
        static void Main(string[] args)
        {
            //asks for character
            Console.WriteLine("Please input a character");
            //saves character
            char myChar = Console.ReadKey().KeyChar;
            //figures out if it's a letter
            bool isLetter = Char.IsLetter(myChar);
            //writes whether it's a letter or not
            Console.WriteLine($"\n {myChar} is a letter {isLetter}");

            //asks for some text and reads it
            Console.WriteLine("Please input some text");
            string string1 = Console.ReadLine();
            //asks for a specific word and reads it
            Console.WriteLine("Now enter a word for us to search for");
            string string2 = Console.ReadLine();
            //figures out is string1 contains string2
            bool boolean = string1.Contains(string2);

            //prints whether string2 exists in string1
            Console.WriteLine($"{string2} exists in {string1} {boolean}");
        }
    }
}
