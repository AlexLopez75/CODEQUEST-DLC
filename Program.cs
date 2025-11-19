using System;
using System.Data.Common;
public class Program
{
    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;

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
        const string MsgNameConfirm = "Your wizard's name is: ";
        const string InputNameError = "Input a name without spaces.";
        const string PressEnter = "Press enter to continue";
        const string LevelDisaster = "You repeat the 2nd call";
        const string LevelNoob = "You still confuse your wand with a spoon";
        const string LevelNovice = "You are a Magic Breeze Caster";
        const string LevelAdvanced = "Wow! You can cast dragons witout burning the lab!";
        const string LevelMaster = "You have achieved the Master of Arcanes rank!";
        const string TitleDisaster = "Raoden the Elantrin";
        const string TitleNoob = "Level: Zyn the bugged";
        const string TitleNovice = "Level: Arka Nullpointer";
        const string TitleAdvanced = "Level: Elarion of the Embers";
        const string TitleMaster = "Level: ITB-Wizard the Grey";
        const string DayTraining = "Day {0} : {1} meditated for {2} hours and gained {3} power points.";
        const string TotalTraining = "{0} has meditated for a total of {1} hours and gained {2} power points";

        //Chapter 2
        const string MonsterEncounter = "A wild {0} appears! Rolling dice to determine the outcome of the battle...";
        const string MonsterHp = "The {0} has {1} HP left.";
        const string DiceRoll1 = "   ________\r\n  /       /|   \r\n /_______/ |\r\n |       | |\r\n |   o   | /\r\n |       |/ \r\n '-------'\r\n";
        const string DiceRoll2 = "   ________\r\n  /       /|   \r\n /_______/ |\r\n | o     | |\r\n |       | /\r\n |     o |/ \r\n '-------'\r\n";
        const string DiceRoll3 = "   ________\r\n  /       /|   \r\n /_______/ |\r\n | o     | |\r\n |   o   | /\r\n |     o |/ \r\n '-------'\r\n";
        const string DiceRoll4 = "   ________\r\n  /       /|   \r\n /_______/ |\r\n | o   o | |\r\n |       | /\r\n | o   o |/ \r\n '-------'\r\n";
        const string DiceRoll5 = "   ________\r\n  /       /|   \r\n /_______/ |\r\n | o   o | |\r\n |   o   | /\r\n | o   o |/ \r\n '-------'\r\n";
        const string DiceRoll6 = "   ________\r\n  /       /|   \r\n /_______/ |\r\n | o   o | |\r\n | o   o | /\r\n | o   o |/ \r\n '-------'\r\n";
        const string DiceResult = "You rolled a {0}!";
        const string MonsterDamage = "The monster takes {0} damage.";
        const string MonsterDefeat = "You have defeated the monster, you level increasses to level {0}.";
        const string MaxLevel = "You have achieved max level.";
        const int MinMonster = 0;
        const int MaxMonster = 8;
        const int MinDamage = 1;
        const int MaxDamage = 7;

        //Chapter 3:
        const string AttemptsLeft = "You have {0} attempts left.";
        const string MineMap = "Here's the map of the mine.";
        const string Treasure = "🪙";
        const string NotDigged = "➖";
        const int MinChance = 0;
        const int MaxChance = 9;
        const int TreasureChance = 10;

        //Menu:
        int op = 0;
        bool setWizard = false;

        //Chapter 1:
        int day, hour, power, totalHour = 0, totalPower = 0, level = 1;
        string wizardName = "none",  title = "none", space = " ";
        bool validInput, badName = false;

        //Chapter 2:
        int[] arrayHp = { 3, 5, 10, 11, 18, 15, 20, 50 };
        string[] arrayMonsters = { "Wandering Skeleton 💀", "Forest Goblin 👹", "Green Slime 🟢", "Ember Wolf 🐺", "Giant Spider 🕷️", "Iron Golem 🤖", "Lost Necromancer 🧝‍", "Ancient Dragon 🐉" };
        string[] arrayDice = { DiceRoll1, DiceRoll2, DiceRoll3, DiceRoll4, DiceRoll5, DiceRoll6 };
        int health;

        //Chapter 3:
        string[,] matrixTreasure = new string[5, 5];
        string[,] matrixMap = new string[5, 5];
        int attempts = 5;

        Random rnd = new Random();

        do
        {
            Console.WriteLine(MenuTitle);
            if (setWizard)
            {
                Console.WriteLine(PlayerTitle, wizardName, title);
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

            validInput = true;

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
                Console.WriteLine(op);
                switch (op)
                {
                    case 1:
                        do
                        {
                            Console.Write(MsgInputName);
                            wizardName = Console.ReadLine();
                            wizardName = char.ToUpper(wizardName[0]) + wizardName.Substring(1);
                            if (badName = wizardName.Contains(space))
                            {
                                Console.WriteLine(InputNameError);
                                badName = true;
                            }
                        } while (badName);

                        Console.WriteLine(MsgNameConfirm + wizardName);

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
                                Console.WriteLine(TitleMaster);
                                title = "ITB-Wizard the Grey";
                                break;
                            case >= 35:
                                Console.WriteLine(LevelAdvanced);
                                Console.WriteLine(TitleAdvanced);
                                title = "Elarion of the Embers";
                                break;
                            case >= 30:
                                Console.WriteLine(LevelNovice);
                                Console.WriteLine(TitleNovice);
                                title = "Arka Nullpointer";
                                break;
                            case >= 20:
                                Console.WriteLine(LevelNoob);
                                Console.WriteLine(TitleNoob);
                                title = "Zyn the Bugged";
                                break;
                            case < 20:
                                Console.WriteLine(LevelDisaster);
                                Console.WriteLine(TitleDisaster);
                                title = "Raoden the Elantrin";
                                break;
                        }
                        setWizard = true;
                        break;
                    case 2:
                        switch (level)
                        {
                            case < 5:
                                int monster = rnd.Next(MinMonster, MaxMonster);
                                Console.WriteLine(MonsterEncounter, arrayMonsters[monster]);
                                health = arrayHp[monster];

                                do
                                {
                                    Console.WriteLine(MonsterHp, arrayMonsters[monster], health);
                                    int damage = rnd.Next(MinDamage, MaxDamage);
                                    Console.WriteLine(arrayDice[damage - 1]);
                                    health = health - damage;
                                    Console.WriteLine(DiceResult, (damage));
                                    Console.WriteLine(MonsterDamage, damage);
                                } while (health > 0);

                                level = level + 1;
                                Console.WriteLine(MonsterDefeat, level);
                                break;
                            case >= 5:
                                Console.WriteLine(MaxLevel);
                                break;
                        }
                        break;
                    case 3:
                        for (int i = 0; i < matrixTreasure.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrixTreasure.GetLength(1); j++)
                            {
                                int gold = rnd.Next(MinChance, MaxChance);
                                if (gold == TreasureChance)
                                {
                                    matrixTreasure[i, j] = Treasure;
                                }
                            }
                        }

                        Console.WriteLine(AttemptsLeft, attempts);
                        Console.WriteLine(MineMap);

                        for (int i = 0; i < matrixMap.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrixMap.GetLength(1); j++)
                            {
                                matrixMap[i, j] = NotDigged;
                                Console.Write($"{matrixMap[i, j]}");
                            }
                            Console.WriteLine();
                        }
                        break;
                }
            }
        } while (op != 0);
    }
}

