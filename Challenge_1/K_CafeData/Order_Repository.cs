


public class Order_Repository
    {
    private Order_Repository orderRepo;    
    private Menu_Repository _MenuRepo;

    private readonly List<Order> _orderDb = new List<Order>();
    private int _count;

    public Order_Repository(Menu_Repository _menuRepo)
    {
        _MenuRepo = _menuRepo;
        SeedData();
    }

//C.R.U.D -> Create, Read , Update , Delete

//todo CREATE METHODs
public bool AddOrder(Order order)
    {
        return (order is null) ? false : AddOrderToDatabase(order);
    }

public bool AddOrderToDatabase(Order order)
    {
        _count++;
        order.OrderId=_count;
        _orderDb.Add(order);
        return true;
    }

//todo READ METHODs

public List<Order> GetAllOrders()
    {
        return _orderDb;
    }


private void SeedData()
    {
        var komodoBurger =  _MenuRepo.GetEntreeByName("Komodo Burger");

        var komodoDouble = _MenuRepo.GetEntreeByName("Komodo Double");

        var komodoTriple = _MenuRepo.GetEntreeByName("Komodo Triple");     
        
        var dragonBurger = _MenuRepo.GetEntreeByName("Dragon Burger😱🥵🧨🚽");

        var threePieceLizard = _MenuRepo.GetEntreeByName("3 piece Lizard Fingers");

        var fivePieceLizard = _MenuRepo.GetEntreeByName("5 piece Lizard Fingers");

        var actualDragon = _MenuRepo.GetEntreeByName("Actual Komodo Dragon");

        var veggieBurger = _MenuRepo.GetEntreeByName("Veggie Burger");

        var drink1 = new Drinks_A_La_Cart("Small Drink", 2.39);
        var drink2 = new Drinks_A_La_Cart("Medium Drink", 2.79);
        var drink3 = new Drinks_A_La_Cart("Large Drink", 2.99);
        var drink4 = new Drinks_A_La_Cart("World's largest Lizard", 3.49);

        var fry1 = new AddOns_A_La_Cart("Small Fry", 0.99);
        var fry2 = new AddOns_A_La_Cart("Medium Fry", 1.49);
        var fry3 = new AddOns_A_La_Cart("Large Fry", 1.99);
        var fry4 = new AddOns_A_La_Cart("Apex Predator", 2.99);

        var order1 = new Order
                            (   _count,
                                "CEO",
                                new List<EntreeItem_A_La_Cart>{komodoBurger}, 
                                new List<AddOns_A_La_Cart>{fry1}, 
                                new List<Drinks_A_La_Cart>{drink1}, 
                                "Dr. Pibb for drink. Please include extra Napkins - deliver to conference room 6 @ 1:00p.m.");
        var order2 = new Order
                            (   _count,
                                "CFO",
                                new List<EntreeItem_A_La_Cart>{komodoBurger}, 
                                new List<AddOns_A_La_Cart>{fry3}, 
                                new List<Drinks_A_La_Cart>{drink3}, 
                                "Diet Coke w/ 3 stevia packets. Please include extra Napkins - deliver to conference room 6 @ 1:00p.m.");
        var order3 = new Order
                            (   _count,
                                "CTO",
                                new List<EntreeItem_A_La_Cart>{dragonBurger}, 
                                new List<AddOns_A_La_Cart>{fry1}, 
                                new List<Drinks_A_La_Cart>{drink4}, 
                                "Do you guys have Milk on fountain? Please include extra Napkins - deliver to conference room 6 @ 1:00p.m.");
        
        AddOrder(order1);
        AddOrder(order2); 
        AddOrder(order3);
        
    }

}