using System;

namespace opgave7
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int arraySize = 1001;
            int[] arrA = new int[arraySize];
            Random number = new Random();

            for (int i = 0; i < arraySize; i+=2) //Laver et array med arraySize antal pladser
            {                                    //og fylder det ud med random tal-par bortset
                int numberToArray = 2;           //fra ét.
                while (numberToArray % 2 == 0)
                {
                    numberToArray = number.Next(1, 1000001);
                }
                if (i < arraySize - 1)
                {
                    int g = 0;
                    int arraySlot = number.Next(0, arraySize); //Giver tallene en tilfældig
                    while (g < 2)                              //tom plads i arrayet
                    {
                        if (arrA[arraySlot] == 0)
                        {
                            arrA[arraySlot] = numberToArray;
                            g++;
                        }
                        else
                        {
                            arraySlot = number.Next(0, arraySize);
                        }
                    }
                }
                else
                {
                    for (int a = 0; a < arraySize; a++)
                    {
                        if (arrA[a] == 0)
                        {
                           arrA[a] = numberToArray;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    
                }
            }

            Console.WriteLine("Here is an array with " + arraySize + " values:");
            foreach (int a in arrA)
            {
                Console.Write(a);
                Console.Write("  ");
            }

            int lonelyNum = loneNumber(arrA);
            Console.WriteLine("\nThe only single number is: "+lonelyNum);
        }

        public static int loneNumber(int[] array) //Returnerer det ensomme tal uden makker
        {
            int correct = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int a = 0; a < array.Length; a++)
                {
                    if (i == a)
                    {
                        continue;
                    }
                    else
                    {
                        if (a == array.Length - 1 && array[i] != array[a])
                        {
                            correct = array[i];
                            break;
                        }
                        if (array[i] == array[a])
                        {
                            break;
                        }
                    }
                }
            }
            return correct;
        
        }
    }
}
