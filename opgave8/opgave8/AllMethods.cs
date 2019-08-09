using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace opgave8
{
    public class AllMethods
    {
        public static string Menu()
        {
            return  "###############################" +
                    "\n##                           ##" +
                    "\n## Welcome to the Math Game! ##" +
                    "\n## Press 'enter' to quit or  ##" +
                    "\n##     select a category:    ##" +
                    "\n##                           ##" +
                    "\n##     1 - Addition          ##" +
                    "\n##     2 - Substraction      ##" +
                    "\n##     3 - Multiplication    ##" +
                    "\n##     4 - Division          ##" +
                    "\n##     H - Highscore         ##" +
                    "\n##                           ##" +
                    "\n###############################";
        }

        public static int Discipline() //Bestemmer hvilken desciplin man har valgt
        {
            var info = Console.ReadKey();
            switch (info.Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("\nYou chose addition!");
                    return 1;

                case ConsoleKey.D2:
                    Console.WriteLine("\nYou chose substraction!");
                    return 2;

                case ConsoleKey.D3:
                    Console.WriteLine("\nYou chose multiplication!");
                    return 3;

                case ConsoleKey.D4:
                    Console.WriteLine("\nYou chose division!");
                    return 4;

                case ConsoleKey.H:
                    return 5;

                default:
                    return 0;
            }
        }
        
        public static int Difficulty() //Bestemmer sværhedsgrad
        {
            Console.WriteLine("\nChoose the difficulty:" +
                              "\n1 - Numbers between 1-10." +
                              "\n2 - Numbers between 1-100. Double the points!" +
                              "\n3 - Numbers between 1-1000. Triple the points!" +
                              "\n4 - Numbers between 1-9999. Quadruple the points!");

            var info = Console.ReadKey();
            switch (info.Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("\nYou chose difficulty 1!");
                    return 1;

                case ConsoleKey.D2:
                    Console.WriteLine("\nYou chose difficulty 2!");
                    return 2;

                case ConsoleKey.D3:
                    Console.WriteLine("\nYou chose difficulty 3!");
                    return 3;

                case ConsoleKey.D4:
                    Console.WriteLine("\nYou chose difficulty 4!");
                    return 4;
                default:
                    return 0;
            }
        }

        public static float Calculation(int type, int diff) //Kommer med en operation som skal regnes ud og resultat
        {
            Random number = new Random();
            int numberA = 0;
            int numberB = 0;

            switch(diff)
            {
                case 1:
                    numberA = number.Next(1, 11);
                    numberB = number.Next(1, 11);
                    break;
                case 2:
                    numberA = number.Next(1, 101);
                    numberB = number.Next(1, 101);
                    break;
                case 3:
                    numberA = number.Next(1, 1001);
                    numberB = number.Next(1, 1001);
                    break;
                case 4:
                    numberA = number.Next(1, 10000);
                    numberB = number.Next(1, 10000);
                    break;
            }

            switch (type)
            {
                case 1:
                    Console.Write("What is {0}+{1}?\n", numberA, numberB);
                    return numberA + numberB;
                case 2:
                    Console.Write("What is {0}-{1}?\n", numberA, numberB);
                    return numberA - numberB;
                case 3:
                    Console.Write("What is {0}*{1}?\n", numberA, numberB);
                    return numberA * numberB;
                case 4:
                    Console.Write("What is {0}/{1}?\n", numberA, numberB);
                    float divRes = (float)numberA / numberB;
                    return (float)Math.Round(divRes, 2, MidpointRounding.ToEven);
                default:
                    return 0;
            }

        }

        public static void addScore(string name, int score, string filepath)
        {
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@filepath, true))
                {
                    file.WriteLine(score + "," + name);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error:", ex);
            }
            
        }


        public static void showHighScore(string filepath)
        {
            Console.WriteLine("###############################" +
                              "\n##         HIGHSCORE         ##\n");
            try
            {
                string[] lines = System.IO.File.ReadAllLines(@filepath);
                //List<string> newlines = new List<string>(lines);
                //var highscore = newlines.OrderByDescending(x => x).ToList();
                var hsNum = new List<int>();
                var hsName = new List<string>();
                var hsNameS = new List<string>();

                for (int i = 0; i < lines.Length; i++)
                {
                    string[] temp = lines[i].Split(',');
                    hsNum.Add(int.Parse(temp[0]));
                    hsName.Add(temp[1]);
                }

                var hsNumS = hsNum.OrderByDescending(x => x).ToList();

                for (int j = 0; j < lines.Length; j++)
                {
                    for (int i = 0; i < lines.Length; i++) {
                        string temp = hsNumS[j].ToString();
                        if (lines[i].Contains(temp))
                        {
                            hsNameS.Add(hsName[i]);
                        }
                        else
                        {
                            continue;
                        }
                    }
                }

                for (int i = 0; i < 10; i++)
                {
                    var score = hsNumS[i];
                    var name = hsNameS[i];
                    if (i > 8)
                    {
                        if (score < 100)
                        {
                            Console.WriteLine("        " + (i + 1) + ".   " + score + " - " + name);
                        }
                        else
                        {
                            Console.WriteLine("        " + (i + 1) + ". " + score + " - " + name);
                        }
                    }
                    else
                    {
                        if (score < 100)
                        {
                            Console.WriteLine("         " + (i + 1) + ".   " + score + " - " + name);
                        }
                        else
                        {
                            Console.WriteLine("         " + (i + 1) + ".  " + score + " - " + name);
                        }
                        
                    }
                    
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error:", ex);
            }
            Console.WriteLine("\n##   Press enter to exit.    ##\n###############################");
        }

    }
}
