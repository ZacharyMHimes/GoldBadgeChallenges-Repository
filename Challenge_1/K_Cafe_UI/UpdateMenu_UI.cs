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
// Main Update Menu
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
            + "     1. Add An Item                                                                 . ------------               \n"
            + "     2. Remove An Item                                                              . ------------              \n" 
            + "     3. Edit Entrees                                                                . ------------              \n" 
            + "      . -------------                                                               . ------------              \n" 
            + "      . -------------                                                             10. Back To Main              \n" 
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
                    RemoveAnItem();
                    break;
                case "3":
                    Console.Clear();
                    ListEntreesToEdit();
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
// Add an Item Menu
private void AddAnItem()
        {
        Clear();
        ForegroundColor = ConsoleColor.DarkGreen;
        WriteLine("\n" 
            + "                                                                                                                \n" 
            + "                                   Komodo Insurance Cafe Menu Management Application                              ");  Console.ForegroundColor = ConsoleColor.DarkYellow;System.Console.WriteLine(
            "                                                    Update Menu Options                                            \n"); 
        ResetColor();       
        WriteLine("\n"
                + " What type of item would you like to Add? \n"
                + "1. Entree \n"
                + "2. Drink  \n"
                + "3. Side / Other");

        var userinput = ReadLine();
        switch (userinput)
            {
                case "1":
                    AddNewEntree();
                    break;

                case "2":
                    AddNewDrink();
                    break;

                case "3":
                    AddNewSide();
                    break;

                default:
                    WriteLine("Invalid Selection - Please Enter an Integer");
                    AddAnItem();
                    break;
            }
        }
//* Add an Entree Methods   
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
{   try {
        Clear();
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
        
        return entree;}
    catch
            {
            WriteLine("Could not complete entry.");
            return null; 
            }

    }
//* Add a Drink Methods
    private void AddNewDrink()
    {

        Drinks_A_La_Cart drink = DrinkInput();
            if (_menuRepo.AddMenuItemDrinks(drink))
            {
                System.Console.WriteLine($"Drink Menu Updated to include {drink.MenuItem_Name} ");
                ReadKey();
            }
            else
            { 
                System.Console.WriteLine("Unable to add new item.");
                ReadKey();
            }
    }
    private Drinks_A_La_Cart DrinkInput()
    { try{
        
            Clear();
        ForegroundColor = ConsoleColor.DarkGreen;
        WriteLine("\n" 
            + "                                                                                                                \n" 
            + "                                   Komodo Insurance Cafe Menu Management Application                              ");  Console.ForegroundColor = ConsoleColor.DarkYellow;System.Console.WriteLine(
            "                                                    Update Menu Options                                            \n"); 
        ResetColor();      
        Drinks_A_La_Cart drink = new Drinks_A_La_Cart();
        
        ForegroundColor = ConsoleColor.DarkMagenta;
        WriteLine("Enter a Name for the new Drink:");
        ResetColor();
        drink.MenuItem_Name = ReadLine();

        ForegroundColor = ConsoleColor.DarkMagenta;
        WriteLine("Enter a price (0.00) for the new Drink:");
        ResetColor();

		string userInput;
        double doubleVal;
        
        userInput = Console.ReadLine();
        doubleVal = Convert.ToDouble(userInput);
        drink.MenuItem_Price = doubleVal;
        
        return drink;}
    catch   {
            WriteLine("Could not complete entry.");
            return null;
            }
    }
//* Add a Side Methods
    private void AddNewSide()
    {

        AddOns_A_La_Cart side = SideInput();
            if (_menuRepo.AddMenuItemSide(side))
            {
                System.Console.WriteLine($"Entree Menu Updated to include {side.MenuItem_Name} ");
                ReadKey();
            }
            else
            { 
                System.Console.WriteLine("Unable to add new item.");
                ReadKey();
            }
    }
    private AddOns_A_La_Cart SideInput()
{   try {
        Clear();
        ForegroundColor = ConsoleColor.DarkGreen;
        WriteLine("\n" 
            + "                                                                                                                \n" 
            + "                                   Komodo Insurance Cafe Menu Management Application                              ");  Console.ForegroundColor = ConsoleColor.DarkYellow;System.Console.WriteLine(
            "                                                    Update Menu Options                                            \n"); 
        ResetColor();      
        AddOns_A_La_Cart side = new AddOns_A_La_Cart();
        
        ForegroundColor = ConsoleColor.DarkMagenta;
        WriteLine("Enter a Name for the new Side:");
        ResetColor();
        side.MenuItem_Name = ReadLine();

        ForegroundColor = ConsoleColor.DarkMagenta;
        WriteLine("Enter a price (0.00) for the new Entree:");
        ResetColor();

		string userInput;
        double doubleVal;
        
        userInput = Console.ReadLine();
        doubleVal = Convert.ToDouble(userInput);
        side.MenuItem_Price = doubleVal;
        
        return side;}
    catch
            {
            WriteLine("Could not complete entry.");
            return null; 
            }

    }
//Remove an Item Menu
private void RemoveAnItem()
        {
        Clear();
        ForegroundColor = ConsoleColor.DarkGreen;
        WriteLine("\n" 
            + "                                                                                                                \n" 
            + "                                   Komodo Insurance Cafe Menu Management Application                              ");  Console.ForegroundColor = ConsoleColor.DarkYellow;System.Console.WriteLine(
            "                                                    Update Menu Options                                            \n"); 
        ResetColor();       
        WriteLine("\n"
                + " What type of item would you like to Remove? \n"
                + "1. Entree \n"
                + "2. Drink  \n"
                + "3. Side / Other");

        var userinput = ReadLine();
        switch (userinput)
            {
                case "1":
                    ListEntreesToDelete();
                    Clear();
                    break;

                case "2":
                    ListDrinksToDelete();
                    break;

                // case "3":
                //     RemoveSide(); //todo
                //     break;

                default:
                    WriteLine("Invalid Selection - Please Enter an Integer");
                    AddAnItem();
                    break;
            }
        }

//* Remove Entree Methods
    private void ListEntreesToDelete()
    {
        List<EntreeItem_A_La_Cart> entreesInDb = _menuRepo.GetAllEntrees();
        DisplayEntree_RemoveOptions(entreesInDb);
    }
    private void DisplayEntree_RemoveOptions(List<EntreeItem_A_La_Cart> entreesInDb)
    {
        if (entreesInDb.Count > 0)
        {
            foreach (EntreeItem_A_La_Cart item in entreesInDb)
            {
            WriteLine($" {item.MenuItem_ID}  ===== {item.MenuItem_Name} =====  {item.MenuItem_Price}");
            }
            Console.ForegroundColor = ConsoleColor.DarkMagenta; 
            WriteLine("Enter the name of the entree you want to remove");
            ResetColor();
            RemoveAnEntree();
        }
        else
        {
            WriteLine("No entrees Found. Press enter to return to menu.");
            ReadKey();
            Clear();
        }
    }
    private void RemoveAnEntree()
    {
        try
        {            
            string usersearchName = (ReadLine());
            EntreeItem_A_La_Cart item = _menuRepo.GetEntreeByName(usersearchName);
            WriteLine($"Do you want to Delete this Item? \n"
                    + "1. Yes \n" 
                    + "2. No"  );
            string userInputDeleteEntree = ReadLine();
            if (userInputDeleteEntree == "1".ToLower())
            {
                if (_menuRepo.DeleteExistingEntree(item))
                {
                    WriteLine($"{item.MenuItem_ID} {item.MenuItem_Name} has been removed from menu.");
                }
                else
                {
                    WriteLine($"{item.MenuItem_Name} was not deleted. \n."
                                +"Returning to menu navigation.");
                }
            }
        }
        catch
        {
                    WriteLine($"The menu item could not be deleted. \n."
                                +"Try confirming this is the item you are looking for.");
        }

        ReadKey();
    }

//* Remove Drink Methods
    private void ListDrinksToDelete()
    {
        List<Drinks_A_La_Cart> drinksInDb = _menuRepo.GetAllDrinks();
        DisplayDrinks_RemoveOptions(drinksInDb);
    }
    private void DisplayDrinks_RemoveOptions(List<Drinks_A_La_Cart> drinksInDb)
    {
        if (drinksInDb.Count > 0)
        {
            foreach (Drinks_A_La_Cart item in drinksInDb)
            {
            WriteLine($" {item.MenuItem_ID}  ===== {item.MenuItem_Name} =====  {item.MenuItem_Price}");
            }
            Console.ForegroundColor = ConsoleColor.DarkMagenta; 
            WriteLine("Enter the name of the drink you want to remove");
            ResetColor();
            RemoveADrink();
        }
        else
        {
            WriteLine("No drinks Found. Press enter to return to menu.");
            ReadKey();
            Clear();
        }
    }
    private void RemoveADrink()
    {
        try
        {            
            string usersearchName = (ReadLine());
            Drinks_A_La_Cart item = _menuRepo.GetDrinkByName(usersearchName);
            WriteLine($"Do you want to Delete this Item? \n"
                    + "1. Yes \n" 
                    + "2. No"  );
            string userInputDeleteDrink = ReadLine();
            if (userInputDeleteDrink == "1".ToLower())
            {
                if (_menuRepo.DeleteExistingDrink(item))
                {
                    WriteLine($"{item.MenuItem_ID} {item.MenuItem_Name} has been removed from menu.");
                }
                else
                {
                    WriteLine($"{item.MenuItem_Name} was not deleted. \n."
                                +"Returning to menu navigation.");
                }
            }
        }
        catch
        {
                    WriteLine($"The menu item could not be deleted. \n."
                                +"Try confirming this is the item you are looking for.");
        }

        ReadKey();
    }
//* Remove Side Methods
    private void ListSidesToDelete()
    {
        List<AddOns_A_La_Cart> addOnsInDb = _menuRepo.GetAllSides();
        DisplaySides_RemoveOptions(addOnsInDb);
    }
    private void DisplaySides_RemoveOptions(List<AddOns_A_La_Cart> addOnsInDb)
    {
        if (addOnsInDb.Count > 0)
        {
            foreach (AddOns_A_La_Cart item in addOnsInDb)
            {
            WriteLine($" {item.MenuItem_ID}  ===== {item.MenuItem_Name} =====  {item.MenuItem_Price}");
            }
            Console.ForegroundColor = ConsoleColor.DarkMagenta; 
            WriteLine("Enter the name of the Side you want to remove");
            ResetColor();
            RemoveASide();
        }
        else
        {
            WriteLine("No drinks Found. Press enter to return to menu.");
            ReadKey();
            Clear();
        }
    }
    private void RemoveASide()
    {
        try
        {            
            string usersearchName = (ReadLine());
            AddOns_A_La_Cart item = _menuRepo.GetSideByName(usersearchName);
            WriteLine($"Do you want to Delete this Item? \n"
                    + "1. Yes \n" 
                    + "2. No"  );
            string userInputDeleteSide = ReadLine();
            if (userInputDeleteSide == "1".ToLower())
            {
                if (_menuRepo.DeleteExistingSide(item))
                {
                    WriteLine($"{item.MenuItem_ID} {item.MenuItem_Name} has been removed from menu.");
                }
                else
                {
                    WriteLine($"{item.MenuItem_Name} was not deleted. \n."
                                +"Returning to menu navigation.");
                }
            }
        }
        catch
        {
                    WriteLine($"The menu item could not be deleted. \n."
                                +"Try confirming this is the item you are looking for.");
        }

        ReadKey();
    }


//* Edit an Entree Methods
private void ListEntreesToEdit()
    {
        List<EntreeItem_A_La_Cart> entreesInDb = _menuRepo.GetAllEntrees();
        DisplayEntree_EditOptions(entreesInDb);
    }
private void DisplayEntree_EditOptions(List<EntreeItem_A_La_Cart> entreesInDb)
    {
        if (entreesInDb.Count > 0)
        {
            foreach (EntreeItem_A_La_Cart item in entreesInDb)
            {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            WriteLine($" {item.MenuItem_ID} ===== {item.MenuItem_Name} =====  {item.MenuItem_Price} "); ResetColor();
            WriteLine(       $"{item.MenuItem_Description} \n");                                 Console.ForegroundColor = ConsoleColor.DarkGreen; 
            WriteLine("===============================================================");        ResetColor();
            }
            Console.ForegroundColor = ConsoleColor.DarkMagenta; 
            WriteLine("Enter the name of the entree you want to Edit");
            ResetColor();
            EditAnEntree();
        }
        else
        {
            WriteLine("No entrees Found. Press enter to return to menu.");
            ReadKey();
            Clear();
        }
    }
private void EditAnEntree()
    {
        try
        {            
            string usersearchName = (ReadLine());
            EntreeItem_A_La_Cart item = _menuRepo.GetEntreeByName(usersearchName);
            WriteLine($"Do you want to Edit this Item? \n"
                    + "1. Yes \n" 
                    + "2. No"  );
            string userEditEntree = ReadLine();
            if (userEditEntree == "1".ToLower())
            {
                EntreeItem_A_La_Cart updatedEntree = EditEntreeInput();
                        if (_menuRepo.UpdateExistingEntree(usersearchName, updatedEntree))
                    {
                        WriteLine($" The Entree {updatedEntree.MenuItem_Name}, was Successfully Updated.");
                    }
                    else
                    {
                        WriteLine($"The Entree {updatedEntree.MenuItem_Name}, was NOT Updated.");
                    }
            }
        }
        catch
        {
                    WriteLine($"The menu item could not be updated. \n."
                                +"Returning to Menu Management.");
        }

        ReadKey();
    }
private EntreeItem_A_La_Cart EditEntreeInput()
    {   try {
        Clear();
        ForegroundColor = ConsoleColor.DarkGreen;
        WriteLine("\n" 
            + "                                                                                                                \n" 
            + "                                   Komodo Insurance Cafe Menu Management Application                              ");  Console.ForegroundColor = ConsoleColor.DarkYellow;System.Console.WriteLine(
            "                                                    Update Menu Options                                            \n"); 
        ResetColor();      
        EntreeItem_A_La_Cart updatedEntree = new EntreeItem_A_La_Cart();

        ForegroundColor = ConsoleColor.DarkMagenta;
        WriteLine("Enter the Menu Number for the Entree:");
        ResetColor();
        updatedEntree.MenuItem_ID = int.Parse(ReadLine());

        ForegroundColor = ConsoleColor.DarkMagenta;
        WriteLine("Update the Name for the Entree:");
        ResetColor();
        updatedEntree.MenuItem_Description = ReadLine();

        ForegroundColor = ConsoleColor.DarkMagenta;
        WriteLine("Update the description for the Entree:");
        ResetColor();
        updatedEntree.MenuItem_Description = ReadLine();

        ForegroundColor = ConsoleColor.DarkMagenta;
        WriteLine("Enter a new price (0.00) for the Entree:");
        ResetColor();

		string userInput;
        double doubleVal;
        
        userInput = Console.ReadLine();
        doubleVal = Convert.ToDouble(userInput);
        updatedEntree.MenuItem_Price = doubleVal;
        
        return updatedEntree;}
    catch
            {
            WriteLine("Could not complete entry.");
            return null; 
            }

    }

}