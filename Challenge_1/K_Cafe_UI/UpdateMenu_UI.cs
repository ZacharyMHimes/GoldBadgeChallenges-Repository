using static System.Console;

public class UpdateMenu_UI
{   
private bool isUpdateUI;
private Menu_Repository _menuRepo;
public UpdateMenu_UI()
        {
            _menuRepo = new Menu_Repository();
        }
public void Run()
        {
            OpenUpdateMenu();
        }
private void OpenUpdateMenu()
        {
            isUpdateUI = true;
            while (isUpdateUI)
                {   Clear();
                    ViewUpdateUI();
                };
        }
private void CloseUpdateUI()
    {
            Clear();
            isUpdateUI = false;
    }   

private void ViewUpdateUI()
    {   Clear();
        ForegroundColor = ConsoleColor.DarkGreen;
        WriteLine("\n" 
            + "                                                                                                                \n" 
            + "                                   Komodo Insurance Cafe Menu Management Application                              ");  Console.ForegroundColor = ConsoleColor.DarkYellow;System.Console.WriteLine(
            "                                                    Update Menu Options                                            \n"); 
        ResetColor();                                                                                                              
        WriteLine("\n"
            + "                                                                                                                \n"
            + "     1. Add An Item                                                                 . ------------              \n"
            + "     2. Remove An Item                                                              . ------------              \n" 
            + "     3. Create New Combo                                                            . ------------              \n" 
            + "     4. -------------                                                               . ------------              \n" 
            + "     5. -------------                                                             10. Back To Main              \n" 
            + "                                                                                                                \n"); 
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            System.Console.WriteLine("\n"
            + " Please Enter a Menu Number:");
            ResetColor();

            var mainMenuNav = ReadLine();
            switch (mainMenuNav)
            {
                case "1":
                    Console.Clear();
                    AddAnItem();
                    break;
                case "2":
                    Console.Clear();
                    //RemoveAnItem();
                    break;
                case "3":
                    Console.Clear();
                    //CreateNewCombo();
                    break;
                case "10":
                    Console.Clear();
                    isUpdateUI = false;
                    break;   
                default:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    WriteLine("Invalid Selection, Please Enter an Integer Value");
                    ResetColor();
                    break;
            }
    }

private void AddAnItem()
        {
        ForegroundColor = ConsoleColor.DarkGreen;
        WriteLine("\n" 
            + "                                                                                                                \n" 
            + "                                   Komodo Insurance Cafe Menu Management Application                              ");  Console.ForegroundColor = ConsoleColor.DarkYellow;System.Console.WriteLine(
            "                                                    Update Menu Options                                            \n"); 
        ResetColor();       
        WriteLine("\n"
                + " What type of item would you like to Add?"
                + "1. Entree \n"
                + "2. Drink  \n"
                + "3. Side / Other");

        var userinput = ReadLine();
        switch (userinput)
            {
                case "1":
                    AddNewEntree();
                    break;

                // case "2":
                //     AddNewDrink();
                //     break;

                // case "3":
                //     AddNewSide();
                //     break;

                default:
                    WriteLine("Invalid Selection - Please Enter an Integer");
                    AddAnItem();
                    break;
            }
        }
private void AddNewEntree()
    {

        EntreeItem_A_La_Cart entree = EntreeInput();
            if (_menuRepo.AddMenuItemEntree(entree))
            {
                System.Console.WriteLine($"Entree Menu Updated to include {entree.MenuItem_Name} ");
                ReadKey();
            }
            else
            { 
                System.Console.WriteLine("Unable to add new item.");
                ReadKey();
            }
    }
private EntreeItem_A_La_Cart EntreeInput()

        {Clear();
        ForegroundColor = ConsoleColor.DarkGreen;
        WriteLine("\n" 
            + "                                                                                                                \n" 
            + "                                   Komodo Insurance Cafe Menu Management Application                              ");  Console.ForegroundColor = ConsoleColor.DarkYellow;System.Console.WriteLine(
            "                                                    Update Menu Options                                            \n"); 
        ResetColor();      
        EntreeItem_A_La_Cart entree = new EntreeItem_A_La_Cart();
        
        ForegroundColor = ConsoleColor.DarkMagenta;
        WriteLine("Enter a Name for the new Entree:");
        ResetColor();
        entree.MenuItem_Name = ReadLine();
        
        ForegroundColor = ConsoleColor.DarkMagenta;
        WriteLine("Enter a short description for the new Entree:");
        ResetColor();
        entree.MenuItem_Description = ReadLine();

        ForegroundColor = ConsoleColor.DarkMagenta;
        WriteLine("Enter a price (0.00) for the new Entree:");
        ResetColor();

		string userInput;
        double doubleVal;
        
        userInput = Console.ReadLine();
        doubleVal = Convert.ToDouble(userInput);
        entree.MenuItem_Price = doubleVal;
        
        return entree;

    }
}
