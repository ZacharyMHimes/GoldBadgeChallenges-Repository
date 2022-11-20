using System.Net.Mail;
using static System.Console;

public class Delivery_UI
{
        
private Delivery_Repository _delivRepo;

public Delivery_UI()
    {
        _delivRepo = new Delivery_Repository();
    }
    
public enum OrderStatus
    {
    complete, enRoute, scheduled, cancelled
    }

public void ProcessOrderStatus(OrderStatus status)
    {
        switch(status)
        {
        case OrderStatus.complete:
            System.Console.WriteLine("Order Status: Complete");
            break;

        case OrderStatus.enRoute:
            System.Console.WriteLine("Order Status: En Route");
            break;

        case OrderStatus.scheduled:
            System.Console.WriteLine("Order Status: En Route");
            break; 
        case OrderStatus.cancelled:
            System.Console.WriteLine("Order Status: En Route");
            break; 
        }
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
        DisplayDeliveryStatus(delivsInDb);

    }

private void DisplayDeliveryStatus(List<Delivery> delivsInDb)
        {
        if (delivsInDb.Count > 0)
        {
            foreach (Delivery deliv in delivsInDb)
            {   

                switch(OrderStatus):
                case OrderStatus.complete:
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;  
                        WriteLine($"Delivery Number: ----- {deliv.Id} ----- "); Console.ForegroundColor = ConsoleColor.DarkGreen; WriteLine("Delivery Complete");
                        WriteLine($"Order Date: --- {deliv.OrderDate} ---\n"
                        + $"Item Number: {deliv.ItemNumber}      \n"
                        + $"Quantity:  {deliv.ItemQuantity}      \n"
                        + $"Cutsomer ID: --- {deliv.CustomerId} ---");
                        break;
                case 2:
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;  
                        WriteLine($"Delivery Number: ----- {deliv.Id} ----- "); Console.ForegroundColor = ConsoleColor.DarkGreen; WriteLine("Delivery En Route");
                        WriteLine($"Order Date: --- {deliv.OrderDate} ---\n"
                        + $"Item Number: {deliv.ItemNumber}      \n"
                        + $"Quantity:  {deliv.ItemQuantity}      \n"
                        + $"Cutsomer ID: --- {deliv.CustomerId} ---");
                        break;
                case 3:
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;  
                        WriteLine($"Delivery Number: ----- {deliv.Id} ----- "); Console.ForegroundColor = ConsoleColor.DarkGreen; WriteLine("Delivery Scheduled");
                        WriteLine($"Order Date: --- {deliv.OrderDate} ---\n"
                        + $"Item Number: {deliv.ItemNumber}      \n"
                        + $"Quantity:  {deliv.ItemQuantity}      \n"
                        + $"Cutsomer ID: --- {deliv.CustomerId} ---");
                        break;
                case 4:
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;  
                        WriteLine($"Delivery Number: ----- {deliv.Id} ----- "); Console.ForegroundColor = ConsoleColor.DarkGreen; WriteLine("Delivery Cancelled");
                        WriteLine($"Order Date: --- {deliv.OrderDate} ---\n"
                        + $"Item Number: {deliv.ItemNumber}      \n"
                        + $"Quantity:  {deliv.ItemQuantity}      \n"
                        + $"Cutsomer ID: --- {deliv.CustomerId} ---");
                        break;
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
