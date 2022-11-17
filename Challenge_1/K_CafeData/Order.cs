

public class Order
    {
        public Order()
        {
            
        }
        public Order(AddOns_A_La_Cart alacart, Drinks_A_La_Cart drink)
        {
            ALaCart = alacart;
            Drink = drink;
        }
        public int ID {get; set;}
        public AddOns_A_La_Cart ALaCart { get; set; }
        public Drinks_A_La_Cart Drink { get; set; }
    }