
public class Delivery
{
public Delivery()
{

}
public Delivery(int id, DateTime orderDate, string itemNumber, int itemQuantity, int customerId, int orderStage) 
    {
        Id = id;    
        OrderDate = orderDate;
        ItemNumber = itemNumber;
        ItemQuantity = itemQuantity;
        CustomerId = customerId;
        OrderStage = orderStage;
    }


public int Id {get; set;}
public DateTime OrderDate {get; set;}
public DateTime DeliveryDate {get; set;}
public string ItemNumber {get; set;}
public int ItemQuantity {get; set;} 
public int CustomerId;
public int OrderStage;
public enum OrderStatus
    {
    complete, enRoute, scheduled, cancelled
    }
}
