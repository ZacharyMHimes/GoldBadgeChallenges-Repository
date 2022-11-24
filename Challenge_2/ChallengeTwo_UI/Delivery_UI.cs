using System.Collections.Generic;
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
            DisplayMainMenu();
        };
    } 

//* MAIN MENU
private void DisplayMainMenu()
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
            + "     3. Add a Delivery                                                             8. Get down tonight          \n" 
            + "     4. Update Delivery Status                                                     9. ------------              \n" 
            + "     5. Delete a Delivery                                                         10.Application Sign Out       \n"   // I think Delete my be superfluous - unless it's to cancel 
            + "                                                                                                                \n"   // deliveries that don't need to be tracked in the future
            + "                                                                                                                \n"
            + "                                                                                                                \n"
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
                    ListDeliveries();
                    break;
                case "2":
                    Console.Clear();
                    DeliveryStatusMenu();
                    break;
                case "3":
                    Console.Clear();
                    AddADelivery();
                    break;
                case "4":
                    Console.Clear();
                    UpdateADelivery();
                    break;
                case "5":
                    Console.Clear();
                    DeleteADelivery();
                    break;
                case "10":
                    Console.Clear();
                    isRunning = false;
                    break;   
                default:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    WriteLine("Invalid Selection, Please Enter an Integer Value");
                    ResetColor();
                    ReadKey();
                    break;
            }
    
    }
//* Deliveries in Sequence Methods
private void ListDeliveries()
        {
            ViewDeliveries();
            Console.ForegroundColor = ConsoleColor.DarkGray;  
            WriteLine("______________________________________");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            System.Console.WriteLine("End of Deliveries Record. Return to Main.");
            ReadKey(); ResetColor();

        }
private void ViewDeliveries()
    {
        List<Delivery> deliveriesRecord = _delivRepo.GetAllDeliveries();
        DisplayDeliveryInfo(deliveriesRecord);
    }

private void DisplayDeliveryInfo(List<Delivery> delivsInDb) //todo: Question For Terry 
        {                                                   //*  would you stack all of this text in-method, or break it up into
        if (delivsInDb.Count > 0)                           //*  sub-methods (would we call those helper methods?) by case?
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
                                        + $"Customer ID: --- {deliv.CustomerId} ---");
                            Console.ForegroundColor = ConsoleColor.DarkGreen; 
                                WriteLine($"Delivery Complete \n"); 
                                ResetColor();
                                break;
                    case 2:
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;  
                                WriteLine($"Delivery Number: ----- {deliv.Id} ----- "); 
                                ResetColor();                         
                                WriteLine($"Order Date: --- {deliv.OrderDate} ---\n"
                                + $"Item Number: {deliv.ItemNumber}      \n"
                                + $"Quantity:  {deliv.ItemQuantity}      \n"
                                + $"Customer ID: --- {deliv.CustomerId} ---");
                            Console.ForegroundColor = ConsoleColor.Green;
                                WriteLine("Delivery En Route \n"); 
                                ResetColor();                 
                                break;
                    case 3:
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;  
                                WriteLine($"Delivery Number: ----- {deliv.Id} ----- "); 
                                ResetColor();
                                WriteLine($"Order Date: --- {deliv.OrderDate} ---\n"
                                + $"Item Number: {deliv.ItemNumber}      \n"
                                + $"Quantity:  {deliv.ItemQuantity}      \n"
                                + $"Customer ID: --- {deliv.CustomerId} ---");

                            Console.ForegroundColor = ConsoleColor.DarkCyan; 
                                Write("Delivery Scheduled \n"); 
                                ResetColor();
                                break;
                    case 4:
                            Console.ForegroundColor = ConsoleColor.DarkGray;  
                                WriteLine($"Delivery Number: ----- {deliv.Id} ----- ");
                                WriteLine($"Order Date: --- {deliv.OrderDate} ---\n"
                                + $"Item Number: {deliv.ItemNumber}      \n"
                                + $"Quantity:  {deliv.ItemQuantity}      \n"
                                + $"Customer ID: --- {deliv.CustomerId} ---");
                            Console.ForegroundColor = ConsoleColor.DarkYellow; 
                                WriteLine("Delivery Cancelled \n"); 
                                ResetColor();            
                                break;
                    default:
                            Console.ForegroundColor = ConsoleColor.DarkRed;  
                                WriteLine($"Delivery Number: ----- {deliv.Id} ----- ");
                                WriteLine($"Order Date: --- {deliv.OrderDate} ---\n"
                                + $"Item Number: {deliv.ItemNumber}      \n"
                                + $"Quantity:  {deliv.ItemQuantity}      \n"
                                + $"Customer ID: --- {deliv.CustomerId} ---");
                            Console.ForegroundColor = ConsoleColor.Red; 
                                WriteLine("Cannot find Order Status \n");
                                ResetColor();
                                break;                          
                        }
                ReadKey();
            }

        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            System.Console.WriteLine("Something Went Wrong.");
            ReadKey();
        }
    }

//* Add a Delivery Methods
private void AddADelivery()
    {
        Console.Clear();
        try
        {
            Delivery deliv = DeliveryUserInput();
            if (_delivRepo.AddDeliveryToDb(deliv))
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan; 
                WriteLine($"Delivery Number: {deliv.Id} Item Number: {deliv.ItemNumber} has been scheduled for delivery to:");
                WriteLine($"Customer Number: {deliv.CustomerId} on {deliv.DeliveryDate}");
                ResetColor();
                ReadKey();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                WriteLine("Delivery Could Not be added. Returning to Main");
                ReadKey();
            }
        }
        catch
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            WriteLine("Delivery Could Not be added. Returning to Main");
            ReadKey();
        }
        
    }
private Delivery DeliveryUserInput()
    {   Delivery deliv = new Delivery();
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        System.Console.WriteLine("\n" 
            + "                                                                                                                \n" 
            + "                                   Warner Transit Delivery Management Application                               \n");  Console.ForegroundColor = ConsoleColor.DarkYellow;System.Console.WriteLine(
            "                                                New Delivery Entry                                                \n"
            + "                                                                                                                \n"
            + "                                                                                                                \n"
            + "                                                                                                                \n" 
            + "                                                                                                                \n" 
            + "                                                                                                                \n"); 
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        WriteLine("Enter the Delivery Item Number"); ResetColor();
        deliv.ItemNumber = ReadLine();

        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        WriteLine("Enter the Item Quantity"); ResetColor();
        deliv.ItemQuantity = int.Parse(ReadLine());

        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        WriteLine("Enter the 6 digit customer Id (000000)"); ResetColor();
        deliv.CustomerId = int.Parse(ReadLine());

        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        WriteLine("Enter the expected delivery date (month/day/year)"); ResetColor();
        deliv.DeliveryDate = DateTime.Parse(ReadLine()); 

        DateTime orderDate = DateTime.Now;
        deliv.OrderDate = orderDate;
        deliv.OrderStatus = 3;

        return deliv;
    }


//* Delivery by Status Report Menu
//                             I realized after building this byzantine methodology 
//                          I could've used LINQ to return lists of deliveries by status,
//                         which would've smoothed out the code in the the UI....
//                          but this set up is consistent and free of bugs. 
private void DeliveryStatusMenu()
        {   Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            System.Console.WriteLine("\n" 
            + "                                                                                                                \n" 
            + "                                   Warner Transit Delivery Management Application                              ");  Console.ForegroundColor = ConsoleColor.DarkYellow;System.Console.WriteLine(
            "                                                    Delivery Status Report                                        \n"); 
            ResetColor();                                                                                                              
            System.Console.WriteLine("\n"
            + "                                                                                                                \n"
            + "     1. List Completed Deliveries                                                   . -----------------         \n"
            + "     2. List Deliveries En Route                                                    . -----------------         \n" 
            + "     3. List Scheduled Deliveries                                                   . -----------------         \n" 
            + "     4. List Cancelled Deliveries                                                   . -----------------         \n" 
            + "     5. -----------------------                                                    10. Back to Main             \n" 
            + "                                                                                                                \n"); 
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            System.Console.WriteLine("\n"
            + " Please Enter a Menu Number:");
            ResetColor();

            var deliveryReportNav = ReadLine();
            switch (deliveryReportNav)
            {
                case "1":
                    Console.Clear();
                    ListCompletedDeliveries();
                    break;
                case "2":
                    Console.Clear();
                    ListEnRouteDeliveries();
                    break;
                case "3":
                    Console.Clear();
                    ListScheduledDeliveries();
                    break;
                case "4":
                    Console.Clear();
                    ListCancelledDeliveries();
                    break;
                case "10":
                    Console.Clear();
                    DisplayMainMenu();
                    break;   
                default:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    WriteLine("Invalid Selection, Please Enter an Integer Value");
                    ResetColor();
                    ReadKey();
                    DeliveryStatusMenu();
                    break;
        }
    }
//* DeliveryReportingMethods
private void ListCompletedDeliveries()
    {   Console.ForegroundColor = ConsoleColor.DarkGreen; 
        WriteLine("_____________________ Completed Deliveries _____________________"); ResetColor();
        List<Delivery> delivsInDb = _delivRepo.GetAllDeliveries();
        foreach(Delivery deliv in delivsInDb)
            {
                int complete = 1;
                if(deliv.OrderStatus == complete)
                    {   WriteLine($" Order Number: {deliv.Id}   Ordered On:{deliv.OrderDate} Status:"); 
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        WriteLine($" Delivery Completed on {deliv.DeliveryDate}"); ResetColor();
                    }
            }
        ReadKey();
        DeliveryStatusMenu();
    }
        
private void ListEnRouteDeliveries()
    {   Console.ForegroundColor = ConsoleColor.DarkGreen;
        WriteLine("_____________________ Deliveries En Route _____________________"); ResetColor();
        List<Delivery> delivsInDb = _delivRepo.GetAllDeliveries();
        foreach(Delivery deliv in delivsInDb)
            {
                int enRoute = 2;
                if(deliv.OrderStatus == enRoute)
                    {   WriteLine($" Order Number: {deliv.Id}   Ordered On:{deliv.OrderDate} Status:"); 
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        WriteLine($" Delivery EnRoute, expected Delivery date: {deliv.DeliveryDate}"); ResetColor();
                    }
            }
        ReadKey();
        DeliveryStatusMenu();
    }  

private void ListScheduledDeliveries()
    {   Console.ForegroundColor = ConsoleColor.DarkGreen; 
        WriteLine("_____________________ Orders Scheduled For Delivery _____________________"); ResetColor();
        List<Delivery> delivsInDb = _delivRepo.GetAllDeliveries();
        foreach(Delivery deliv in delivsInDb)
            {
                int scheduled = 3;
                if(deliv.OrderStatus == scheduled)
                    {   WriteLine($" Order Number: {deliv.Id}   Ordered On:{deliv.OrderDate} Status:"); 
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        WriteLine($" Delivery scheduled, expected Delivery date: {deliv.DeliveryDate}"); ResetColor();
                    }
            }
        ReadKey();
        DeliveryStatusMenu();
    }   

private void ListCancelledDeliveries()
    {   Console.ForegroundColor = ConsoleColor.DarkRed;
        WriteLine("_____________________ Cancelled Orders _____________________"); ResetColor();
        List<Delivery> delivsInDb = _delivRepo.GetAllDeliveries();
        foreach(Delivery deliv in delivsInDb)
            {
                int cancelled = 4;
                if(deliv.OrderStatus == cancelled)
                    {   WriteLine($" Order Number: {deliv.Id}   Ordered On:{deliv.OrderDate} Status:"); 
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        WriteLine($" This Delivery has been Cancelled"); ResetColor();
                    }
            }
        ReadKey();
        DeliveryStatusMenu();
    }  

//* Update Delivery Methods

private void UpdateADelivery()
    {
        Clear();
        ViewDeliveries();
        WriteLine("----------\n");
        try
        {
            WriteLine("Select delivery by Id.");
            int userInputId = int.Parse(ReadLine());
            Delivery delivInDb = GetDeliveryDetails(userInputId);
            bool isValidated = ValidateDelivery(delivInDb.Id);

            if (isValidated)
            {
                WriteLine("Do you want to Update this Delivery? y/n?");
                string userInputUpdate = ReadLine();
                if (userInputUpdate == "Y".ToLower())
                {
                    Delivery updatedDelivery = UpdateUserInput();

                    if (_delivRepo.UpdateDelivery(delivInDb.Id, updatedDelivery))
                    {
                        WriteLine($" The Delivery: {userInputId}, was updated.");
                    }
                    else
                    {
                        WriteLine($"The Delivery {userInputId}, was NOT Updated.");
                    }
                }
                else
                {
                    WriteLine("Returning to Developer Menu.");
                }
            }
        }
        catch
        {
            
        }
        ReadKey();
    }

private Delivery UpdateUserInput()
    {   Delivery deliv = new Delivery();
                                                
        WriteLine("Enter the Delivery Item Number"); ResetColor();
        deliv.ItemNumber = ReadLine();

        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        WriteLine("Enter the Item Quantity"); ResetColor();
        deliv.ItemQuantity = int.Parse(ReadLine());

        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        WriteLine("Enter the 6 digit customer Id (000000)"); ResetColor();
        deliv.CustomerId = int.Parse(ReadLine());

        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        WriteLine("Enter the expected delivery date (month/day/year)"); ResetColor();
        deliv.DeliveryDate = DateTime.Parse(ReadLine()); 

        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        WriteLine("Select a new Order Status \n"
                    +" 1. Complete   \n"
                    +" 2. En Route   \n"
                    +" 3. Scheduled  \n"
                    +" 4. Cancelled    ");
                    ResetColor();

        deliv.OrderStatus = int.Parse(ReadLine()); 

        return deliv;
    }




    private bool ValidateDelivery(int userInputId)
    {
        Delivery deliv = GetDeliveryDetails(userInputId);
        if (deliv != null)
        {
            return true;
        }
        else
        {
            WriteLine($"The Developer with the Id: {userInputId} doesn't Exist!");
            return false;
        }
    }

    private Delivery GetDeliveryDetails(int userInputId)
    {
        return _delivRepo.GetDeliveryById(userInputId);
    }




//* Delete Delivery Methods
private void DeleteADelivery()
    {
        Clear();
        ViewDeliveries();
        WriteLine("----------\n");
        try
        {   Console.ForegroundColor = ConsoleColor.DarkYellow;
            WriteLine("Select Delivery by Id."); ResetColor();
            int userInputId = int.Parse(ReadLine());
            ConfirmSelectionId(userInputId);
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            WriteLine($"Do you want to remove Delivery {userInputId} from the Record? y/n?"); ResetColor();
            string userInputDeleteDev = ReadLine();
            if (userInputDeleteDev == "Y".ToLower())
            {
                if (_delivRepo.DeleteDelivery(userInputId))
                {   Console.ForegroundColor = ConsoleColor.DarkCyan; 
                    WriteLine($" Delivery Number: {userInputId}, was Successfully Deleted.");
                    ResetColor();
                }
                else
                {   Console.ForegroundColor = ConsoleColor.DarkRed;
                    WriteLine($"Could not delete Delivery Number: {userInputId}.");
                    ResetColor();
                }
            }
        }
        catch
        {   Console.ForegroundColor = ConsoleColor.DarkRed;
            WriteLine("Sorry, could not complete request.");
            ResetColor();
        }

        ReadKey();
    }
private void ConfirmSelectionId(int userInputId)
        {
            Delivery delivSelection = _delivRepo.GetDeliveryById(userInputId);
        }
}

