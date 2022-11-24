using System;
using System.Collections.Generic;
using Xunit;

public class DeliveryTest
{
    [Fact]
    public void SetItemNumber_ShouldReturnCorrectString()
    {
        //AAA 

        //Arrange
        Delivery order = new Delivery();

        //lets assign a value 
        order.ItemNumber = "dxq1234";

        //Act
        string expected = "dxq1234";

        string actual = order.ItemNumber;

        //Assert
        Assert.Equal(expected,actual);

    }
    [Fact] //todo CREATE unit test
    public void CreateDelivery_AddToDatabase_ShouldReturnTrue()
    {
        //Arrange
        Delivery delivery = new Delivery(10, DateTime.Now, DateTime.MaxValue, "DMX12345", 1, 111111, 4 );
        Delivery_Repository _repo = new Delivery_Repository();

        //Act
        bool expected = true;
        bool actual = _repo.AddDeliveryToDb(delivery);

        //Assert
        Assert.Equal(expected, actual);
    }

    [Fact] //todo READ unit tests
    public void GetAllDeliveries_ShouldReturnNotVoid()
    {
        //Arrange
        Delivery_Repository _repo = new Delivery_Repository();

        //Act
        bool expected = true;
        bool actual = _repo.GetAllDeliveries() != null;

        //Assert
        Assert.Equal(expected, actual);
    } 
    [Fact]
    public void GetDeliveryById_ShouldReturnNotVoid()
    {
        //Arrange
        Delivery_Repository _repo = new Delivery_Repository();

        //Act
        bool expected = true;
        bool actual = _repo.GetDeliveryById(1) != null;

        //Assert
        Assert.Equal(expected, actual);
    }

    [Fact] //todo DELETE unit test
        public void DeleteDeliveryById_ShouldReturnTrue()
    {
        //Arrange
        Delivery_Repository _repo = new Delivery_Repository();

        //Act
        bool expected = true;
        bool actual = _repo.DeleteDelivery(1);

        //Assert
        Assert.Equal(expected, actual);
    } 
}