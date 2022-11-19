using static System.Console;

public class Delivery_UI
{
        
private Delivery_Repository _delivRepo;

public Delivery_UI()
    {
        _delivRepo = new Delivery_Repository();
    }
    
public bool isRunning = true; 
public void Run()
    {   while (isRunning == true)
        {   
            RunApplication();
        };
    } 

//* MAIN MENU
private void RunApplication()
    {   Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkGreen;
            System.Console.WriteLine("\n" 
            + "                                                                                                                \n" 
            + "                                   Warner Transit Delivery Management Application                              ");  Console.ForegroundColor = ConsoleColor.DarkYellow;System.Console.WriteLine(
            "                                                    Main Menu Options                                            \n"); 
        ResetColor();                                                                                                              
            System.Console.WriteLine("\n"
            + "                                                                                                                \n"
            + "     1. Add a New Delivery                                                         6. Do a little dance         \n"
            + "     2. List Deliveries by Status                                                  7. Make a little love        \n" 
            + "     3. Update Delivery Status                                                     8. Get down tonight          \n" 
            + "     4. Cancel a Delivery                                                          9. ------------              \n" 
            + "     5. -----------------------                                                    10.Application Sign Out      \n" 
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
                    ListAllDeliveries();
                    break;
                case "2":
                    Console.Clear();
                    ListAllDeliveries();
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

private void ListAllDeliveries()
    {
        List<Delivery> delivsInDb = _delivRepo.GetAllDeliveries();
        DisplayDeliveries_ByStatus(delivsInDb);

    }

private void DisplayDeliveries_ByStatus(List<Delivery> delivsInDb)
        {
        if (delivsInDb.Count > 0)
        {
            foreach (Delivery deliv in delivsInDb)
            {   Console.ForegroundColor = ConsoleColor.DarkRed;  
                WriteLine($"Delivery Number: ----- {deliv.Id} ----- "); ResetColor();
                WriteLine($"Order Date: --- {deliv.OrderDate} ---\n"
                        + $"Item Number: {deliv.ItemNumber}      \n"
                        + $"Quantity:  {deliv.ItemQuantity}      \n"
                        + $"Cutsomer ID: --- {deliv.CustomerId} ---");
            }
            Console.ForegroundColor = ConsoleColor.DarkMagenta; 
            System.Console.WriteLine("Return to Main");
            ReadKey();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            System.Console.WriteLine("Something Went Wrong. Return to Main.");
            ReadKey();
        }
    }
    }
