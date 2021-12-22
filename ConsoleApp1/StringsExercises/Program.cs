using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;

namespace StringsExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            LastPart4();
        }

        static void problem1()
        {
            /* Write a method that to remove the nth index character from a nonempty string. */

            string a;
            int index;

            Console.WriteLine("input 1st string");
            a = Console.ReadLine();

            Console.WriteLine("input index");
            index = int.Parse(Console.ReadLine());

            removeNthChar(a, index);

            static void removeNthChar(string str, int index)
            {
                StringBuilder strBuilder = new StringBuilder();
                
                for(int i = 0; i < str.Length; i++)
                {
                    if (i != index)
                    {
                        strBuilder.Append(str[i]);
                    }
                }
               
                Console.WriteLine(strBuilder);
            }

        }

        static void problem2()
        {
            /* Write a method that to remove the characters which have odd index values of a given string. */

            string a;
            
            Console.WriteLine("input 1st string");
            a = Console.ReadLine();

            removeOddIndexChar(a);

            static void removeOddIndexChar(string str)
            {
                StringBuilder strBuilder = new StringBuilder();

                for (int i = 0; i < str.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        strBuilder.Append(str[i]);
                    }
                }

                Console.WriteLine(strBuilder);
            }

        }

        static void problem3()
        {
            /* Write a method that takes input from the user and displays that input back in upper and lower cases. */

            string a;

            Console.WriteLine("input 1st string");
            a = Console.ReadLine();

            StringBuilder builder = new StringBuilder();

            for(int i = a.Length - 1; i >= 0; i--)
            {
                builder.Append(a[i]);
            }

            Console.WriteLine(builder.ToString().ToUpper());
            Console.WriteLine(builder.ToString().ToLower());
        }

        static void problem4()
        {
            /* Write a method that reverses a string if it's length is a multiple of 4 */

            string a;

            Console.WriteLine("input 1st string");
            a = Console.ReadLine();

            if (a.Length % 4 == 0)
            {
                StringBuilder builder = new StringBuilder();

                for (int i = a.Length - 1; i >= 0; i--)
                {
                    builder.Append(a[i]);
                }

                Console.WriteLine(builder.ToString());

            }
            else
            {
                Console.WriteLine("string length is not multiple of 4!");
            }


        }

        static void problem5()
        {
            /* Write method to convert a given string to all uppercase if it contains at least 2 uppercase characters in the first 4 characters. */

            string a;

            Console.WriteLine("input 1st string");
            a = Console.ReadLine();

            int countUpper = 0;

            for(int i = 0; i < a.Length; i++)
            {
                if(i == 3)
                {
                    break;
                }

               bool IsUpper = isUpper(a[i]);

                if (IsUpper)
                {
                    countUpper++;
                }
            }

            if (countUpper >= 2)
            {
                Console.WriteLine($"{a.ToUpper()}");

            }
            else {
                Console.WriteLine("didn't contain at least 2 uppercase chars in the first 4 characters!");
            }

            static bool isUpper(char ch)
            {
                if (Char.IsUpper(ch))
                {
                    return true;
                }

                return false;
            } 
        }

        static void problem6()
        {
            /*  Write a method that to remove a newline. */

            string a;

           

            var example = @"


Hello,



World!



";
            a = example;
            string clean = a.Replace("\n", "").Replace("\r", "");

            Console.WriteLine(clean);
        }

        static void problem7()
        {
            /* Write a method to display formatted text (width=50) as output. 
             * For example: If I have a text that's 134 characters long, 
             * the formatted string should have maximum of 50 characters per line. In this case we will have 3 lines of text. */

            string text = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa aaaaaaaaaaaasds sdasdsasdsaaaaaaaaaaaaa";
            int count = 0;

            StringBuilder builder = new StringBuilder();

            foreach(char el in text)
            {
                bool IsAtLimit = isAtLimit(count);
                if (!IsAtLimit)
                {
                    builder.Append(el);
                    count++;
                }
                else {
                    builder.Append("\n");
                    count = 0;
                }              
            }

            Console.WriteLine(builder);

            static bool isAtLimit(int index)
            {
                if(index == 50)
                {
                    return true;
                }
                return false;
            }

        }

        static void problem8()
        {
            double number = 0.1234;

            Console.WriteLine("Percentage formatted number: " + number.ToString("P", CultureInfo.InvariantCulture));

        }

        static void problem9()
        {
            /* Write a method that reverses a string. */

            string a;
           

            Console.WriteLine("input 1st string");
            a = Console.ReadLine();

            StringBuilder builder = new StringBuilder();

            for(int i = a.Length - 1; i >= 0; i--)
            {
                builder.Append(a[i]);
            }

            Console.WriteLine(builder);

           

        }

        static void problem10()
        {
            /* Write a method that transforms to lowercase first n characters in a string */

            string str;
            int n;

            Console.WriteLine("input 1st string");
            str = Console.ReadLine();

            Console.WriteLine("input n characters");
            n = int.Parse(Console.ReadLine());

            string firstNChars = str.Substring(0, n);
            string lowerFirstNChars = firstNChars.ToLower();

            Console.WriteLine(lowerFirstNChars);
        }

        static void problem11()
        {
            /* Write a method to capitalize first and last letters of each word of a given string. */

            string a;

            Console.WriteLine("input 1st string");
            a = Console.ReadLine();

            StringBuilder builder = new StringBuilder();

            string[] words = a.Split(" ");

            foreach(string word in words)
            {
                char capFirstChar = Char.ToUpper(word[0]);
                char capLastChar = Char.ToUpper(word[word.Length - 1]);

                string newWord = capFirstChar + word.Substring(1, word.Length - 2) + capLastChar;

                builder.Append(newWord + " ");
            }
            Console.WriteLine(builder.ToString().Trim());
        }

        static void problem12()
        {
            /* Write a method to compute sum of digits of a given string(if any). */

            string a;

            Console.WriteLine("input 1st string");
            a = Console.ReadLine();

            string pattern = @"[\d]";
            Regex rgx = new Regex(pattern);

            if (rgx.IsMatch(a))
            {
                Console.WriteLine("Contains digits!");
                int sum = 0;

               var digits = rgx.Matches(a);

                foreach(var digit in digits)
                {
                    int element = int.Parse(digit.ToString());
                    sum += element;
                }

                Console.WriteLine($"sum of digits = {sum}");

            }
            else
            {

                Console.WriteLine("No digits!");
            }

        }

        static void CleanTheText()
        {
            /* You will get a text from where you will need to clean the text because it contains a lot of strange characters that don’t belong there ( ^ <, > &+ @%$) */

            string a;

            Console.WriteLine("input 1st string");
            a = Console.ReadLine();

            string clearedStr = Regex.Replace(a, @"[^0-9a-zA-Z:,]+", " ");

            Console.WriteLine(clearedStr);
        }

        static void IngLy()
        {
            /* Write a method to add 'ing' at the end of a given string (length should be at least 3). 
             * If the given string already ends with 'ing' then add 'ly' instead. If the string length of the given string is less than 3, leave it unchanged. */

            /*
             Input : 'abc'
             Output : 'abcing' 
             Input : 'string'
             Output: 'stringly' 
             */

            string a;

            Console.WriteLine("input 1st string");
            a = Console.ReadLine();

            if (a.Length < 3)
            {
                Console.WriteLine("length < 3");

            }
            else {


                bool endsWithLy = a.Substring(a.Length - 2).Equals("ly");

                bool endsWithIng = a.Substring(a.Length - 3).Equals("ing");
                string res;

                if (!(endsWithLy || endsWithIng))
                {

                    if (a.Length >= 3)
                    {
                        res = a + "ing";

                        Console.WriteLine(res);

                    }
                    else
                    {

                        Console.WriteLine("string length < 3...");
                    }

                }
                else
                {
                    Console.WriteLine("String already ends with ing or ly");
                }


            }
            
            

        }

        static void ObfucateEmail()
        {

            /* You have some text that contains your email address. And you want to hide that. You decide to censor your email: to replace all characters in it with asterisks ('*') except the domain.
             * Assume your email address will always be in format [username]@[domain]. 
             * You need to replace the username with asterisks of equal number of letters and keep the domain unchanged. You will get as input the email address you need to obfuscate */

            /* Input: awesome@dotnet.com
               Output: *******@dotnet.com */

            StringBuilder builder = new StringBuilder();

            string a;
            string res;

            Console.WriteLine("input 1st string");
            a = Console.ReadLine();

            var arr = a.Split('@');
            var countCharsFirstPart = arr[0].Length;

            for(int i = 0; i < countCharsFirstPart; i++)
            {
                builder.Append("*");

            }

            res = builder + "@" + arr[1];

            Console.WriteLine(res);
        }

        static void ReString()
        {
            /* Write a method to get a string made of the first 2 and the last 2 chars from a given a string. If the string length is less than 2, return instead of the empty string. */

            StringBuilder builder = new StringBuilder();

            string a;

            Console.WriteLine("input 1st string");
            a = Console.ReadLine();

            if (a.Length >= 2)
            {
                string first = a.Substring(0, 2);
                string last = a.Substring(a.Length - 2);

                Console.WriteLine(first + last);
            }
            else
            {
                Console.WriteLine("");

            }

        }

        static void ReplaceChar1()
        {

            /* Write a method to get a string from a given string where all occurrences of its first char have been changed to '$', except the first char itself. */

            /* Sample String : 'restart'
               Expected Result : 'resta$t' */

            StringBuilder builder = new StringBuilder();

            string a;

            Console.WriteLine("input 1st string");
            a = Console.ReadLine();

            char firstChar = a[0];

            string inputWithoutFirstChar = a.Substring(1);

            var res = firstChar + inputWithoutFirstChar.Replace(firstChar, '$');

            Console.WriteLine(res);

        }

        static void ReplaceChar2()
        {

            /* Write a method to get a single string from two given strings, separated by a space and swap the first two characters of each string. */

            /* Input: 'abc', 'xyz' 
               Output: 'xyc abz' */

            StringBuilder builder = new StringBuilder();

            string a;
            string b;

            Console.WriteLine("input 1st string");
            a = Console.ReadLine();

            string firstTwoA = a.Substring(0, 2);

            Console.WriteLine("input 2nd string");
            b = Console.ReadLine();

            string firstTwoB = b.Substring(0, 2);

            string res = builder.Append(firstTwoB).Append(a.Substring(2)).Append(" ").Append(firstTwoA).Append(b.Substring(2)).ToString();

            Console.WriteLine(res);

        }

        static void ReplaceChar3() {

            /* Write a method to find the first appearance of the substring 'not' and 'poor' from a given string, 
             * if 'not' follows the 'poor', replace the whole 'not'...'poor' substring with 'good'. Return the resulting string. */


            /* Input: 'The lyrics is not that poor!'
               Output : 'The lyrics is poor!'
               Input  : 'The lyrics is good!'
               Output : 'The lyrics is poor!' */

            StringBuilder builder = new StringBuilder();

            string a;
         

            Console.WriteLine("input 1st string");
            a = Console.ReadLine();

            var firstAppearanceOfNot = a.IndexOf("not");
            var firstAppearanceOfPoor = a.IndexOf("poor");

            if(firstAppearanceOfNot > 0 && firstAppearanceOfPoor > firstAppearanceOfNot)
            {
                // 'not' follows the 'poor'

                string firstPart = a.Substring(0, firstAppearanceOfNot);
                string secondPart = a.Substring(firstAppearanceOfPoor);

                string res = builder.Append(firstPart).Append(secondPart).ToString();

                Console.WriteLine(res) ;
            }else if (firstAppearanceOfNot == -1 && a.Contains("good"))
            {

                string res = a.Replace("good", "poor");
                Console.WriteLine(res);
            }
            else
            {
                Console.WriteLine("Doesn't contain not, poor, good substrings");
            }
        }

        static void LongestWord()
        {

            /* Write a method that takes a list of words and returns the length of the longest one. */

            var listOfWords = new List<String>() { "rest", "tst", "alabala", "point", "c", "environment" };

            var maxLength = listOfWords[0].Length;

            string longestWord = "";

            foreach (var word in listOfWords)
            {
                if (word.Length > maxLength)
                {
                    longestWord = word;
                    maxLength = word.Length;
                }

            }

            Console.WriteLine(longestWord);
        }

        static void Palindrome()
        {
            /* Check if a string is palindrome (same value read from left to right and right to left) Ex: alabala -> True */

            StringBuilder reverseA = new StringBuilder();

            string a;

            Console.WriteLine("input 1st string");
            a = Console.ReadLine();


            for(int i = a.Length - 1; i >= 0; i--)
            {

                reverseA.Append(a[i]);
            }

            int isPalindrome = a.CompareTo(reverseA.ToString());

            if (isPalindrome == 0) {
                Console.WriteLine("Palindrome!");
            }
            else
            {

                Console.WriteLine("Not Palindrome!");
            }
        }

        static void LastPart1()
        {
            /* Write a method to get the last part of a string before a specified character. */

            string a;
            char separator;

            Console.WriteLine("input 1st string");
            a = Console.ReadLine();

            Console.WriteLine("input separator");
            separator = char.Parse(Console.ReadLine());

            Console.WriteLine(a.Split(separator)[0]);

        }

        static void LastPart2()
        {
            /* Write a method to check whether a string starts with specified characters */

            string a;
            char inputChar;

            Console.WriteLine("input 1st string");
            a = Console.ReadLine();

            Console.WriteLine("input char");
            inputChar = char.Parse(Console.ReadLine());

            if (a[0] == inputChar)
            {

                Console.WriteLine(a + " starts with char " + inputChar);
            }
            else {
                Console.WriteLine(a + " doesn't start with char " + inputChar);
            }
        }

        static void LastPart3()
        {
            /* Write a method to count occurrences of a substring in a string */

            string a;
            string smallString;

            Console.WriteLine("input 1st string");
            a = Console.ReadLine();

            Console.WriteLine("input substring");
            smallString = Console.ReadLine();

            var pattern = $"({smallString})";

            Regex rgx = new Regex(pattern);

           var occurencesOfSubstring = rgx.Matches(a).Count();

            Console.WriteLine(String.Join(", ", rgx.Matches(a)));

            Console.WriteLine(occurencesOfSubstring);

        }

        static void LastPart4()
        {
            /* Write a method to swap comma and dot in a string. */

            string a;
        

            Console.WriteLine("input 1st string");
            a = Console.ReadLine();

            StringBuilder replaced = new StringBuilder();

            foreach(char ch in a)
            {
                if (ch == '.')
                {
                    replaced.Append(',');

                }else if (ch == ',')
                {
                    replaced.Append('.');
                }
                else
                {
                    replaced.Append(ch);
                }
                

            }

            Console.WriteLine(replaced);

        }

        static void LastPart5()
        {
            /* Write a method to remove spaces from a given string. */

            string a;


            Console.WriteLine("input 1st string");
            a = Console.ReadLine();

            var removedSpaces = a.Replace(" ", "");

            Console.WriteLine(removedSpaces);

        }
    }
}
