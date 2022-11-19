using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using static System.Console;
public class K_Cafe_UI
{
    public K_Cafe_UI()
    {
        _MenuRepo = new Menu_Repository();
        _runUpdateMenu_UI = new UpdateMenu_UI();
        _orderRepo = new Order_Repository(_MenuRepo);
    }
    
    private Menu_Repository _MenuRepo;
    private Order_Repository _orderRepo;
    private UpdateMenu_UI _runUpdateMenu_UI;

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
            + "     3. List Side Options                                                          8. List Current Orders       \n" 
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
                    _runUpdateMenu_UI.Run();
                    break;
                case "7":
                    Console.Clear();
                    //CreateAnOrder();   // No Need to Delete Orders, because the Orders Repo also serves as a 
                    break;             // Receipt for the entered Orders. Instead Edit Comments to "void" 
                case "8":              // this discourages employees from creating orders then cancelling to give the food away. 
                    Console.Clear();
                    ListCurrentOrders(); //todo fulfils the rubric requirement to list ingredients (order contents)
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
        List<EntreeItem_A_La_Cart> entree = _MenuRepo.GetAllEntrees();
        DisplayEntrees(_MenuRepo.GetAllEntrees());
    }
private void DisplayEntrees(List<EntreeItem_A_La_Cart> entrees)
    {   
        foreach (var item in entrees)
                    {WriteLine($"{item.MenuItem_ID} ====== {item.MenuItem_Name} ====== {item.MenuItem_Price} \n"
                            +$"     {item.MenuItem_Description}  \n");}
        ReadKey();
    }

private void ListDrinkItems()
    {
        List<Drinks_A_La_Cart> drink = _MenuRepo.GetAllDrinks();
        DisplayDrinks(_MenuRepo.GetAllDrinks());
    }

private void DisplayDrinks(List<Drinks_A_La_Cart> drinks)
    {
        foreach (var item in drinks)
                {WriteLine($"{item.MenuItem_ID} ===== {item.MenuItem_Name} ===== {item.MenuItem_Price}");}
        ReadKey();
    }
private void ListSideItems()
    {
        List<AddOns_A_La_Cart> side = _MenuRepo.GetAllSides();
        DisplaySides(_MenuRepo.GetAllSides());
    }
private void DisplaySides(List<AddOns_A_La_Cart> sides)
    {
        foreach (var item in sides)
                {WriteLine($"{item.MenuItem_ID} ===== {item.MenuItem_Name} ===== {item.MenuItem_Price}");}
        ReadKey();
    }

private void ListCurrentOrders()
    {
        List<Order> _orderDb = _orderRepo.GetAllOrders();
        DisplayOrders(_orderRepo.GetAllOrders());
    }
private void DisplayOrders(List<Order> orderList)
    {
        foreach (var order in orderList)
                {Console.ForegroundColor = ConsoleColor.DarkGreen;
                    WriteLine($"==== Order Number: {order.OrderId} =================== "); ResetColor();
                    WriteLine($"{order.OrderName}");

                    foreach (var entree in order.Entree)
                            {WriteLine($"{entree.MenuItem_Name}");};

                    foreach (var side in order.ALaCart)
                            {WriteLine($"{side.MenuItem_Name} ");};

                    foreach (var drink in order.Drink)
                            {WriteLine($"{drink.MenuItem_Name} ");};
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                    WriteLine($"{order.Order_Notes}"); ResetColor();
                    

                }                    
        ReadKey();
    }


}
