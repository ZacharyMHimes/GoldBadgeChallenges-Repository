
public class Delivery
{
public Delivery()
{

}
public Delivery(int id, DateTime orderDate, string itemNumber, int itemQuantity, int customerId)
{
    Id = id;
    OrderDate = orderDate;
    ItemNumber = itemNumber;
    ItemQuantity = itemQuantity;
    CustomerId = customerId;
}


public int Id {get; set;}
public DateTime OrderDate {get; set;}
public DateTime DeliveryDate {get; set;}
public enum OrderStatus{Complete, EnRoute, Scheduled, Cancelled };
public string ItemNumber {get; set;}
public int ItemQuantity {get; set;} 
public int CustomerId;
}