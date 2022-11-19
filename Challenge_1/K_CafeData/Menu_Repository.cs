using System.Runtime.CompilerServices;
using static System.Console;

    public class Menu_Repository
    {
    private readonly List<EntreeItem_A_La_Cart> _EntreeDb = new List<EntreeItem_A_La_Cart>();
    private int _entreeCount;
    private readonly List<AddOns_A_La_Cart> _AddOnsDb = new List<AddOns_A_La_Cart>();
    private int _addOnsCount;
    private readonly List<Drinks_A_La_Cart> _DrinksDb = new List<Drinks_A_La_Cart>();
    private int _drinksCount;
    public Menu_Repository _menuRepo;
    public Menu_Repository()
        {
            SeedData();
        }

//C.R.U.D -> Create, Read , Update , Delete

//todo CREATE METHODs
public bool AddMenuItemEntree(EntreeItem_A_La_Cart entree)
    {
        return (entree is null) ? false : AddEntreeToDatabase(entree);
    }

public bool AddEntreeToDatabase(EntreeItem_A_La_Cart entree)
    {
        _entreeCount++;
        entree.MenuItem_ID=_entreeCount;
        _EntreeDb.Add(entree);
        return true;
    }

public bool AddMenuItemSide(AddOns_A_La_Cart item)
    {
        return (item is null) ? false : AddSideToDatabase(item);
    }

public bool AddSideToDatabase(AddOns_A_La_Cart item)
    {
        _addOnsCount++;
        item.MenuItem_ID=_addOnsCount;
        _AddOnsDb.Add(item);
        return true;
    }

public bool AddMenuItemDrinks(Drinks_A_La_Cart drink)
    {
        return (drink is null) ? false : AddDrinkDatabase(drink);
    }

public bool AddDrinkDatabase(Drinks_A_La_Cart drink)
    {
        _drinksCount++;
        drink.MenuItem_ID=_drinksCount;
        _DrinksDb.Add(drink);
        return true;
    }
    

//todo READ METHODs 
                    //* 3 Get All Methods, and 3 By Name helper methods

public List<EntreeItem_A_La_Cart> GetAllEntrees()
    {
        return _EntreeDb;
    }
public EntreeItem_A_La_Cart GetEntreeByName(string searchName)
    {
        foreach (var entree  in _EntreeDb)
        {
            if (entree.MenuItem_Name == searchName)
            {
                return entree;
            }
        }
        return null;                   
    }
public EntreeItem_A_La_Cart GetEntreeById(int searchId)
    {
        foreach (var entree  in _EntreeDb)
        {
            if (entree.MenuItem_ID == searchId)
            {
                return entree;
            }
        }
        return null;                   
    }
public List<Drinks_A_La_Cart> GetAllDrinks()
    {
        return _DrinksDb;
    }
public Drinks_A_La_Cart GetDrinkByName(string searchName)
    {
        foreach (var drink in _DrinksDb)
        {
            if (drink.MenuItem_Name == searchName)
            {
                return drink;
            }
        }
        return null;                   
    }
public List<AddOns_A_La_Cart> GetAllSides()
    {
        return _AddOnsDb;
    }
public AddOns_A_La_Cart GetSideByName(string searchName)
    {
        foreach (var side in _AddOnsDb)
        {
            if (side.MenuItem_Name == searchName)
            {
                return side;
            }
        }
        return null;                   
    }
//todo UPDATE METHODs
public bool UpdateExistingEntree(string searchName, EntreeItem_A_La_Cart updatedEntree)
    {
        EntreeItem_A_La_Cart oldEntree = GetEntreeByName(searchName);

        if (oldEntree != null)
        {   oldEntree.MenuItem_ID = updatedEntree.MenuItem_ID;
            oldEntree.MenuItem_Name = updatedEntree.MenuItem_Name;
            oldEntree.MenuItem_Description = updatedEntree.MenuItem_Description;
            oldEntree.MenuItem_Price = updatedEntree.MenuItem_Price;
            return true;
        }
        else
        {
            return false;
        }
    }

//todo DELETE METHOD:
public bool DeleteExistingEntree(EntreeItem_A_La_Cart existingEntree)
    {
        bool deleteResult = _EntreeDb.Remove(existingEntree); 
        return deleteResult;                               
    }                                                     

public bool DeleteExistingDrink(Drinks_A_La_Cart existingDrink)
    {
        bool deleteResult = _DrinksDb.Remove(existingDrink); 
        return deleteResult;                               
    }  

public bool DeleteExistingSide(AddOns_A_La_Cart existingSide)
    {
        bool deleteResult = _AddOnsDb.Remove(existingSide); 
        return deleteResult;                               
    }  

//todo STORED DATA:
private void SeedData()
    {
        var entree1 = new EntreeItem_A_La_Cart( "Komodo Burger","8 oz. Patty, grilled onions, pineapple, garlic aoli.", 5.99);
        var entree2 = new EntreeItem_A_La_Cart( "Komodo Double","Two 8 oz. Patties, grilled onions, pineapple, garlic aoli.", 7.99);
        var entree3 = new EntreeItem_A_La_Cart( "Komodo Triple","Three 8 oz. Patties, grilled onions, pineapple, garlic aoli. (Not available to employees carried on company health insurance)", 9.99);
        var entree4 = new EntreeItem_A_La_Cart( "Dragon Burger😱🥵🧨🚽","8 oz. Patty, Carolina Reaper Bacon Honey Remolade, Garden Fixings, Pepto-Bismol drizzle ", 7.99);
        var entree5 = new EntreeItem_A_La_Cart( "3 piece Lizard Fingers","3 piece all-grey meat Chicken Tenders - choice of sauce", 4.99);
        var entree6 = new EntreeItem_A_La_Cart( "5 piece Lizard Fingers","5 piece all-grey meat Chicken Tenders - choice of sauce", 6.99);
        var entree7 = new EntreeItem_A_La_Cart( "Actual Komodo Dragon","Char-grilled Komodo Dragon steak, market priced", 0.00);  //secret menu easter egg? lol
        var entree8 = new EntreeItem_A_La_Cart( "Veggie Burger","Sub Single Komodo or Dragon for Veggie Patty", 6.99);

        AddMenuItemEntree(entree1);
        AddMenuItemEntree(entree2);
        AddMenuItemEntree(entree3);
        AddMenuItemEntree(entree4);
        AddMenuItemEntree(entree5);
        AddMenuItemEntree(entree6);
        AddMenuItemEntree(entree7);
        AddMenuItemEntree(entree8);

        var drink1 = new Drinks_A_La_Cart( "Small Drink", 2.39);
        var drink2 = new Drinks_A_La_Cart( "Medium Drink", 2.79);
        var drink3 = new Drinks_A_La_Cart( "Large Drink", 2.99);
        var drink4 = new Drinks_A_La_Cart( "World's largest Lizard", 3.49);

        AddMenuItemDrinks(drink1);
        AddMenuItemDrinks(drink2);
        AddMenuItemDrinks(drink3);
        AddMenuItemDrinks(drink4);

        var fry1 = new AddOns_A_La_Cart( "Small Fry", 0.99);
        var fry2 = new AddOns_A_La_Cart( "Medium Fry", 1.49);
        var fry3 = new AddOns_A_La_Cart( "Large Fry", 1.99);
        var fry4 = new AddOns_A_La_Cart( "Apex Predator", 2.99);

        AddMenuItemSide(fry1);
        AddMenuItemSide(fry2);
        AddMenuItemSide(fry3);
        AddMenuItemSide(fry4);
    }

    }
