using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myInts = new int[3];

            myInts[0] = 4;
            myInts[2] = 10;

            for (int i = 0; i < myInts.Length; i++)
            {
              //  Console.WriteLine(myInts[i]);
            }

            int[] clonedArray;

            clonedArray = (int[]) myInts.Clone();

            // matrix

            int[,] matrix = new int[2, 3]; // 2 rows, 3 columns

            matrix[0, 0] = 0;
            matrix[0, 1] = 1;
            matrix[0, 2] = 2;

            matrix[1, 0] = 0;
            matrix[1, 1] = 1;
            matrix[1, 2] = 2;

            for (int row = 0; row < matrix.GetLength(0); row++) // i
            {
                for (int col = 0; col < matrix.GetLength(1); col++) // j
                {
                    Console.Write(matrix[row, col]);
                }

                Console.Write("\n");
            }

            string[] days = { "Luni", "Marti", "Miercuri", "Joi", "Sambata", "Duminica" };

            //  string[] secondDays = days; the changes will reflect here
            string[] secondDays = (string[]) days.Clone();

            int marti = Array.IndexOf(days, "Marti");
            int Lastmarti = Array.LastIndexOf(days, "Marti");

            Array.Clear(days, 2, 2);

        }
    }
}
