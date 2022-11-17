
public class EntreeItem_A_La_Cart
{
        public EntreeItem_A_La_Cart
        (
            string menuItem_Name, string menuItem_Description, double menuItem_Price
        ) 
        {   
            MenuItem_Name = menuItem_Name;
            MenuItem_Description = menuItem_Description;
            MenuItem_Price = menuItem_Price;
        }
        public EntreeItem_A_La_Cart() 
        { 
            
        }
public int MenuItem_ID {get; set;} // A la cart food number
public string MenuItem_Name {get; set;} // a la cart item number
public string MenuItem_Description {get; set;} // string description of food

public bool IsCombo {get; set;} //
public double MenuItem_Price {get; set;} // cost of menu item a la cart

}









//The Menu Items:
//A unique meal number, so customers can say 
//"I'll have the #5"
//A meal name
//A description
//A list of ingredients
//A price