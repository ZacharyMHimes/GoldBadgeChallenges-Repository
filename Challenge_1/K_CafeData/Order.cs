

public class Order
    {

        public Order(int orderId,string orderName, List<EntreeItem_A_La_Cart> entree, List<AddOns_A_La_Cart> alacart, List<Drinks_A_La_Cart> drink, string notes)
        {
            OrderId = orderId;
            OrderName = orderName;
            Entree = entree;
            ALaCart = alacart;
            Drink = drink;
            Order_Notes = notes;
        }       
        
        public Order()
        {
            
        }
         //todo: Class that meets assignment requirements
        public int OrderId {get; set;}                        //* Meal ID
        public string OrderName {get; set;}                   //* Name for the order
        public List<EntreeItem_A_La_Cart> Entree {get; set; } //* List of ingredients part 1
        public List<AddOns_A_La_Cart> ALaCart { get; set; }   //* List of ingredients part 2
        public List<Drinks_A_La_Cart> Drink { get; set; }     //* List of ingredients part 3
        public string Order_Notes {get; set; }                //* A Description
        public double Order_Total {get; set;}                 //* A Price

    }