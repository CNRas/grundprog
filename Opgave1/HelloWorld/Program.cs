using System;

namespace HelloWorld
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string nameF;
            string nameL;
            int age;
            char sex;
            int old;

            Console.WriteLine("Er du gammel testen!");
            Console.WriteLine("Hvad er dit fornavn?");
            nameF = Console.ReadLine();
            Console.WriteLine("Hvad er dit efternavn?");
            nameL = Console.ReadLine();
            Console.WriteLine("Hvor gammel er du?");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Er du mand (skriv m) eller kvinde (skriv k)?");
            sex = char.Parse(Console.ReadLine());
            //Console.WriteLine("Dit navn er"+nameF+" "+nameL+"Du er "+age+"år gammel. Du er en "+ );
            Console.WriteLine("Hvornår er man gammel?");
            old = int.Parse(Console.ReadLine());


            int diff = old - age;

            if (age < old)
            {
                Console.WriteLine(nameF+" "+nameL+",du er ikke gammel, men det bliver du om " + diff+"ar altsa i "+(2019+diff)+".");
            }else
            {
                if (sex == 'm')
                {
                    Console.WriteLine(nameF + " " + nameL + ", du er en gammel mand!");
                }

                if (sex == 'k')
                {
                    Console.WriteLine(nameF + " " + nameL + ", du er en gammel dame!");
                }
            }
        }
    }
}
