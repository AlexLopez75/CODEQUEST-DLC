using System;
public class Program
{
    public static void Main()
    {
        //Menu:
        const string MenuTitle = "===== MAIN MENU - CODEQUEST =====";
        const string PlayerTitle = "===== Welcome, {0} the {1} with level {2} =====\n";
        const string MenuOption1 = "1. Train your wizard";
        const string MenuOption2 = "2. Increase LVL";
        const string MenuOption3 = "3. Loot the mine";
        const string MenuOption4 = "4. Show inventory";
        const string MenuOption5 = "5. Buy items";
        const string MenuOption6 = "6. Show attacks by LVL";
        const string MenuOption7 = "7. Decode ancient Scroll";
        const string MenuOptionExit = "0. Exit game";
        const string MenuPrompt = "Input (1-7) to choose an option or (0) to exit: ";
        const string InputErrorMessage = "Invalid input. Please enter a number between 0 and 7.";

        //Chapter 1:
        const string MsgInputName = "Enter your wizard's name: ";
        const string MsgNameConfirm = "Your wizard's name is: {0}";
        const string InputNameError = "Input a name without spaces.";
        const string PressEnter = "Press enter to continue";
        const string Title = "Title: ";
        const string LevelDisaster = "You repeat the 2nd call";
        const string LevelNoob = "You still confuse your wand with a spoon";
        const string LevelNovice = "You are a Magic Breeze Caster";
        const string LevelAdvanced = "Wow! You can cast dragons witout burning the lab!";
        const string LevelMaster = "You have achieved the Master of Arcanes rank!";
        const string TitleDisaster = "Raoden the Elantrin";
        const string TitleNoob = "Zyn the bugged";
        const string TitleNovice = "Arka Nullpointer";
        const string TitleAdvanced = "Elarion of the Embers";
        const string TitleMaster = "ITB-Wizard the Grey";
        const string DayTraining = "Day {0} : {1} meditated for {2} hours and gained {3} power points.";
        const string TotalTraining = "{0} has meditated for a total of {1} hours and gained {2} power points.";

        //Menu:
        int op = 0;
        bool setWizard = false;

        //Chapter 1:
        int day, hour, power, totalHour = 0, totalPower = 0, level = 1;
        string wizardName = "none", title = "none", space = " ";
        bool validInput = true, badName = false;

        Random rnd = new Random();

        do
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            validInput = true;
            Console.WriteLine(MenuTitle);
            if (setWizard)
            {
                Console.WriteLine(PlayerTitle, wizardName, title, level);
            }
            Console.WriteLine(MenuOption1);
            Console.WriteLine(MenuOption2);
            Console.WriteLine(MenuOption3);
            Console.WriteLine(MenuOption4);
            Console.WriteLine(MenuOption5);
            Console.WriteLine(MenuOption6);
            Console.WriteLine(MenuOption7);
            Console.WriteLine(MenuOptionExit);
            Console.Write(MenuPrompt);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            try
            {
                op = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine(InputErrorMessage);
                validInput = false;
            }
            catch (Exception)
            {
                Console.WriteLine(InputErrorMessage);
                validInput = false;
            }

            if (validInput)
            {
                switch (op)
                {
                    case 1:
                        do
                        {
                            badName = false;
                            Console.Write(MsgInputName);
                            Console.ForegroundColor = ConsoleColor.Blue;
                            wizardName = Console.ReadLine();
                            wizardName = char.ToUpper(wizardName[0]) + wizardName.Substring(1);
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.White;
                            if (badName = wizardName.Contains(space))
                            {
                                Console.WriteLine(InputNameError);
                                badName = true;
                            }
                        } while (badName);

                        Console.WriteLine(MsgNameConfirm, wizardName);
                        Console.WriteLine();

                        for (day = 1; day < 6; day++)
                        {
                            hour = rnd.Next(11);
                            power = rnd.Next(11);
                            totalHour = totalHour + hour;
                            totalPower = totalPower + power;
                            Console.WriteLine(DayTraining, day, wizardName, hour, power);
                            Console.WriteLine(TotalTraining, wizardName, totalHour, totalPower);
                            Console.WriteLine(PressEnter);
                            Console.ReadLine();
                        }
                        switch (totalPower)
                        {
                            case >= 40:
                                Console.WriteLine(LevelMaster);
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine(Title + TitleMaster);
                                Console.ForegroundColor = ConsoleColor.White;
                                title = TitleMaster;
                                break;
                            case >= 35:
                                Console.WriteLine(LevelAdvanced);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine(Title + TitleAdvanced);
                                Console.ForegroundColor = ConsoleColor.White;
                                title = TitleAdvanced;
                                break;
                            case >= 30:
                                Console.WriteLine(LevelNovice);
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine(Title + TitleNovice);
                                Console.ForegroundColor = ConsoleColor.White;
                                title = TitleNovice;
                                break;
                            case >= 20:
                                Console.WriteLine(LevelNoob);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(Title + TitleNoob);
                                Console.ForegroundColor = ConsoleColor.White;
                                title = TitleNoob;
                                break;
                            case < 20:
                                Console.WriteLine(LevelDisaster);
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.WriteLine(Title + TitleDisaster);
                                Console.ForegroundColor = ConsoleColor.White;
                                title = TitleDisaster;
                                break;
                        }
                        Console.WriteLine();
                        setWizard = true;
                        break;
                }
            }
        } while (op != 0);
    }
}
