using System;

namespace Opgave2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*int count = 100;
            char pad = ' ';
            int c = 1;
            for (int j = 1; j <= 10; j++) { 
                for (int i = 1; i <= 10; i++)
                {
                    string a = (i*j).ToString();
                    Console.Write(a.PadLeft(5, pad));

                }

            }*/

            char pad = ' ';

            for (int i = 0; i < 10 * 10; ++i)
            {
                int a = i / 10 + 1;
                int b = i % 10 + 1;
                string c = (a * b).ToString();
                Console.Write(c.PadLeft(5, pad));
                //Console.Write(a * b);
            }
        }
    }
}
