using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2codingchallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 20; i++)
            {FizzBuzz(i);}
            Console.ReadKey();
            LetterCounter('i', "I love biscuits and gravy. It’s the best breakfast ever.");
            LetterCounter('n', "Never gonna give you up. Never gonna let you down.");
            LetterCounter('s', "Sally sells seashells down by the seashore. She’s from Sussex.");
            Console.ReadKey();
            TextStats("This is a. Three sentence. String.");
            Console.ReadKey();
        }
        static void FizzBuzz(int num)
        {
            if (num % 5 == 0 && num % 3 == 0)
            {
                Console.WriteLine(num + ": FizzBuzz!");
            }
            else if (num % 5 == 0)
            {
                Console.WriteLine(num + ": Fizz!");
            }

            else if (num % 3 == 0)
            {
                Console.WriteLine(num + ": Buzz!");
            }
            else Console.WriteLine(num);
        }
        static void LetterCounter(char letter, string inString)
        {
            int lcounter = 0;
            int ucounter = 0;
            foreach (char a in inString)
            {
                if (a == letter)
                {
                    lcounter = lcounter + 1;
                }
                string upperChar = a.ToString().ToUpper();
                string stringLetter = letter.ToString().ToUpper();
                char l = stringLetter[0];
                char b = upperChar[0];
                if (b == l)
                {
                    ucounter = ucounter + 1;
                }
                
            }
            Console.WriteLine("Input : " + inString);
            Console.WriteLine("there are " + lcounter + " lower case " + letter + "'s");
            Console.WriteLine("there are " + (ucounter - lcounter) + " upper case " + letter + "'s");
            Console.WriteLine("total number of " + letter + "'s: " + ucounter);
        }
        static void TextStats(string input)
        {
            int a = 0;
            int v = 0;
            int d = 0;
            int f = 0;
            int g = 0;
            var textlist = input.Split(' ').ToList();

            for (int i = 0; i < textlist.Count(); i++)
            {
                a = textlist[i].Length + a;
                foreach (char c in textlist[i])
                {
                    string x = c.ToString().ToLower();
                    if (x == "i" || x == "a" || x == "e" || x == "o" || x == "u")
                    {

                        v = 1 + v;

                    }
                    else if (x == "b" || x == "c" || x == "d" || x == "f" || x == "g" || x == "h" || x == "j" || x == "k" || x == "l" || x == "m" || x == "n" || x == "p" || x == "q" || x == "r" || x == "s" || x == "t" || x == "v" || x == "w" || x == "x" || x == "y" || x == "z")
                    {
                        d = d + 1;
                    }
                    else if (x == "1" || x == "2" || x == "3" || x == "4" || x == "5" || x == "6" || x == "6" || x == "8" || x == "9")
                    {
                        f = f + 1;
                    }
                    else g = g + 1;



                    ;
                }
            }
            string[] array = input.Split(' ');
           
            Array.Sort(array, (x1, x2) => x1.Length.CompareTo(x2.Length));

            Console.WriteLine("number of specil chars = " + g);
            Console.WriteLine("number of numbers =" + f);
            Console.WriteLine("# of cons = " + d);
            Console.WriteLine("# of vowels = " + v);
            Console.WriteLine("total characters = " + a);
            Console.WriteLine("total words = " + textlist.Count());
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("shortest = " + array[i]);
            }
            for (int i = array.Length-1; i > array.Length-2; i--)
            {
                Console.WriteLine("longest = " + array[i]);
            }
            //Console.WriteLine(array);


        }//end of text stats
    }
}
