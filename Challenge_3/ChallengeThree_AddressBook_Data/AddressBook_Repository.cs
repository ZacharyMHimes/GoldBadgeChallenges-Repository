
using System.Net.NetworkInformation;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Emit;
using System.Collections.Generic;
public class AddressBook_Repository
{
    private readonly Dictionary<int, Contact> _addressBook = new Dictionary<int, Contact>{};
    private int _count = 5;

    public AddressBook_Repository()
    {
        SeedData();
    }

//todo: Create

//private void AddEntry()

//todo: Read
public Dictionary<int, Contact> GetAllContacts()
    {
        return _addressBook;
    }

//todo: Update

//todo: Delete

private void SeedData()
    {

        var entry1 = new Contact (1, "Bach, Johanne Sebastian", "St. Thomas Church, Leipzig DE", "baroquesnotdead@gmail.com", 317-555-5255);
        var entry2 = new Contact (2, "Beethoven, Ludvig van", "Bonngasse 20, Bonn DE", "rolloverme@gmail.com", 5553-4442);
        var entry3 = new Contact (3, "Schoenburg, Arnold", "116 n Rockingham ave, Los Angeles CA", "2435167119108@ucla.com", 765-555-5255);
        var entry4 = new Contact (4, "Boulange, Lilith","Conservetoire de Paris, Paris FR", "nadiassister@gmail.com", 317-555-5255);
        var entry5 = new Contact (5, "Jones, Quincy", "1234 Beat It Way, Los Angeles CA"," ", 675-555-5255);

        _addressBook.Add(1,entry1);
        _addressBook.Add(2,entry2);
        _addressBook.Add(3,entry3);
        _addressBook.Add(4,entry4);
        _addressBook.Add(5,entry5);


    }



}
