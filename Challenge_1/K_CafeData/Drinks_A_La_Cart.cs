
    public class Drinks_A_La_Cart
    {
    public Drinks_A_La_Cart
        (
            int menuItem_ID, string menuItem_Name, double menuItem_Price
        ) 
        {
            this.MenuItem_ID = menuItem_ID;
            this.MenuItem_Name = menuItem_Name;
            this.MenuItem_Price = menuItem_Price;
        }

        public int MenuItem_ID {get; set;} // A la cart food number
public string MenuItem_Name {get; set;} // a la cart item number
public double MenuItem_Price {get; set;} // cost of menu item a la cart
    }
