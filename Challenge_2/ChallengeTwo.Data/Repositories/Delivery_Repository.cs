
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

public Delivery GetDeliveriesById(int id)
    {
        return _deliveryDb.SingleOrDefault(deliv => deliv.Id == id);
    }
//todo Seed Data:
private void SeedData()
    {
    var delivery1 = new Delivery( _count,DateTime.Now, "DBX12345", 1, 111111 );
    var delivery2 = new Delivery( _count,DateTime.Now, "DBX12346", 3, 111112 );
    var delivery3 = new Delivery( _count,DateTime.Now, "DBX12347", 82, 111113 );


    AddDeliveryToDb(delivery1);
    AddDeliveryToDb(delivery2);
    AddDeliveryToDb(delivery3);





    }
}


