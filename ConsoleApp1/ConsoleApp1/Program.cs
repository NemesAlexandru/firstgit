using System;
using System.Diagnostics;
using System.Globalization;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello World! Test");

            string myString = "Hello";
            string myNextString = "World";

            string a = "a";
            string b = "b";
            string c = "c";
            string random = "B";

            int resultLeft = string.Compare(a, b);
            int resultRight = string.Compare(c, b);
            int resultEqual = string.Compare(random, b, true);

            //Concat

            myString = myString + " world";
            string helloWorld = myString + " " + myNextString;

            Stopwatch stopWatch = Stopwatch.StartNew();

            stopWatch.Start();

         /*   for (int i = 0; i < 100000; i++)
            {

                myString += i;

            } */

            stopWatch.Stop();
            Console.WriteLine(stopWatch.Elapsed);

            Stopwatch stopWatch1 = Stopwatch.StartNew();
            stopWatch1.Start();

            StringBuilder builder = new StringBuilder();
            builder.Append(myString);
          /*  for(int i = 0; i < 100000; i++)
            {
                builder.Append(i);
            } */

            stopWatch1.Stop();
           // Console.WriteLine("For stringBuilder = " + stopWatch1.Elapsed);

            string myString2 = "This is an awesome string";

            int indexOfThis = myString2.IndexOf("This");
            int lastIndexOf = myString2.LastIndexOf("This");

            string path = "C:/Program Files/Windows";
            string programFiles = path.Substring(3, 12);
            string res = path.Substring(3);


            var splitted = path.Split('/');

            int awesomeInt = 1343253234;

            CultureInfo culture = new CultureInfo("tr-TR");
            string awesomeIntCulture = awesomeInt.ToString("C", culture);

            int oldInt = int.Parse(awesomeIntCulture, culture);

            int parsed = 0;

            bool success = int.TryParse(awesomeIntCulture, out parsed);
            
        }
    }
}
