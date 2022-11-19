
    public class AddOns_A_La_Cart
    {
    public AddOns_A_La_Cart
        (
            string menuItem_Name, double menuItem_Price
        ) 
        {
            this.MenuItem_Name = menuItem_Name;
            this.MenuItem_Price = menuItem_Price;
        }
    public AddOns_A_La_Cart()
    {

    }
        public int MenuItem_ID {get; set;} // A la cart food number
public string MenuItem_Name {get; set;} // a la cart item number
public double MenuItem_Price {get; set;} // cost of menu item a la cart
    }