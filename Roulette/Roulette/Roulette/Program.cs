using System;

using System.Collections.Generic;

using System.Text;

namespace Roulette

{

    class Program

    {

        static void Main()

        {

            Bet bets = new Bet();

            int[] Numbers = new int[38];

            string[] Colors = new string[38] {"green", "red", "black", "red", "black", "red", "black", "red", "black", "red", "black", "black", "red", "black",

            "red", "black", "red", "black", "red", "red", "black", "red", "black", "red", "black", "red", "black","red", "black", "black", "red", "black", "red","black",

            "red", "black", "red", "green"};

            string[] Number = new string[38] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22",

            "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "00"};

            string[,] Table = new string[3, 12]

            {

                { "3","6","9", "12", "15", "18", "21", "24" , "27", "30", "33", "36"},

                { "2", "5", "8", "11", "14", "17", "20", "23", "26", "29", "32", "35"},

                { "1","4", "7", "10", "13", "16", "19", "22", "25", "28", "31", "34"}

            };

            Random rand = new Random();



            int ball = rand.Next(0, 38);



            Console.WriteLine($"Place your bet:\n" +

                $"[1] Numbers\n" +

                $"[2] Even/Odds\n" +

                $"[3] Reds/Blacks\n" +

                $"[4] Lows/Highs\n" +

                $"[5] Dozens\n" +

                $"[6] Columns\n" +

                $"[7] Street\n" +

                $"[8] 6 Numbers\n" +

                $"[9] Split\n" +

                $"[10] Corner\n");



            int choice = int.Parse(Console.ReadLine());



            switch (choice)

            {

                case (1):

                    {

                        Console.WriteLine("Pick a number: \n 1 - 36");

                        int option = int.Parse(Console.ReadLine());

                        Console.WriteLine(bets.NumBet(ball, option, Numbers));

                        break;

                    }

                case (2):

                    {

                        Console.WriteLine("even or odds?\n" +

                                          "[1] even\n" +

                                          "[2] odd\n");

                        int option = int.Parse(Console.ReadLine());

                        Console.WriteLine(bets.evenOdds(ball, option, Numbers));

                        break;

                    }

                case (3):

                    {

                        Console.WriteLine("black or red?\n" +

                            "[1] black\n" +

                            "[2] red\n");

                        int option = int.Parse(Console.ReadLine());

                        Console.WriteLine(bets.RedOrBlack(ball, option, Colors));

                        break;

                    }

                case (4):

                    {

                        Console.WriteLine("Lows or Highs?\n" +

                            "[1] Lows\n" +

                            "[2] Highs\n");

                        int option = int.Parse(Console.ReadLine());

                        Console.WriteLine(bets.LowOrHigh(ball, option, Number));

                        break;

                    }

                case (5):

                    {

                        Console.WriteLine("Pick a dozen\n" +

                            "[1] 1-12\n" +

                            "[2] 13-34\n" +

                            "[3] 25-36\n");

                        int option = int.Parse(Console.ReadLine());

                        Console.WriteLine(bets.Dozens(ball, option, Number));

                        break;

                    }

                case (6):

                    {

                        Console.WriteLine("Pick a column\n" +

                            "[1] Contains (1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34\n" +

                            "[2] Contains (2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35\n" +

                            "[3] Contains (3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36\n");

                        int option = int.Parse(Console.ReadLine());

                        Console.WriteLine(bets.Columns(ball, option, Number));

                        break;

                    }

                case (7):

                    {

                        Console.WriteLine("Pick a row\n" +

                            "[1] 1,2,3\n" +

                            "[2] 4,5,6\n" +

                            "[3] 7,8,9\n" +

                            "[4] 10,11,12\n" +

                            "[5] 13,14,15\n" +

                            "[6] 16,17,18\n" +

                            "[7] 19,20,21\n" +

                            "[8] 22,23,24\n" +

                            "[9] 25,26,27\n" +

                            "[10] 28,29,30\n" +

                            "[11] 31,32,33\n" +

                            "[12] 34,35,36\n");

                        int option = int.Parse(Console.ReadLine());

                        Console.WriteLine(bets.Streets(ball, option, Number));

                        break;

                    }

                case (8):

                    {

                        Console.WriteLine("Pick a double row\n\n" +

                            "[1] 1,2,3 and 4,5,6\n" +

                            "[2] 4,5,6 and 7,8,9\n" +

                            "[3] 7,8,9 and 10,11,12\n" +

                            "[4] 10,11,12 and 13,14,15\n" +

                            "[5] 13,14,15 and 16,17,18\n" +

                            "[6] 16,17,18 and 19,20,21\n" +

                            "[7] 19,20,21 and 22,23,24\n" +

                            "[8] 22,23,24 and 25,26,27\n" +

                            "[9] 25,26,27 and 28,29,30\n" +

                            "[10] 28,29,30 and 31,32,33\n" +

                            "[11] 31,32,33 and 34,35,36\n");

                        int option = int.Parse(Console.ReadLine());

                        Console.WriteLine(bets.SixNumbers(ball, option, Number));

                        break;

                    }

                case (9):

                    {

                        Console.WriteLine("Pick two contiguous numbers\n" +

                             "3", "6", "9", "12", "15", "18", "21", "24", "27", "30", "33", "36\n" +

                             "2", "5", "8", "11", "14", "17", "20", "23", "26", "29", "32", "35\n" +

                             "1", "4", "7", "10", "13", "16", "19", "22", "25", "28", "31", "34\n" +

                             "Enter your first number\n");

                        int opt1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter your second number");

                        int opt2 = int.Parse(Console.ReadLine());

                        Console.WriteLine("....");





                        break;

                    }

                case (10):

                    {

                        Console.WriteLine("This bet is still under construction");

                        break;

                    }

            }

        }

    }

}