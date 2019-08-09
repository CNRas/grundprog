using System;
using System.Threading;

namespace opgave6
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int arraySize = 10;
            int rotations = 1;
            int[] arrA = new int[arraySize];
            Random number = new Random();

            for (int i = 0; i < arraySize; i++)
            {
                arrA[i] = number.Next(-1000,1001);
            }

            Console.WriteLine("Here is an array with " + arraySize + " values:");
            foreach (int a in arrA)
            {
                Console.Write(a);
                Console.Write("  ");
            }

            Console.WriteLine("\nHere is the array rotated " + rotations + " spaces:");
            

            foreach (int b in RotatedArr(arrA, rotations))
            {
                Console.Write(b);
                Console.Write("  ");
            }
            

        }
        private static int[] RotatedArr(int[] array, int r)
        {
            int[] arrB = new int[array.Length];
            int c = 0;
            foreach (int b in array)
            {
                arrB[(c+r)%array.Length] = array[c];
                c++;
            }

            return arrB;
        }
    }
}
