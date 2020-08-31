using System;


namespace Military_Unit
{
    class Program
    {
        static void Main()
        {
            M16 m16 = new M16();
            M9 M9 = new M9();
            COC_Equipment COC = new COC_Equipment();
            Comm_Equipment blackgear = new Comm_Equipment();
            Personal_Gear loadout = new Personal_Gear();

            Console.WriteLine("What is your christian name?");
            string name = Console.ReadLine();
            Console.WriteLine("Do you want to be an officer or a working man?\n" +
                "1. Officer \n" +
                "2. Real man \n");
            try
            {
                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    OfficerChoice();
                }

                else if (choice == 2)
                {
                    NCOChoice();
                }
                else
                {
                    Console.WriteLine("Not an Option Sweetie!\n");
                    Main();
                }
            }
            catch (Exception except)
            {
                Console.WriteLine(except.Message + "\n Try again");
                Main();
            }


            void NCOChoice()
            {
                Console.Clear();
                NCO nco = new NCO();

                Console.WriteLine($"{nco.Setting()}\n Its a cold day in hell you hear your officer coming to you....\n" +
                    $"LtIHaveADegree: Listen up SGT {name}.\n" +
                    $"Here are your taskers for the day gtg? {nco.Mission1()}\n" +
                    $"Will you do as he says?\n" +
                    "1. Get accountability\n" +
                    "2. EDL\n" +
                    "3. Do a gear inspection\n" +
                    "4. Run for fun\n" +
                    "5. 'Ok Jake, I'll do my job'\n");

                int choices = int.Parse(Console.ReadLine());
                Console.Clear();
                if (choices == 1)
                {
                    Console.WriteLine("You decide to get accountability. The men are all formed up and the officer comes in front of the formation standing awkwardly waiting for you to acknowledge him...\n" +
                        "What do you do?\n" +
                        "1. Stop what you are doing and salute Jake.\n" +
                        "2. Continue with the mission\n");
                    int pick = int.Parse(Console.ReadLine());
                    if (pick == 1)
                    {
                        Console.WriteLine(nco.Greet());
                        Console.Clear();
                        Console.WriteLine($"LtIHaveADegree: OOOORAAAH SGT {name}. " +
                            "Gents can everyone show me their gear?\n" +
                            "The men go to their barracks to grab their things and you go to your F-150 and come back with your main pack that hasnt been unpacked since the last field op.");
                        MainPack();
                        int choice = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Description2(choice);
                    }
                    else if (pick == 2)
                    {
                        Console.WriteLine(nco.Correction2());
                        Console.ReadKey();
                        NCOChoice();
                    }
                }
                else
                {
                    Console.WriteLine(nco.Correction());
                    Console.ReadKey();
                    NCOChoice();
                }
            }

            void OfficerChoice()
            {
                Console.Clear();
                Officer officer = new Officer();
                Console.WriteLine(officer.Setting());
                Console.WriteLine(officer.Mission1());
                Console.ReadKey(); Console.Clear();

                Console.WriteLine($"{officer.Greet()} \n " +
                    $"CPL Chad: Yo, {name}, wahts da wurd\n" +
                    "Refine this swine and all his underlings:\n" +
                    "1. [five minutes discussing why he will never amount to anything if he doesnt invest five percent of his earning in TSP]\n" +
                    "2. Go play xbox with the rest of the filth till the chicken shack opens up");

                int option = int.Parse(Console.ReadLine());
                if (option == 1)
                {
                    Console.Clear();
                    Console.WriteLine($"Now do you understand?... You think to yourself (Jocko Wilnis had it so easy. He didnt have to put up with such filth...)\n" +
                        $"CPL Chad: ERR {officer.Greet()}, I get marns in quad.\n");

                    Console.WriteLine($"Cpl Chad cruedly exits without the proper facing movements.\n" + 
                        "You see the XO's Pack");
                    MainPack();
                    int choice = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Description(choice);
                }
                else if (option == 2)
                {
                    Console.Clear();
                    Console.WriteLine("XO calls you into his office. Better let your roommates know you wont make it to scrabble tonight..\n" +
                        "1. Try again\n" +
                        "2. Go back to college\n");

                    int tryExit = int.Parse(Console.ReadLine());
                    if (tryExit == 1)
                    {
                        OfficerChoice();
                    }
                    else if (tryExit == 2)
                    {
                        Environment.Exit(0);
                    }
                    else
                    {

                    }


                }
            }


            void MainPack()
            {
                Console.WriteLine($"Gear\n" +
                   $"1. Personal Gear\n" +
                   $"2. M16\n" +
                   $"3. Walkie Talkie\n" +
                   $"4. M9\n" +
                   $"5. COC Equipment\n" +
                   $"6. Grab everything.\n");
            }

            void Description(int option)
            {

                switch (option)
                {
                    case (1):
                        Console.WriteLine(loadout.Description());
                        Console.ReadKey();
                        OfficerChoice();
                        break;

                    case (2):
                        Console.WriteLine(m16.Description());
                        Console.ReadKey();
                        OfficerChoice();
                        break;

                    case (3):
                        Console.WriteLine(blackgear.Description());
                        Console.ReadKey();
                        OfficerChoice();
                        break;

                    case (4):
                        Console.WriteLine(M9.Description());
                        Console.ReadKey();
                        OfficerChoice();
                        break;

                    case (5):
                        Console.WriteLine(COC.Description());
                        Console.ReadKey();
                        OfficerChoice();
                        break;
                    case (6):
                        Officer officer = new Officer();
                        Console.WriteLine(officer.EndSetting());
                        Console.ReadKey();
                        break;
                }

            }

            void Description2(int option)
            {

                switch (option)
                {
                    case (1):
                        Console.WriteLine(loadout.Description());
                        Console.ReadKey();
                        NCOChoice();
                        break;

                    case (2):
                        Console.WriteLine(m16.Description());
                        Console.ReadKey();
                        NCOChoice();
                        break;

                    case (3):
                        Console.WriteLine(blackgear.Description());
                        Console.ReadKey();
                        NCOChoice();
                        break;

                    case (4):
                        Console.WriteLine(M9.Description());
                        Console.ReadKey();
                        NCOChoice();
                        break;

                    case (5):
                        Console.WriteLine(COC.Description());
                        Console.ReadKey();
                        NCOChoice();
                        break;
                    case (6):
                        NCO nco2 = new NCO();
                        Console.WriteLine(nco2.EndSetting());
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
