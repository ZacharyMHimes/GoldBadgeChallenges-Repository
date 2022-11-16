using static System.Console;
public class K_Cafe_UI
{
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
                    //listEntreeItems();
                    break;
                case "2":
                    
                    Console.Clear();
                    //listDrinkItems();
                    break;
                case "3":
                    
                    Console.Clear();
                    //listSideItems();
                    break;
                case "6":
                    Console.Clear();
                    _runupdateMenuUI.Run(); //Update Menu (add / remove entree, drink, sides )
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
}
