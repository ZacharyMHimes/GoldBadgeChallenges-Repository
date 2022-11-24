using Microsoft.VisualBasic.CompilerServices;
using static System.Console;
public class Delivery_Repository
{
        
    private readonly List<Delivery> _deliveryDb = new List<Delivery>();
    private int _count;

    public Delivery_Repository()
    {
        SeedData();
    }
//todo Create:
    public bool AddDeliveryToDb(Delivery deliv)
    {
        return (deliv is null) ? false : AddToDatabase(deliv);
    }

//helper method -> Create
    private bool AddToDatabase(Delivery deliv)
    {
        AssignId(deliv);
        _deliveryDb.Add(deliv);
        return true;
    }

//helper method -> Create
    private void AssignId(Delivery deliv)
    {
        _count++;
        deliv.Id = _count;
    }
//todo Read:
public List<Delivery> GetAllDeliveries()
    {
        return _deliveryDb;
    }
public Delivery GetDeliveryById(int id)
    {  
        foreach (Delivery deliv in _deliveryDb)
        {
            if(deliv.Id == id)
            return deliv;
        }
        return null;
    }
//todo Delete:
public bool DeleteDelivery(int devId)
    {
        Delivery delivInDb = GetDeliveryById(devId);
        return _deliveryDb.Remove(delivInDb);
    }
//todo Seed Data:
private void SeedData()
    {
        DateTime orderDate1 = new DateTime(2021, 12, 31);
        DateTime orderDate2 = new DateTime(2022, 8, 7);
        DateTime orderDate3 = new DateTime(2022, 11, 9);
        DateTime orderDate4 = new DateTime(2022, 11, 9);
        DateTime orderDate5 = new DateTime(2022, 11, 12);
        DateTime orderDate6 = new DateTime(2022, 11, 13);

        DateTime deliveryDate1 = new DateTime();
        DateTime deliveryDate2 = new DateTime(2022, 7, 18);
        DateTime deliveryDate3 = new DateTime(2022, 12, 25);
        DateTime deliveryDate4 = new DateTime(2022, 11, 9);
        DateTime deliveryDate5 = new DateTime(2022, 11, 14);
        DateTime deliveryDate7 = new DateTime(2022, 11, 24); 
    
        var delivery1 = new Delivery( _count, orderDate1, deliveryDate1, "DMX12345", 1, 111111, 4 );
        var delivery2 = new Delivery( _count, orderDate2, deliveryDate2, "DMX12346", 3, 111112, 1 );
        var delivery3 = new Delivery( _count, orderDate3, deliveryDate3, "BgESmZ12347", 82, 111113, 3 );
        var delivery4 = new Delivery( _count, orderDate4, deliveryDate4, "2PAC12348", 11, 111114, 1 );
        var delivery5 = new Delivery( _count, orderDate5, DateTime.Now, "Bz2Mn12349", 1, 111113, 2 );
        var delivery6 = new Delivery( _count, orderDate6, DateTime.Now, "NAZ12350", 6, 111113, 2 );
        var delivery7 = new Delivery( _count, DateTime.Now, deliveryDate7, "DBX12347", 82, 111113, 3 );

        AddDeliveryToDb(delivery1);
        AddDeliveryToDb(delivery2);
        AddDeliveryToDb(delivery3);
        AddDeliveryToDb(delivery4);
        AddDeliveryToDb(delivery5);
        AddDeliveryToDb(delivery6);
        AddDeliveryToDb(delivery7);
    }


}



