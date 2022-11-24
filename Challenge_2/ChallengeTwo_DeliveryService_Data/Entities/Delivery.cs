using static System.Console;
public class Delivery
{
public Delivery()
{

}
public Delivery
    (
        int id, 
        DateTime orderDate, 
        DateTime deliveryDate, 
        string itemNumber, 
        int itemQuantity, 
        int customerId, 
        int orderStatus
    ) 
    {
        Id = id;    
        OrderDate = orderDate;
        DeliveryDate = deliveryDate;
        ItemNumber = itemNumber;
        ItemQuantity = itemQuantity;
        CustomerId = customerId;
        OrderStatus = orderStatus;
    }


public int Id {get; set;}
public DateTime OrderDate {get; set;}
public DateTime DeliveryDate {get; set;}
public string ItemNumber {get; set;}
public int ItemQuantity {get; set;} 
public int CustomerId {get; set;}
public int OrderStatus {get; set;}
}
