using System;
using System.Text.RegularExpressions;
using System.Text;
using System.Collections.Generic;

namespace Opgave4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double result = 0;

            Console.WriteLine("Indtast et tal:");
            double talEt = int.Parse(Console.ReadLine());
            Console.WriteLine("Indtast et tal mere:");
            double talTo = int.Parse(Console.ReadLine());
            Console.WriteLine("Indtast din nummerator:");
            char numme = char.Parse(Console.ReadLine());

            switch (numme)
            {
                case '+':
                    result = talEt + talTo;
                    Console.WriteLine(result);
                    break;
                case '-':
                    result = talEt - talTo;
                    Console.WriteLine(result);
                    break;
                case '*':
                    result = talEt * talTo;
                    Console.WriteLine(result);
                    break;
                case '/':
                    result = talEt / talTo;
                    Console.WriteLine(result);
                    break;
            }
            while (true)
            {
                Console.WriteLine("Send e for at slutte eller operator for at regne videre fra " + result);
                numme = char.Parse(Console.ReadLine());
                if (numme == 'e')
                {
                    break;
                }
                else
                {
                    talEt = result;
                    Console.WriteLine("Indtast et tal mere:");
                    talTo = int.Parse(Console.ReadLine());

                    switch (numme)
                    {
                        case '+':
                            result = talEt + talTo;
                            Console.WriteLine(result);
                            break;
                        case '-':
                            result = talEt - talTo;
                            Console.WriteLine(result);
                            break;
                        case '*':
                            result = talEt * talTo;
                            Console.WriteLine(result);
                            break;
                        case '/':
                            result = talEt / talTo;
                            Console.WriteLine(result);
                            break;
                    }
                }
            }
            
            
                /*Console.WriteLine("Indtast et regnestykke:");
                string input = Console.ReadLine();
                string[] splitInput = input.Split(new Char[] {'+','-','*','/'});
                string[] splitInput2 = input.Split(new Char[] {'1','2','3','4','5','6','7','8','9','0'});
                foreach (string num in splitInput)
                {
                    Console.WriteLine(num);
                }

                List<string> add_list = new List<string>();
                
                
                foreach (string tegn in splitInput2)
                {
                    if (tegn != "")
                    {
                        add_list.Add(tegn);
                    }
                }

                string[] operators = add_list.ToArray();
                //Console.WriteLine(operators);

                foreach (string b in operators)
                {
                    Console.WriteLine(b);
                }


                /*Console.WriteLine("Indtast et regnestykke:");
                string input = Console.ReadLine();
                string[] numbers = Regex.Split(input, @"\D");
                string[] ops = Regex.Split(input, @"\w");
                //string opsNy = ops[0] + ops[1];
                //Console.WriteLine(numbers[0] + ops[0] + numbers[1]+ops[1]+numbers[2]);
                Console.WriteLine(numbers.Length);
                Console.WriteLine(ops.Length);
                //Console.WriteLine(opsNy);

                foreach (string b in numbers)
                {
                    Console.WriteLine(b);
                }

                foreach (string a in ops)
                {
                    Console.WriteLine(a);
                }


                //int talEt = int.Parse(arr1[0]);
                //int talTo = int.Parse(arr1[1]);
                /*Console.WriteLine(arr1[0]);
                Console.WriteLine(arr1[1]);
                Console.WriteLine(arr1[2]);
                Console.WriteLine(arr2[0]);
                Console.WriteLine(arr2[1]);
                Console.WriteLine(arr2[2]);
                Console.WriteLine("Indtast et tal mere:");
                int talTo = int.Parse(Console.ReadLine());
                Console.WriteLine("Indtast din nummerator:");
                char numme = char.Parse(Console.ReadLine());

                 
                Console.WriteLine("{0}" + "{1}" + "{2}",talEt,(numme),talTo);
                
            } */
        }
    }
}
