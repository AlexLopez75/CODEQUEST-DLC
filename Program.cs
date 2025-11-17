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
        const string MsgNameConfirm = "Your wizard's name is: ";
        const string InputNameError = "Input a name without spaces.";

        //Main menu
        int op = 0;
        bool setWizard = false;

        //Chapter 1:
        string wizardName = "none", title = "none", space = " ";
        bool validInput, badName = false;
       

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
                            if (badName = wizardName.Contains(space)) 
                            {
                                Console.WriteLine(InputNameError);
                                badName = true;
                            }
                        } while (badName);
                       
                        Console.WriteLine(MsgNameConfirm + wizardName);
                        setWizard = true;
                        break;
                }
            }
        } while (op != 0);
    }
}
