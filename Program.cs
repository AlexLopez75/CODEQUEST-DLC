using System;
using System.Data.Common;
using System.Diagnostics.Metrics;
using System.Drawing;
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
        const string MonsterDefeat = "You have defeated the monster, your level increasses to level {0}.";
        const string MaxLevel = "You have achieved max level.";
        const int MinMonster = 0;
        const int MaxMonster = 8;
        const int MinDamage = 1;
        const int MaxDamage = 7;

        //Chapter 3:
        const string MineMap = "Here's the map of the mine.";
        const string XCoordinates = "     0 1 2 3 4\n     - - - - -";
        const string Treasure = "🪙";
        const string NotDigged = "➖";
        const string Nothing = "❌";
        const string InputRow = "Input a row (0-4): ";
        const string InputColumn = "Input a column (0-4): ";
        const string InputError = "Input a number between 0 and 4";
        const string MsgDigIn = "Digging in coordinates ({0},{1})...";
        const string AttemptsLeft = "You have {0} attempts left.";
        const string AlreadyDigged = "You have already digged this coordenate";
        const string MsgEmpty = "There's nothing in here.";
        const string MsgFound = "You struck a gold! Bits found: ";
        const string TotalBitsFound = "You have found a total of {0} bits in this mine";
        const int MinChance = 1;
        const int MaxChance = 4;
        const int MinBits = 5;
        const int MaxBits = 51;

        //Chapter 4:
        const string InventoryEmpty = "The inventory is empty";

        //Chapter 5:
        const string EnterShop = "Welcome to the shop, kid. What will you buy?";
        const string ShopNames = "Item\t\t\tPrice";
        const string SelectItem = "Input (1-5) to select an item to purchase or 0 to exit the shop.";
        const string YourBits = "You have {0} bits in your possesion.";
        const string InputErrorItem = "Input a number from 1 and 7.";
        const string SuficientBits = "Thank you for your purchase, kid.";
        const string BuyMessage = "You have bought a {0}.";
        const string NotEnoughBits = "It seems you dont have enough bits. Come when you have more, kid.";
        const string LeaveShop = "Come again, kid.";
        const int MinItem = 1;
        const int MaxItem = 6;

        //Chapter 6:
        const string ShowAttacks = "These are the magic spells you posess at level {0}.";
        const string GetStronger = "Learn new skills by training and leveling up!";
        const string MaxLevelSkills = "You have learned the master skills. Now go and defeat the final boss!";

        //Chapter 7:
        const string FoundScrolls = "You have found the ancient scrolls, but they are encrypted.";
        const string SelectScroll = "Select a method of decoding:";
        const string DecodeMethods = "1. Decipher spell (remove spaces).\n2. Count magical runes (vowels).\n3. Extract secret code (numbers).";
        const string InputErrorScrolls = "Input a number between 1 and 3.";
        const string DecodedSpell = "Decoded spell: {0}";
        const string MagicalRunes = "{0} magical runes (vowels) found.";
        const string SecretCode = "The secret code is: ";
        const string AllScrollsDecoded = "Congratulations, you have succesfully decoded all the ancient scrolls. Now you know the secrets of the ancients!";

        //Menu:
        int op = 0;
        bool setWizard = false;

        //Chapter 1:
        int day, hour, power, totalHour = 0, totalPower = 0, level = 1;
        string wizardName = "none",  title = "none", space = " ";
        bool validInput = true, badName = false;

        //Chapter 2:
        int[] arrayHp = { 3, 5, 10, 11, 18, 15, 20, 50 };
        string[] arrayMonsters = { "Wandering Skeleton 💀", "Forest Goblin 👹", "Green Slime 🟢", "Ember Wolf 🐺", "Giant Spider 🕷️", "Iron Golem 🤖", "Lost Necromancer 🧝‍", "Ancient Dragon 🐉" };
        string[] arrayDice = { DiceRoll1, DiceRoll2, DiceRoll3, DiceRoll4, DiceRoll5, DiceRoll6 };
        int health;

        //Chapter 3:
        string[] yCoordinates = { "0 - ", "1 - ", "2 - ", "3 - ", "4 - " };
        string[,] matrixTreasure = new string[5, 5];
        string[,] matrixMap = new string[5, 5];
        int attempts = 5, row, column, bits = 0, totalBits = 0;

        //Chapter 4:
        string[] inventorySlots = new string [1];

        //Chapter 5:
        string[] arrayItems = { "Iron Dagger 🗡️", "Healing Potion ⚗️", "Ancient Key 🗝️", "Crossbow 🏹", "Metal Shield 🛡️" };
        int[] arrayPrice = { 30, 10, 50, 40, 20 };
        int shopSelect = 1;

        //Chapter 6:
        string[][] arrayLevel = new string[5][];
        arrayLevel[0] = new string[1] { "Magic Spark 💫" };
        arrayLevel[1] = new string[3] { "Fireball 🔥", "Ice Ray 🥏", "Arcane Shield ⚕️" };
        arrayLevel[2] = new string[4] { "Meteor ☄️", "Pure Energy Explosion 💥", "Minor Charm 🎭", "Air Strike 🍃" };
        arrayLevel[3] = new string[2] { "Wave of Light ⚜️", "Storm of Wings 🐦" };
        arrayLevel[4] = new string[4] { "Cataclysm 🌋", "Portal of Chaos 🌀", "Arcane Blood Pact 🩸", "Elemental Storm ⛈️" };

        //Chapter 7:
        string[] arrayScrolls = { "When the moon is full, the arcana will be the means of which all will be revealed.", "The magic in the inside is the strenght to conquer the fear of of death.", "Spells: Diarahan ✨ 4, Panta rei 🌪️ 6, Myriad truths ☄️ 9, Matarukaja 💪 3." };
        char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
        char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        int vowelsCounter = 0;
        bool[] arrayDecoded = { false, false, false };
        bool scrollInput = true;

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
                    case 2:
                        switch (level)
                        {
                            case < 5:
                                int monster = rnd.Next(MinMonster, MaxMonster);
                                Console.WriteLine(MonsterEncounter, arrayMonsters[monster]);
                                health = arrayHp[monster];

                                do
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine(MonsterHp, arrayMonsters[monster], health);
                                    int damage = rnd.Next(MinDamage, MaxDamage);
                                    Console.WriteLine(arrayDice[damage - 1]);
                                    health = health - damage;
                                    Console.WriteLine(DiceResult, (damage));
                                    Console.WriteLine(MonsterDamage, damage);
                                    Console.WriteLine(PressEnter);
                                    Console.ReadLine();
                                } while (health > 0);

                                level = level + 1;
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine(MonsterDefeat, level);
                                Console.ReadLine();
                                Console.ForegroundColor = ConsoleColor.White;
                                break;
                            case >= 5:
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine(MaxLevel);
                                Console.ReadLine();
                                Console.ForegroundColor = ConsoleColor.White;
                                break;
                        }
                        break;
                    case 3:
                        for (int i = 0; i < matrixTreasure.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrixTreasure.GetLength(1); j++)
                            { 
                                matrixTreasure[i, j] = rnd.Next(MinChance, MaxChance) > 2 ? $"{Treasure}" : $"{Nothing}";
                            }
                        }
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine(MineMap);
                        Console.WriteLine();
                        Console.WriteLine(XCoordinates);
                        for (int i = 0; i < matrixMap.GetLength(0); i++)
                        {
                            Console.Write($"{yCoordinates[i]}");
                            for (int j = 0; j < matrixMap.GetLength(1); j++)
                            {
                                matrixMap[i, j] = NotDigged;
                                Console.Write($"{matrixMap[i, j]}");
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine();

                        for (attempts = 5; attempts > 0; attempts--)
                        {
                            validInput = false;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine(AttemptsLeft, attempts);
                            Console.WriteLine();
                            Console.WriteLine(InputRow);
                            do
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                validInput = Int32.TryParse(Console.ReadLine(), out row);
                                Console.WriteLine();
                                if (row >= 0 && row <= 4 && validInput)
                                {
                                    validInput = false;
                                    Console.WriteLine(InputColumn);
                                    do
                                    {
                                        Console.ForegroundColor = ConsoleColor.White;
                                        validInput = Int32.TryParse(Console.ReadLine(), out column);
                                        Console.WriteLine();
                                        if (column >= 0 && column <= 4 && validInput)
                                        {
                                            if (matrixMap[row, column] != Treasure && matrixMap[row, column] != Nothing)
                                            {
                                                Console.WriteLine(MsgDigIn, row, column);
                                                if (matrixTreasure[row, column].Equals(Treasure))
                                                {
                                                    matrixMap[row, column] = Treasure;
                                                    bits = rnd.Next(MinBits, MaxBits);
                                                    totalBits = totalBits + bits;
                                                }
                                                else
                                                {
                                                    matrixMap[row, column] = Nothing;
                                                }
                                                Console.ForegroundColor = ConsoleColor.Yellow;
                                                Console.WriteLine(matrixMap[row, column] == Treasure ? $"{MsgFound}{bits}" : $"{MsgEmpty}");
                                            }
                                            else
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine(AlreadyDigged);
                                                Console.WriteLine();
                                                attempts++;
                                            }
                                        }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine(InputError);
                                            Console.WriteLine();
                                            validInput = false;
                                        }
                                    } while (column < 0 || column >= 5 || !validInput);
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine(InputError);
                                    Console.WriteLine();
                                    validInput = false;
                                }
                            } while (row < 0 || row >= 5 || !validInput);

                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine();
                            Console.WriteLine(MineMap);
                            Console.WriteLine();
                            Console.WriteLine(XCoordinates);
                            for (int i = 0; i < matrixMap.GetLength(0); i++)
                            {
                                Console.Write($"{yCoordinates[i]}");
                                for (int j = 0; j < matrixMap.GetLength(1); j++)
                                {
                                    Console.Write($"{matrixMap[i, j]}");
                                }
                                Console.WriteLine();
                            }
                        }
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine();
                        Console.WriteLine(TotalBitsFound, totalBits);
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.WriteLine();
                        if (inventorySlots[0] != null)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            for (int i = 0; i < inventorySlots.Length; i++)
                            {
                                Console.WriteLine($"{inventorySlots[i]}");
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(InventoryEmpty);
                        }
                        Console.WriteLine();
                        break;
                    case 5:
                        validInput = false;
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine();
                        Console.WriteLine(EnterShop);
                        Console.WriteLine();
                        do
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine(ShopNames);
                            for (int i = 0; i < arrayItems.Length; i++)
                            {
                                Console.Write($"{arrayItems[i]}     \t{arrayPrice[i]}\n");
                            }
                            Console.WriteLine(SelectItem);
                            Console.WriteLine(YourBits, totalBits);
                            Console.WriteLine();
                            try
                            {
                                validInput = Int32.TryParse(Console.ReadLine(), out shopSelect);
                                Console.WriteLine();
                                if (shopSelect >= MinItem && shopSelect < MaxItem && validInput)
                                {
                                    if (totalBits < arrayPrice[shopSelect - 1])
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine(NotEnoughBits);
                                    }
                                    else
                                    {
                                        inventorySlots[inventorySlots.Length - 1] = arrayItems[shopSelect - 1];
                                        totalBits -= arrayPrice[shopSelect - 1];
                                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                                        Console.WriteLine(SuficientBits);
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine(BuyMessage, arrayItems[shopSelect - 1]);
                                        string[] auxArray = new string[inventorySlots.Length + 1];
                                        for (int i = 0; i < inventorySlots.Length; i++)
                                        {
                                            auxArray[i] = inventorySlots[i];
                                        }
                                        inventorySlots = auxArray;
                                    }
                                }
                            }
                            catch (FormatException)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(InputErrorItem);
                                Console.WriteLine();
                            }
                            catch (Exception)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(InputErrorItem);
                                Console.WriteLine();
                            }
                        } while (shopSelect != 0);
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine(LeaveShop);
                        Console.WriteLine();
                        break;
                    case 6:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine();
                        Console.WriteLine(ShowAttacks, level);
                        Console.WriteLine();
                        for (int i = 0; i < arrayLevel[level - 1].Length; i++)
                        {
                            Console.WriteLine($"{arrayLevel[level - 1][i]}");
                        }
                        switch (level)
                        {
                            case < 5:
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine();
                                Console.WriteLine(GetStronger);
                                break;
                            case >= 5:
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine();
                                Console.WriteLine(MaxLevelSkills);
                                break;
                        }
                        Console.WriteLine();
                        break;
                    case 7:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(FoundScrolls);
                        Console.WriteLine();
                        for (int i = 0; i < arrayScrolls.Length; i++)
                        {
                            Console.WriteLine($"{i + 1}. {arrayScrolls[i]}");
                        }
                        do
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine();
                            Console.WriteLine(SelectScroll);
                            Console.WriteLine();
                            Console.WriteLine(DecodeMethods);
                            Console.WriteLine();
                            try
                            {
                                int scroll = Int32.Parse(Console.ReadLine());

                                switch (scroll)
                                {
                                    case 1:
                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                        Console.WriteLine(DecodedSpell, arrayScrolls[0].Replace(" ", ""));
                                        Console.WriteLine();
                                        arrayDecoded[0] = true;
                                        break;
                                    case 2:
                                        char[] scroll2 = arrayScrolls[1].ToCharArray();
                                        foreach (char letter in scroll2)
                                        {
                                            foreach (char vowel in vowels)
                                            {
                                                if (letter.Equals(vowel))
                                                {
                                                    vowelsCounter++;
                                                }
                                            }
                                        }
                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                        Console.WriteLine(MagicalRunes, vowelsCounter);
                                        Console.WriteLine();
                                        arrayDecoded[1] = true;
                                        break;
                                    case 3:
                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                        Console.Write(SecretCode);
                                        char[] scroll3 = arrayScrolls[2].ToCharArray();
                                        foreach (char letter in scroll3)
                                        {
                                            foreach (char number in numbers)
                                            {
                                                if (letter.Equals(number))
                                                {
                                                    Console.Write(number);
                                                }
                                            }
                                        }
                                        Console.WriteLine();
                                        arrayDecoded[2] = true;
                                        break;
                                }
                            }
                            catch (FormatException)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(InputErrorScrolls);
                                scrollInput = false;
                            }
                            catch (Exception)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(InputErrorScrolls);
                                scrollInput = false;
                            }
                        } while (scrollInput != true);
                        if (arrayDecoded[0] == true && arrayDecoded[1] == true && arrayDecoded[2] == true)
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine(AllScrollsDecoded);
                            Console.WriteLine();
                        }
                        break;
                }
            }
        } while (op != 0);
    }
}

