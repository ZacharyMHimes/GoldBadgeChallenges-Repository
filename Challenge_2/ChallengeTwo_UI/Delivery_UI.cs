using System.Net.Mail;
using static System.Console;

public class Delivery_UI
{
        
public Delivery_Repository _delivRepo;

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
            + "     1. View Deliveries in Sequence                                                6. Do a little dance         \n"
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
                    ViewDeliveriesInSequence();
                    break;
                case "2":
                    Console.Clear();
                    ViewDeliveryByStatus();
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
//* Deliveries in Sequence Methods
private void ViewDeliveriesInSequence()
    {
        List<Delivery> delivsInDb = _delivRepo.GetAllDeliveries();
        DisplayDeliveryInfo(delivsInDb);
    }
private void DisplayDeliveryInfo(List<Delivery> delivsInDb)
        {
        if (delivsInDb.Count > 0)
        {
            foreach (Delivery deliv in delivsInDb)
            {   
                switch(deliv.OrderStatus){
                    case 1:
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;  
                            WriteLine($"Delivery Number: ----- {deliv.Id} ----- ");
                            ResetColor();
                            WriteLine($"Order Date: --- {deliv.OrderDate} ---\n"
                            + $"Item Number: {deliv.ItemNumber}      \n"
                            + $"Quantity:  {deliv.ItemQuantity}      \n"
                            + $"Cutsomer ID: --- {deliv.CustomerId} ---");
                            Console.ForegroundColor = ConsoleColor.DarkGreen; 
                            WriteLine($"Delivery Complete"); ResetColor();
                            break;
                    case 2:
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;  
                            WriteLine($"Delivery Number: ----- {deliv.Id} ----- "); 
                            ResetColor();                         
                            WriteLine($"Order Date: --- {deliv.OrderDate} ---\n"
                            + $"Item Number: {deliv.ItemNumber}      \n"
                            + $"Quantity:  {deliv.ItemQuantity}      \n"
                            + $"Cutsomer ID: --- {deliv.CustomerId} ---");
                            Console.ForegroundColor = ConsoleColor.Green;
                            WriteLine("Delivery En Route"); ResetColor();                 
                            break;
                    case 3:
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;  
                            WriteLine($"Delivery Number: ----- {deliv.Id} ----- "); 
                            ResetColor();
                            WriteLine($"Order Date: --- {deliv.OrderDate} ---\n"
                            + $"Item Number: {deliv.ItemNumber}      \n"
                            + $"Quantity:  {deliv.ItemQuantity}      \n"
                            + $"Cutsomer ID: --- {deliv.CustomerId} ---");
                            Console.ForegroundColor = ConsoleColor.DarkCyan; 
                            Write("Delivery Scheduled"); ResetColor();               
                            break;
                    case 4:
                            Console.ForegroundColor = ConsoleColor.DarkGray;  
                            WriteLine($"Delivery Number: ----- {deliv.Id} ----- ");
                            WriteLine($"Order Date: --- {deliv.OrderDate} ---\n"
                            + $"Item Number: {deliv.ItemNumber}      \n"
                            + $"Quantity:  {deliv.ItemQuantity}      \n"
                            + $"Cutsomer ID: --- {deliv.CustomerId} ---");
                            Console.ForegroundColor = ConsoleColor.DarkYellow; 
                            WriteLine("Delivery Cancelled"); ResetColor();            
                            break;
                    default:
                            Console.ForegroundColor = ConsoleColor.DarkRed;  
                            WriteLine($"Delivery Number: ----- {deliv.Id} ----- ");
                            WriteLine($"Order Date: --- {deliv.OrderDate} ---\n"
                            + $"Item Number: {deliv.ItemNumber}      \n"
                            + $"Quantity:  {deliv.ItemQuantity}      \n"
                            + $"Cutsomer ID: --- {deliv.CustomerId} ---");
                            Console.ForegroundColor = ConsoleColor.Red; 
                            WriteLine("Cannot find Order Status");
                            break;                          
                        }
            ReadKey();
            }

        Console.ForegroundColor = ConsoleColor.DarkMagenta; 
        System.Console.WriteLine("Return to Main");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            System.Console.WriteLine("Something Went Wrong. Return to Main.");
            ReadKey();
        }
    }



//* Delivery by Status Methods
private void ViewDeliveryByStatus()
    {
        List<Delivery> delivsInDb = _delivRepo.GetAllDeliveries();
        DisplayDeliveryByStatus(delivsInDb);
    }
private void DisplayDeliveryByStatus(List<Delivery> delivsInDb)
    {   Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkGreen;
            System.Console.WriteLine("\n" 
            + "                                                                                                                \n" 
            + "                                   Warner Transit Delivery Management Application                              ");  Console.ForegroundColor = ConsoleColor.DarkYellow;  System.Console.WriteLine(
            "                                                    Current Deliveries Status                                            \n"); 
        ResetColor(); 
        Console.ForegroundColor = ConsoleColor.DarkMagenta; 
        WriteLine("____________________ Completed Deliveries _________________________");

            foreach(Delivery deliv in delivsInDb)
                {
                    int complete = 1;
                    GetDelivery(complete);
                    WriteLine($" Order Number:{deliv.Id}   Ordered On:{deliv.OrderDate} Status:"); Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    WriteLine($" Delivery Completed on {deliv.DeliveryDate}"); ResetColor();

                }
            
        int enRoute = 2;
        GetDelivery(enRoute);
        int scheduled = 3;
        GetDelivery(scheduled);
        int cancelled = 4;
        GetDelivery(cancelled);
    }
    private Delivery GetDelivery(int deliveryStatus)
    {
        return _delivRepo.GetDeliveriesByStatus(deliveryStatus);
        
    }
}

