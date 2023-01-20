using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12practice
{
    public class Program
    {
        static int input_overs = 1;
        public static int[] overArray, overArray2;
        static string first_team = "Team 1", second_team = "Team 2", toss_win;

        public static void toss()
        {
            Random random = new Random();
            var list = new List<string> { first_team, second_team };
            var toss = random.Next(list.Count);
            toss_win = list[toss];
            Console.WriteLine("The Team who won the Toss is:" + toss_win);
            
            Console.ReadLine();
            mainMenu();

        }
        static void mainMenu()
        {
            
            //Console.Clear();
            Console.WriteLine("A Cricket Match Simulator");
            Console.WriteLine();
            Console.WriteLine("Enter the index of the task you want to perform.");
            Console.WriteLine("1. Customize team");
            Console.WriteLine("2. Customize number of overs");
            Console.WriteLine("3. Make a Toss");
            Console.WriteLine("4. Start first innings");
            Console.WriteLine("5. Start second innings");
            Console.WriteLine("6. Show final result");
            Console.WriteLine("7. End Match");

            string mainMenuOptions;
            mainMenuOptions = Console.ReadLine();

            switch (mainMenuOptions)
            {
                case "1":
                    team();
                    break;

                case "2":
                    no_of_overs();
                    break;

                case "3":
                    toss();
                    
                    break;

                case "4":
                    if (toss_win == first_team)
                    {
                        start();
                    }
                    else
                    {
                        start2();
                    };
                    break;

                case "5":
                    if (toss_win == first_team)
                    {
                        start2();
                    }
                    else
                    {
                        start();
                    };
                    break;

                case "6":
                    finalresult();
                    break;

                case "7":
                    exit();
                    break;
            }
            //Console.WriteLine("mainMenu "+overArray[0]);
            Console.ReadLine();
            mainMenu();
        }
        static void start()
        {
            overArray = new int[] { input_overs * 6, 0, 0, 0 };
            cont();
        }
        static void start2()
        {
            overArray2 = new int[] { input_overs * 6, 0, 0, 0 };
            cont2();
        }
        static void cont()
        {
            Console.WriteLine(first_team + " is batting.");
            Console.WriteLine("Enter the option you want to choose.");
            Console.WriteLine("1. Throw the ball");
            Console.WriteLine("2. Show current Scores");
            Console.WriteLine("3. Return to Main Menu");

            string overOptions = Console.ReadLine();

            switch (overOptions)
            {
                case "1":
                    throwBall();
                    break;

                case "2":
                    result();
                    break;

                case "3":
                    Program.mainMenu();
                    break;
            }
            //Console.WriteLine("start " + overArray[0]);
            cont();
        }
        static void cont2()
        {
            Console.WriteLine(second_team + " is batting.");
            Console.WriteLine("Enter the option you want to choose.");
            Console.WriteLine("1. Throw the ball");
            Console.WriteLine("2. Show current Scores");
            Console.WriteLine("3. Return to Main Menu");

            string overOptions2 = Console.ReadLine();

            switch (overOptions2)
            {
                case "1":
                    throwBall2();
                    break;

                case "2":
                    result2();
                    break;

                case "3":
                    Program.mainMenu();
                    break;
            }
            //Console.WriteLine("start " + overArray[0]);
            cont2();
        }
        static void throwBall()
        {
            //balls
            if (overArray[0] > 0)
            {
                overArray[0]--;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("No balls left!");
                Console.WriteLine("Match is Over!");
                Console.WriteLine();
                result();
                Console.ReadLine();
                mainMenu();
                
            }
            Random rd = new Random();
            int extra = rd.Next(0, 2);

            Random rd_options = new Random();
            int choice = rd_options.Next(1, 4);

            //wickets
            if (choice == 1)
            {
                int wick = rd.Next(0, 2);
                overArray[1]++;
            }


            //runs
            if (choice == 2)
            {
                int runs = rd.Next(1, 7);

                overArray[2] = overArray[2] + runs;

            }
            //extras
            if (choice == 3)
            {
                if (extra == 1)
                {
                    overArray[3]++;
                    overArray[2]++;
                    Console.WriteLine();
                    var list = new List<string> { "It's a wide ball", "It's a no-ball", "It's a leg-bye", "It's a penalty run" };
                    var random = new Random();
                    int index = random.Next(list.Count);
                    Console.WriteLine(list[index]);
                }
                else
                {
                    overArray[2] = overArray[2];
                }
            }

            Console.WriteLine("Balls Left: " + overArray[0]);
            Console.WriteLine("Total Wickets: " + overArray[1]);
            Console.WriteLine("Total Runs: " + overArray[2]);
            Console.WriteLine("Extras: " + overArray[3]);
            //Console.WriteLine("throwball " + overArray[0]);
            Console.ReadLine();

        }
        static void throwBall2()
        {
            //balls


            if (overArray2[0] > 0)
            {
                overArray2[0]--;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("No balls left!");
                Console.WriteLine("Match is Over!");
                Console.WriteLine();
                result2();
                Console.ReadLine();
                mainMenu();
                //    Console.WriteLine("Number of overs cannot be greater than 10!");
                //no_of_overs();
            }

            Random rd = new Random();
            int extra2 = rd.Next(0, 2);

            Random rd_options = new Random();
            int choice2 = rd_options.Next(1, 4);

            //wickets
            if (choice2 == 1)
            {
                int wick2 = rd.Next(0, 2);
                overArray2[1]++;
            }


            //runs
            if (choice2 == 2)
            {
                int runs = rd.Next(1, 7);

                overArray2[2] = overArray2[2] + runs;

            }
            //extras
            if (choice2 == 3)
            {
                if (extra2 == 1)
                {
                    overArray2[3]++;
                    overArray2[2]++;
                    Console.WriteLine();
                    var list = new List<string> { "It's a wide ball", "It's a no-ball", "It's a leg-bye", "It's a penalty run" };
                    var random = new Random();
                    int index2 = random.Next(list.Count);
                    Console.WriteLine(list[index2]);
                }
                else
                {
                    overArray2[2] = overArray2[2];
                }
            }

            Console.WriteLine("Balls Left: " + overArray2[0]);
            Console.WriteLine("Total Wickets: " + overArray2[1]);
            Console.WriteLine("Total Runs: " + overArray2[2]);
            Console.WriteLine("Extras: " + overArray2[3]);
            //Console.WriteLine("throwball " + overArray[0]);
            Console.ReadLine();

        }
        static void team()
        {
            Console.WriteLine("Enter the name of first team: ");
            first_team = Console.ReadLine();
            Console.WriteLine("Enter the name of second team: ");
            second_team = Console.ReadLine();

            mainMenu();
        }
        static void no_of_overs()
        {
            Console.WriteLine("Enter the number of overs: ");
            input_overs = Convert.ToInt32(Console.ReadLine());
            if (input_overs < 1 || input_overs > 10)
            {
                Console.WriteLine("Number of overs cannot be greater than 10!");
            }
            
            mainMenu();
        }  
        static void result()
        {

            Console.WriteLine("Here are the results of " + first_team);

            Console.WriteLine("Balls Left: " + overArray[0]);
            Console.WriteLine("Total Wickets: " + overArray[1]);
            Console.WriteLine("Total Runs: " + overArray[2]);
            Console.WriteLine("Extras: " + overArray[3]);
            Console.ReadLine();
            mainMenu();
        }
        static void result2()
        {

            Console.WriteLine("Here are the match results of " + second_team);

            Console.WriteLine("Balls Left: " + overArray2[0]);
            Console.WriteLine("Total Wickets: " + overArray2[1]);
            Console.WriteLine("Total Runs: " + overArray2[2]);

            Console.WriteLine("Extras: " + overArray2[3]);
            Console.ReadLine();

            mainMenu();
        }
        static void finalresult()
        {
            if (overArray == null || overArray2 == null)
            {
                Console.WriteLine("Please start the first and second innings to see the results!");
                Console.ReadLine();
                mainMenu();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine(first_team + " Scores..");
                Console.WriteLine("Balls Left: " + overArray[0]);
                Console.WriteLine("Total Wickets: " + overArray[1]);
                Console.WriteLine("Total Runs: " + overArray[2]);
                Console.WriteLine("Extras: " + overArray[3]);

                Console.WriteLine();
                Console.WriteLine(second_team + " Scores..");
                Console.WriteLine("Balls Left: " + overArray2[0]);
                Console.WriteLine("Total Wickets: " + overArray2[1]);
                Console.WriteLine("Total Runs: " + overArray2[2]);
                Console.WriteLine("Extras: " + overArray2[3]);
                Console.WriteLine();
                if (overArray[2] > overArray2[2])
                {
                    Console.WriteLine(first_team + " is the winner!");
                }
                else if (overArray[2] == overArray2[2])
                {
                    Console.WriteLine("It's a tie match!");
                }
                else
                {
                    Console.WriteLine(second_team + " is the winner!");
                }
                Console.ReadLine();
                mainMenu();
            }
        }
        static void exit()
        {
            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
            System.Environment.Exit(1);
        }
        public static void Main(string[] args)
        {

            mainMenu();
            Console.ReadKey();
        }
    }
}
