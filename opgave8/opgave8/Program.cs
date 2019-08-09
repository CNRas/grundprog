using System;
using static opgave8.AllMethods;

namespace opgave8
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int gameType = 0;
            int gameDifficulty = 0;
            var read = "e";
            int tries = 0;
            float result = 0;
            float guess = result +1;
            int points = 0;
            int pointTotal = 0;
            while (true)
            {
                Console.WriteLine(Menu()); // Henter menu 'grafikken'

                gameType = Discipline(); //Vælger disciplin

                if (gameType == 0)
                {
                    break;
                }

                if (gameType == 5)
                {
                    while (gameType == 5)
                    {
                        Console.WriteLine(" ");
                        showHighScore("highscore.txt");
                        Console.ReadKey();
                        Console.WriteLine(Menu());
                        gameType = Discipline();
                    }

                }

                if (gameType == 0)
                {
                    break;
                }

                gameDifficulty = Difficulty(); //Vælger sværhedgrad

                if (gameDifficulty == 0)
                {
                    break;
                }

                Console.WriteLine("\nWrite 'e' at anypoint to exit to the main menu.\n");

                for (int i = 0; i < 10; i++) //Kører spillet igennem 10 gange
                {
                    result = Calculation(gameType, gameDifficulty); //Skaber resultatet som skal gættes, med valg af discipling og sværhedgrad

                    while (guess != result && tries < 3) //Kører indtil til der er gættet rigtigt eller 3 forsøg er brugt
                    {
                        read = Console.ReadLine();
                        if (read == "e") //Gør at man kan exit til menuen 1/2
                        {
                            break;
                        }
                        else
                        {
                            guess = float.Parse(read);
                        }

                        tries++;
                        if (guess == result)
                        {
                            points = (7 - (2 * tries))*gameDifficulty;

                            pointTotal += points;

                            Console.WriteLine("Correct! The answer is {0}. You get {1} point(s). Your total is {2} points.", result, points, pointTotal);

                        }
                        else
                        {
                            Console.WriteLine("The answer was wrong. You have used {0} try/tries.",tries);
                        }

                    }

                    if (read == "e") //Gør at man kan exit til menuen 2/2
                    {
                        break;
                    }

                    if (tries > 2)
                    {
                        Console.WriteLine("You ran out of tries. The answer was {0}. You get 0 points. Your total is {1} points.",result, pointTotal);
                    }
                    tries = 0;
                    guess = 0;
                }

                Console.WriteLine("\n## The game is over! You scored {0} points! ##\nDo you want to save your score? y/n",pointTotal);
                var save = Console.ReadKey();
                if (save.Key == ConsoleKey.Y)
                {
                    Console.WriteLine("Write your initials (max 3):\n");
                    string name = Console.ReadLine();
                    addScore(name, pointTotal, "highscore.txt");
                    Console.WriteLine("Score saved!\n");
                    pointTotal = 0;
                    tries = 0;
                    guess = 0;
                }
                if (save.Key == ConsoleKey.N)
                {
                    pointTotal = 0;
                    tries = 0;
                    guess = 0;
                    continue;

                }
                   
            }
        }
    }
}
