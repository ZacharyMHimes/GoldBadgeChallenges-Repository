using System.ComponentModel.DataAnnotations;

public class Contact
{
public Contact()
    {

    }

public Contact
    (
        int key, 
        string name, 
        string address, 
        string email, 
        int phoneNumber
    )
    {
        Key = key;
        Name = name;
        Address = address;
        Email = email;
        PhoneNumber = phoneNumber;
    }

public int Key;
public string Name;  // last, first
public string Address;
public string Email;
public int PhoneNumber;




}
