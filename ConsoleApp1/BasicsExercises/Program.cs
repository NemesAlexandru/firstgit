using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicsExercises
{
    class Program
    {
        static void Main(string[] args)
        {


            problem10();

        }

        static void problem1()
        {
            // Write a program that reads from the console three numbers of type int and prints their sum.

            int a;
            int b;
            int c;

            Console.WriteLine("Input 1st number");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Input 2nd number");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Input 3rd number");
            c = int.Parse(Console.ReadLine());

            int sum = a + b + c;

            Console.WriteLine("sum = " + sum);
        }

        static void problem2()
        {
            // Write a program that reads five numbers from the console and prints the greatest of them.

            int a;
            int b;
            int c;
            int d;
            int e;

            var list = new List<int>();

            Console.WriteLine("Input 1st number");
            a = int.Parse(Console.ReadLine());
            list.Add(a);

            Console.WriteLine("Input 2nd number");
            b = int.Parse(Console.ReadLine());
            list.Add(b);

            Console.WriteLine("Input 3rd number");
            c = int.Parse(Console.ReadLine());
            list.Add(c);

            Console.WriteLine("Input 4th number");
            d = int.Parse(Console.ReadLine());
            list.Add(d);

            Console.WriteLine("Input 5th number");
            e = int.Parse(Console.ReadLine());

            list.Add(e);
            list.Sort();
            list.Reverse();

            Console.WriteLine(list[0]);
        }

        static void problem3()
        {
            //  Write a program that reads from the console the radius "r" of a circle and prints its perimeter and area.

            /*
             Perimeter (P) = 2 · π · R
             where:
             R  is the radius of the circle
             π  is Pi, approximately 3.142
              */

            var pi = Math.PI;

            Console.WriteLine("Input radius");
            int radius = int.Parse(Console.ReadLine());

            double perimeter = 2 * pi * radius;
            Console.WriteLine("Perimeter = " + perimeter);

            /* 
             And for the area of the circle:-

             A = π r2
             */

            double area = pi * (Math.Pow(radius, 2));
            Console.WriteLine("Area = " + area);
        }

        static void problem4()
        {
            /*   Write a program that reads from the console two integer numbers(int) and prints how many numbers 
                 between them exist that are divisible with 5.such that the remainder of their division by 5 is 0.

                 Example: in the range(14, 25) there are 3 such numbers: 15, 20 and 25. */

            int a;
            int b;
          

            Console.WriteLine("Input 1st number");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Input 2nd number");
            b = int.Parse(Console.ReadLine());

            List<int> results = new List<int>();

            for(int i = a; i < b; i++)
            {
                if(i % 5 == 0)
                {
                    results.Add(i);
                }

            }

            Console.WriteLine($"Numbers divisible by 5 from {a} to {b} = " + String.Join(", ", results));
        }

        static void problem5()
        {
            /* Write a program that reads two numbers from the console and prints the greater of them. 
             * Solve the problem without using conditional statements and with conditional statements.*/

            // with conditional statement:

            int a;
            int b;
           
            Console.WriteLine("Input 1st number");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Input 2nd number");
            b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine(a);
            }
            else {
                Console.WriteLine(b);
            }

            // without conditional statement:

            var list = new List<int>();
            list.Add(a);
            list.Add(b);

            list.Sort();
            list.Reverse();

            Console.WriteLine(list[0]);


        }

        static void problem6() {

            /* Write a program that reads five integer numbers and prints their sum. 
             * If an invalid number is entered the program should prompt the user to enter another number(only once) */

   
            var valueFromUser = "";
            int sum = 0;
            int number = 0;
       


            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine($"input {i + 1} number");
                valueFromUser = Console.ReadLine();


                if (!int.TryParse(valueFromUser, out number))
                {
                    Console.WriteLine($"format of input {i + 1} was incorrect, retry");
                    valueFromUser = Console.ReadLine();
                    number = int.Parse(valueFromUser);
                    sum += number;
                }
                else
                {
                    sum += number;
                }

            }

            Console.WriteLine($"sum of numbers = {sum}");
    
        }

        static void problem7()
        {
            /* Write a program that prints on the console the numbers from 1 to N. The number N should be read from the standard input. */

            int a;

            Console.WriteLine("Input N");
            a = int.Parse(Console.ReadLine());

            for(int i = 0; i < a; i++)
            {
                Console.WriteLine($"{i}");
            }
        }

        static void problem8()
        {
            /* Write a program that prints on the console the numbers from 1 to N, which are not divisible by 3 and 7 simultaneously. 
             * The number N should be read from the standard input. */

            int inputNumber;

            Console.WriteLine("Input N");
            inputNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputNumber; i++)
            {
                if (!(i % 3 == 0 && i % 7 == 0))
                {
                    Console.WriteLine($"not divisible by 3 and 7 simultaneously: {i}");

                }
                
            }

        }

        static void problem9()
        {
            // Write a program that reads from the console a series of 5 integers and prints the smallest and largest of them.

            var arr = new int[5];
            int num;

            for(int i = 0; i < 5; i++)
            {

                Console.WriteLine($"input {i + 1} number");
                num = int.Parse(Console.ReadLine());
                arr[i] = num;

            }

            Console.WriteLine($"max number = {arr.Max()}");
            Console.WriteLine($"min number = {arr.Min()}");
        }

        static void problem10()
        {
            /* Write program that outputs a triangle made of stars with variable size, depending on an input parameter. Look at the examples to get an idea. 
             * The input comes as a string number, which needs to be parsed to a number. The output is a series of lines printed on the console, forming a triangle of variable size. */

            Console.WriteLine("input number");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i < num; i++)
            {
                Console.WriteLine("*");
                repeat(i, num);

                if(num - i == 1)
                {
                    // if we are at the last element

                    for (int j = num - 1; j > 0; j--)
                    {
                        
                        repeatDescending(j);
                      
                    }
                }
            }       

            static void repeat(int count, int num)
            {
                for (int i = 0; i < count; i++)
                {

                    Console.Write("*");

                    if (num - i == 2)
                    {
                        Console.Write("*");
                        Console.WriteLine();
                    }
                } 
            }
            static void repeatDescending(int count)
            {
                var builder = new StringBuilder();

                for(int i = 0; i < count; i++)
                {
                    builder.Append("*");
                }
   
                Console.WriteLine($"{builder}");

            }
        }

        static void problem12()
        {
            /* Write a program that by a given integer N prints the numbers from 1 to N in random order */

            int a;
            int b;
            

            Console.WriteLine("Input 1st number");
            a = int.Parse(Console.ReadLine()); 

            Console.WriteLine("Input 2nd number");
            b = int.Parse(Console.ReadLine());

            int count = b - a;
            int index = 0;

            HashSet<int> SetAlreadyPrinted = new HashSet<int>();
            Random random = new Random();

            while(index < count)
            {

                var randomValue = random.Next(a, b);

                bool alreadyPrinted = checkIfAlreadyPrinted(randomValue, SetAlreadyPrinted);

                if (!alreadyPrinted)
                {
                    Console.WriteLine($"{randomValue}");
                    SetAlreadyPrinted.Add(randomValue);
                    index++;
                }
                
            }

            static bool checkIfAlreadyPrinted(int value, HashSet<int> setAlreadyPrinted)
            {
                if (!setAlreadyPrinted.Add(value))
                {
                    return true;

                }

                return false;
            }
        }

        static void problem13()
        {

            /* A program which iterates the integers from 1 to 50 For multiples of three print "Fizz" instead of the number and for the multiples of five print "Buzz". 
             * For numbers which are multiples of both three and five print "FizzBuzz". */

            for(int i = 1; i < 50; i++) {


                if (i % 5 == 0 && i % 3 == 0)
                {
                    Console.WriteLine("FizzBuzz");

                } else if (i % 5 == 0) {

                    Console.WriteLine("Buzz");
                }
                else if (i % 3 == 0)
                {

                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine($"{i}");
                }              

            }

        }
    }
}
