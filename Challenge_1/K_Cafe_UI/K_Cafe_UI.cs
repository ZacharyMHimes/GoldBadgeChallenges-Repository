using System.Runtime.CompilerServices;
using static System.Console;
public class K_Cafe_UI
{
    public K_Cafe_UI()
    {
        _menuRepo = new Menu_Repository();
    }
    private Menu_Repository _menuRepo;

public bool isRunning = true; 
public void Run()
    {   while (isRunning == true)
        {   
            RunApplication();
        };
    } 

//* MAIN MENU
private void RunApplication()
    {   Clear();
        ForegroundColor = ConsoleColor.DarkGreen;
        WriteLine("\n" 
            + "                                                                                                                \n" 
            + "                                   Komodo Insurance Cafe Menu Management Application                              ");  Console.ForegroundColor = ConsoleColor.DarkYellow;System.Console.WriteLine(
            "                                                    Main Menu Options                                            \n"); 
        ResetColor();                                                                                                              
        WriteLine("\n"
            + "                                                                                                                \n"
            + "     1. List Entree Options                                                        6. Update Menu               \n"
            + "     2. List Drink Options                                                         7. Create an Order           \n" 
            + "     3. List Side Options                                                          8. ------------              \n" 
            + "     4. -----------------------                                                    9. ------------              \n" 
            + "     5. Chef's Special                                                             10.Application Sign Out      \n" 
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
                    ListEntreeItems();
                    break;
                case "2":
                    
                    Console.Clear();
                    ListDrinkItems();
                    break;
                case "3":
                    
                    Console.Clear();
                    ListSideItems();
                    break;
                case "6":
                    Console.Clear();
                    //_runupdateMenuUI.Run(); //Update Menu (add / remove entree, drink, sides )
                    break;
                case "7":
                    Console.Clear();
                    //_CreateAnOrder.Run(); //MockUp Order Menu
                    break;
                case "10":
                    Console.Clear();
                    isRunning = false;
                    break;   
                default:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    WriteLine("Invalid Selection, Please Enter an Integer Value");
                    ResetColor();
                    ReadLine();
                    break;
            }
    }

private void ListEntreeItems()
    {
        List<EntreeItem_A_La_Cart> entree = _menuRepo.GetAllEntrees();
        DisplayEntrees(_menuRepo.GetAllEntrees());
    }
private void DisplayEntrees(List<EntreeItem_A_La_Cart> entrees)
    {   
        foreach (var item in entrees)
                    {WriteLine($"{item.MenuItem_ID} . {item.MenuItem_Name}  \n"
                            +$"{item.MenuItem_Description} . {item.MenuItem_Price} \n");}
        ReadKey();
    }

private void ListDrinkItems()
    {
        List<Drinks_A_La_Cart> drink = _menuRepo.GetAllDrinks();
        DisplayDrinks(_menuRepo.GetAllDrinks());
    }

private void DisplayDrinks(List<Drinks_A_La_Cart> drinks)
    {
        foreach (var item in drinks)
                {WriteLine($"{item.MenuItem_ID} . {item.MenuItem_Name} . {item.MenuItem_Price}");}
        ReadKey();
    }
private void ListSideItems()
    {
        List<AddOns_A_La_Cart> side = _menuRepo.GetAllSides();
        DisplaySides(_menuRepo.GetAllSides());
    }
private void DisplaySides(List<AddOns_A_La_Cart> sides)
    {
        foreach (var item in sides)
                {WriteLine($"{item.MenuItem_ID} . {item.MenuItem_Name} . {item.MenuItem_Price}");}
        ReadKey();
    }

}
