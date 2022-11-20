using static System.Console;
public class AddressBook_UI
{        
public AddressBook_Repository _addressBook;

public AddressBook_UI()
    {
        _addressBook = new AddressBook_Repository();
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
            + "                      Lowell Organization Logistics Contacts Management Application                               ");  Console.ForegroundColor = ConsoleColor.DarkYellow;System.Console.WriteLine(
            "                                             Main Menu Options                                                    \n"); 
        ResetColor();                                                                                                              
            System.Console.WriteLine("\n"
            + "                                                                                                                \n"
            + "     1. Add A Contact                                                              6. geese a' laying           \n"
            + "     2. List All Contacts                                                          7. swans a' swimming         \n" 
            + "     3. Get Contact By Name                                                        8. maids a' milking          \n" 
            + "     4. Edit Contact                                                               9. ------------              \n" 
            + "     5. Remove a Contact                                                        10.Application Sign Out         \n"   // I think Delete my be superfluous - unless it's to cancel 
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
                    //ViewDeliveries();
                    break;
                case "2":
                    Console.Clear();
                    ListAllContacts();
                    break;
                case "3":
                    Console.Clear();
                    //AddADelivery();
                    break;
                case "4":
                    Console.Clear();
                    //ListDeliveriesToDelete();
                    break;
                case "5":
                    Console.Clear();
                    //DeleteADelivery();
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
private void ListAllContacts()
        {   Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            System.Console.WriteLine("\n" 
            + "                                                                                                                \n" 
            + "                      Lowell Organization Logistics Contacts Management Application                               ");  Console.ForegroundColor = ConsoleColor.DarkYellow;System.Console.WriteLine(
            "                                             Main Menu Options                                                    \n"); 
        ResetColor();
        Dictionary<int, Contact> _contactsInDb = _addressBook.GetAllContacts();
                foreach (KeyValuePair<int, Contact> entry in _contactsInDb)
                {
                WriteLine($"Address Book Entry: ===== {entry.Key} ====");
                WriteLine($"{entry.ToString}");
                }
            


        }
}
