using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectF.Day6
{
    internal class Arrayone
    {

        public static void FirstMethod()
        {
            int[] sample = new int[10];
            //int a[] = new int[10]; // Illigal
            int i;
            for (i = 0; i < 10; i = i + 1)
                sample[i] = i * 5;
            for (i = 0; i < 10; i++)
                Console.WriteLine("sample[" + i + "]: " + sample[i]);
        }


        public static void SecondMethod()
        {
            int[] sample = new int[10];
            //int a[] = new int[10]; // Illigal
            int i;
            Random random = new Random();
            for (i = 0; i < 10; i = i + 1)
                sample[i] = random.Next(100);
            for (i = 0; i < 10; i++)
                Console.WriteLine("sample[" + i + "]: " + sample[i]);
            Console.WriteLine("Sum: "+ sample.Sum());
            Console.WriteLine("Average: "+sample.Average());
            Console.WriteLine("Max: "+ sample.Max());
            Console.WriteLine("Min: "+ sample.Min());
        }

        public static void ArrayOverRun()
        {
            int[] sample = new int[10];
            int i;
            // Generate an array overrun.
            for (i = 0; i < 100; i = i + 1)
                sample[i] = i;
            //IndexOutOfRangeException
        }

        public static void WorkingWithCharArray()
        {
            string s1 = "Today is a very hot day";
            char[] data = s1.ToCharArray();
            int count = data.Length;
            Console.WriteLine("Array Length " + count);
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(data[i]);
            }
        }

        public static void TwoD()
        {
            int t, i;
            int[,] table = new int[3, 4];//3 Rows - 4 Col
            for (t = 0; t < 3; ++t)
            {
                for (i = 0; i < 4; ++i)
                {
                    table[t, i] = t * 4 + i + 1;
                    Console.Write(table[t, i] + " ");
                }
                Console.WriteLine();
            }
        }

        //Jagged array int[][] jagged = new int [3] [];
        // jagged[0] = new int[4];
        // jagged[1] = new int[3];
        // jagged[2] = new int[5];

        public static void UsingJaggedArrays()
        {
            int[][] jagged = new int[3][];
            jagged[0] = new int[4];
            jagged[1] = new int[3];
            jagged[2] = new int[5];
            int i;
            // Store values in first array.
            for (i = 0; i < 4; i++)
                jagged[0][i] = i;
            // Store values in second array.
            for (i = 0; i < 3; i++)
                jagged[1][i] = i;
            // Store values in third array.
            for (i = 0; i < 5; i++)
                jagged[2][i] = i;
            // Display values in first array.
            for (i = 0; i < 4; i++)
                Console.Write(jagged[0][i] + " ");
            Console.WriteLine();
            // Display values in second array.
            for (i = 0; i < 3; i++)
                Console.Write(jagged[1][i] + " ");
            Console.WriteLine();
            // Display values in third array.
            for (i = 0; i < 5; i++)
                Console.Write(jagged[2][i] + " ");
            Console.WriteLine();
        }

        public static void SortingArrays()
        {
            int[] nos = { 32, 21, 10, 56, 87, 43, 97, 2 };
            Console.WriteLine("B4 sort ");
            int len = nos.Length;
            for (int i = 0; i < len; i++)
            {
                Console.Write(nos[i] + ",");
            }
            Console.WriteLine();
            Array.Sort(nos);
            Console.WriteLine("After sort ");



            len = nos.Length;
            for (int i = 0; i < len; i++)
            {
                Console.Write(nos[i] + ",");
            }
            Console.WriteLine();



        }
    }
}
