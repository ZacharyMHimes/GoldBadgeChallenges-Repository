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
                    DeliveryStatusMenu();
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
private void ViewDeliveriesInSequence()
    {
        List<Delivery> delivsInDb = _delivRepo.GetAllDeliveries();
        DisplayDeliveryInfo(delivsInDb);
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
                                        + $"Cutsomer ID: --- {deliv.CustomerId} ---");
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
                                + $"Cutsomer ID: --- {deliv.CustomerId} ---");
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
                                + $"Cutsomer ID: --- {deliv.CustomerId} ---");

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
                                + $"Cutsomer ID: --- {deliv.CustomerId} ---");
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
                                + $"Cutsomer ID: --- {deliv.CustomerId} ---");
                            Console.ForegroundColor = ConsoleColor.Red; 
                                WriteLine("Cannot find Order Status \n");
                                ResetColor();
                                break;                          
                        }
            Console.ForegroundColor = ConsoleColor.DarkGray;  
            WriteLine("______________________________________");
            ResetColor();
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
                    break;
        }
    }
//
// private void ViewDeliveryByStatus()
//     {
//         List<Delivery> delivsInDb = _delivRepo.GetAllDeliveries();
//         DisplayDeliveryByStatus(delivsInDb);
//     }
// private void DisplayDeliveryByStatus(List<Delivery> delivsInDb)
//     {   Console.Clear();
//         Console.ForegroundColor = ConsoleColor.DarkGreen;
//             System.Console.WriteLine("\n" 
//             + "                                                                                                                \n" 
//             + "                                   Warner Transit Delivery Management Application                              ");  Console.ForegroundColor = ConsoleColor.DarkYellow;  System.Console.WriteLine(
//             "                                                    Current Deliveries Status                                            \n"); 
//         ResetColor(); 
//         Console.ForegroundColor = ConsoleColor.DarkMagenta; 
//         WriteLine("____________________ Completed Deliveries _________________________");

//             foreach(Delivery deliv in delivsInDb)
//                 {
//                     GetDelivery(deliv.OrderStatus);
//                     for (deliv.OrderStatus = 1){
//                             WriteLine($" Order Number:{deliv.Id}   Ordered On:{deliv.OrderDate} Status:"); 
//                             Console.ForegroundColor = ConsoleColor.DarkMagenta;
//                             WriteLine($" Delivery Completed on {deliv.DeliveryDate}"); ResetColor();}
                            
//                     for (deliv.OrderStatus = 2)
//                         {
//                             WriteLine($" Order Number:{deliv.Id}   Ordered On:{deliv.OrderDate} Status:"); 
//                             Console.ForegroundColor = ConsoleColor.DarkMagenta;
//                             WriteLine($" Out For Delivery, Expected {deliv.DeliveryDate}"); ResetColor();
//                         };
//                     for (deliv.OrderStatus = 3)
//                         {
//                             WriteLine($" Order Number:{deliv.Id}   Ordered On:{deliv.OrderDate} Status:"); 
//                             Console.ForegroundColor = ConsoleColor.Magenta;
//                             WriteLine($" Delivery Scheduled, Expected {deliv.DeliveryDate}"); ResetColor();
//                         };
//                     for (deliv.OrderStatus = 4)
//                         {
//                             WriteLine($" Order Number:{deliv.Id}   Ordered On:{deliv.OrderDate} Status:"); 
//                             Console.ForegroundColor = ConsoleColor.DarkRed;
//                             WriteLine($" Delivery Cancelled"); ResetColor();
//                         };
//                 }
//     }
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

}

