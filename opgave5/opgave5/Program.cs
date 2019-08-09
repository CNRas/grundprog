using System;

namespace opgave5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Write location X, location Y and jump distance seperated by ','.");
            string input = Console.ReadLine();
            string[] splitInput = input.Split(new Char[] { ',' });
            int x = int.Parse(splitInput[0]);
            int y = int.Parse(splitInput[1]);
            int d = int.Parse(splitInput[2]);
            int jumps = travel(x, y, d);
            Console.WriteLine("To jump from {0} to {1}, the frog has to use {2} jumps.",x,y,jumps);
        }


        public static int travel(int x, int y, int d)
        {
            int jumps = (y - x) / d;
            if ((y-x)%d != 0)
            {
                jumps++;
            }
            return jumps;
        }
    }
}
