using System;

using System.Collections.Generic;

using System.Text;



namespace Roulette

{

    class Bet

    {

        public string NumBet(int ball, int option, int[] Numbers)

        {

            string x = "";

            for (int i = 0; i < 1; i++)

            {

                if (option == Numbers[ball])

                {

                    x += $"The ball landed in bin {ball}\n" +

                         $"You win!";

                }

                else if (option != Numbers[ball])

                {

                    x += $"The ball landed in bin {ball}\n" +

                         $"You lose!";

                }

            }

            return x;

        }

        public string evenOdds(int ball, int option, int[] Numbers)

        {

            string x = "";

            for (int i = 0; i < 1; i++)

            {

                if (option == 1)//

                {

                    if (ball % 2 == 0)

                    {

                        x += $"The number is {ball} and it is even.\n" +

                             "You win!";

                    }

                    else if (ball % 2 != 0)

                    {

                        x += $"The number is {ball} and it is odd.\n" +

                            $"You lose";

                    }



                }



                if (option == 2)//

                {

                    if (ball % 2 == 0)

                    {

                        x += $"The number is {ball} and it is even.\n" +

                             "You lose";

                    }

                    else if (ball % 2 != 0)

                    {

                        x += $"The number is {ball} and it is odd.\n" +

                            $"You win!";

                    }



                }

            }

            return x;

        }

        public string RedOrBlack(int ball, int option, string[] Colors)

        {

            string x = "";

            for (int i = 0; i < 1; i++)

            {

                if (option == 1)//

                {

                    if (Colors[ball] == "black")

                    {

                        x += $"The number is {ball} and it is black.\n" +

                             "You win!";

                    }

                    else

                    {

                        x += $"The number is {ball} and it is red.\n" +

                            $"You lose";

                    }



                }



                if (option == 2)//

                {

                    if (Colors[ball] == "red")

                    {

                        x += $"The number is {ball} and it is black.\n" +

                             "You lose";

                    }

                    else

                    {

                        x += $"The number is {ball} and it is red.\n" +

                            $"You win!";

                    }



                }

            }

            return x;



        }

        public string LowOrHigh(int ball, int option, string[] Number)

        {

            string x = "";

            if (option == 1)

            {

                if (ball < 19 && ball > 0)

                {



                    x += $"The number is {Number[ball]} and it is a Low.\n" +

                         $"You win!";

                }

                else

                {

                    x += $"Your number is {Number[ball]}. and it is not a Low\n You lose.";

                }

            }

            if (option == 2)

            {

                if (ball > 18 && Number[ball] != Number[37])

                {

                    x += $"The number is {Number[ball]} and it is a High.\n" +

                         $"You win!";

                }

                else

                {

                    x += $"Your number is {Number[ball]}. and it is not a High\n You lose.";

                }

            }



            return x;

        }

        public string Dozens(int ball, int option, string[] Number)

        {

            string x = "";

            if (option == 1)

            {

                if (ball > 0 && ball < 13)

                {

                    x += $"The number is {Number[ball]}. And it falls within the first dozen.\n" +

                        $"You win!";

                }

                else

                {

                    x += $"The number is {Number[ball]}. And it doesn't falls within the first dozen.\n" +

                        $"You lose.";



                }



            }



            if (option == 2)

            {

                if (ball > 12 && ball < 25)

                {

                    x += $"The number is {Number[ball]}. And it falls within the second dozen.\n" +

                        $"You win!";

                }

                else

                {

                    x += $"The number is {Number[ball]}. And it doesn't falls within the second dozen.\n" +

                        $"You lose.";



                }



            }



            if (option == 3)

            {

                if (ball > 24 && ball < 37)

                {

                    x += $"The number is {Number[ball]}. And it falls within the third dozen.\n" +

                        $"You win!";

                }

                else

                {

                    x += $"The number is {Number[ball]}. And it doesn't falls within the third dozen.\n" +

                        $"You lose.";



                }



            }

            return x;

        }

        public string Columns(int ball, int option, string[] Number)

        {

            string x = "";



            if (option == 1)

            {

                for (int i = 1; i < Number.Length - 1; i += 3)

                {

                    if (ball == int.Parse(Number[i]))

                    {

                        return $"Your ball landed on {Number[ball]} which is on the first column.\n" +

                             "you win!\n";

                    }

                }



                return $"Your ball landed on {Number[ball]} which is not on the first column.\n" +

                     "you lose\n";

            }

            if (option == 2)

            {

                for (int i = 2; i < Number.Length - 1; i += 3)

                {

                    if (ball == int.Parse(Number[i]))

                    {

                        return $"Your ball landed on {Number[ball]} which is on the second column.\n" +

                             "you win!\n";

                    }

                }



                return $"Your ball landed on {Number[ball]} which is not on the second column.\n" +

                     "you lose\n";

            }

            if (option == 3)

            {

                for (int i = 3; i < Number.Length - 1; i += 3)

                {

                    if (ball == int.Parse(Number[i]))

                    {

                        return $"Your ball landed on {Number[ball]} which is on the third column.\n" +

                             "you win!\n";

                    }

                }



                return $"Your ball landed on {Number[ball]} which is not on the third column.\n" +

                     "you lose\n";

            }



            return x;

        }

        public string Streets(int ball, int option, string[] Number)

        {



            switch (option)

            {

                case (1):

                    for (int i = 1; i < 4; i++)

                    {
                        if (ball == int.Parse(Number[i]))

                        {

                            return $"your ball landed on {ball} you win!";

                        }



                    }

                    break;



                case (2):

                    for (int i = 4; i < 7; i++)

                    {

                        if (ball == int.Parse(Number[i]))

                        {

                            return $"your ball landed on {ball} you win!";

                        }

                    }

                    break;



                case (3):

                    for (int i = 7; i < 10; i++)

                    {

                        if (ball == int.Parse(Number[i]))

                        {

                            return $"your ball landed on {ball} you win!";

                        }

                    }

                    break;



                case (4):

                    for (int i = 10; i < 13; i++)

                    {

                        if (ball == int.Parse(Number[i]))

                        {

                            return $"your ball landed on {ball} you win!";

                        }

                    }

                    break;



                case (5):

                    for (int i = 13; i < 16; i++)

                    {

                        if (ball == int.Parse(Number[i]))

                        {

                            return $"your ball landed on {ball} you win!";

                        }

                    }

                    break;



                case (6):

                    for (int i = 16; i < 19; i++)

                    {

                        if (ball == int.Parse(Number[i]))

                        {

                            return $"your ball landed on {ball} you win!";

                        }

                    }

                    break;



                case (7):

                    for (int i = 19; i < 21; i++)

                    {

                        if (ball == int.Parse(Number[i]))

                        {

                            return $"your ball landed on {ball} you win!";

                        }

                    }

                    break;



                case (8):

                    for (int i = 21; i < 24; i++)

                    {

                        if (ball == int.Parse(Number[i]))

                        {

                            return $"your ball landed on {ball} you win!";

                        }

                    }

                    break;



                case (9):

                    for (int i = 24; i < 27; i++)

                    {

                        if (ball == int.Parse(Number[i]))

                        {

                            return $"your ball landed on {ball} you win!";

                        }

                    }

                    break;



                case (10):

                    for (int i = 27; i < 30; i++)

                    {

                        if (ball == int.Parse(Number[i]))

                        {

                            return $"your ball landed on {ball} you win!";

                        }

                    }

                    break;



                case (11):

                    for (int i = 30; i < 33; i++)

                    {

                        if (ball == int.Parse(Number[i]))

                        {

                            return $"your ball landed on {ball} you win!";

                        }

                    }

                    break;



                case (12):

                    for (int i = 33; i <= 36; i++)

                    {

                        if (ball == int.Parse(Number[i]))

                        {

                            return $"your ball landed on {ball} you win!";

                        }

                    }

                    break;



            }

            return $"Your ball landed on {ball}\n You lose\n";

        }

        public string SixNumbers(int ball, int option, string[] Number)

        {

            switch (option)

            {

                case (1):

                    for (int i = 1; i < 7; i++)

                    {

                        if (ball == int.Parse(Number[i]))

                        {

                            return $"your ball landed on {ball} you win!";

                        }



                    }

                    break;



                case (2):

                    for (int i = 4; i < 10; i++)

                    {

                        if (ball == int.Parse(Number[i]))

                        {

                            return $"your ball landed on {ball} you win!";

                        }

                    }

                    break;



                case (3):

                    for (int i = 7; i < 13; i++)

                    {

                        if (ball == int.Parse(Number[i]))

                        {

                            return $"your ball landed on {ball} you win!";

                        }

                    }

                    break;



                case (4):

                    for (int i = 10; i < 16; i++)

                    {

                        if (ball == int.Parse(Number[i]))

                        {

                            return $"your ball landed on {ball} you win!";

                        }

                    }

                    break;



                case (5):

                    for (int i = 13; i < 19; i++)

                    {

                        if (ball == int.Parse(Number[i]))

                        {

                            return $"your ball landed on {ball} you win!";

                        }

                    }

                    break;



                case (6):

                    for (int i = 16; i < 22; i++)

                    {

                        if (ball == int.Parse(Number[i]))

                        {

                            return $"your ball landed on {ball} you win!";

                        }

                    }

                    break;



                case (7):

                    for (int i = 19; i < 25; i++)

                    {

                        if (ball == int.Parse(Number[i]))

                        {

                            return $"your ball landed on {ball} you win!";

                        }

                    }

                    break;



                case (8):

                    for (int i = 21; i < 28; i++)

                    {

                        if (ball == int.Parse(Number[i]))

                        {

                            return $"your ball landed on {ball} you win!";

                        }

                    }

                    break;



                case (9):

                    for (int i = 24; i < 31; i++)

                    {

                        if (ball == int.Parse(Number[i]))

                        {

                            return $"your ball landed on {ball} you win!";

                        }

                    }

                    break;



                case (10):

                    for (int i = 27; i < 34; i++)

                    {

                        if (ball == int.Parse(Number[i]))

                        {

                            return $"your ball landed on {ball} you win!";

                        }

                    }

                    break;



                case (11):

                    for (int i = 30; i < 37; i++)

                    {

                        if (ball == int.Parse(Number[i]))

                        {

                            return $"your ball landed on {ball} you win!";

                        }

                    }

                    break;

            }

            return $"Your ball landed on {ball}\n You lose\n";

        }


    }

}