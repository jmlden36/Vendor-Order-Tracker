using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("Vendor1", "Order description", 12, "2005-06-07");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    
    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Jim Saucejar";
      Order newOrder = new Order(name, "Order description", 12, "2005-06-07");
      string result = newOrder.Name;
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void SetName_SetName_String()
    {
      string name = "Jim Saucejar";
      Order newOrder = new Order(name, "Order description", 12, "2005-06-07");
      
      string updatedName = "Tom Burntag";
      newOrder.Name = updatedName;
      string result = newOrder.Name;
      Assert.AreEqual(updatedName, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string description = "for a wedding";
      Order newOrder = new Order("Vendor1", description, 12, "2005-06-07");
      string result = newOrder.Description;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      string description = "for a wedding";
      Order newOrder = new Order("Vendor1", description, 12, "2005-06-07");
      
      string updatedDescription = "nut allergy";
      newOrder.Description = updatedDescription;
      string result = newOrder.Description;
      Assert.AreEqual(updatedDescription, result);
    }

    [TestMethod]
    public void GetPrice_ReturnsPrice_Double()
    {
      double price = 5.79;
      Order newOrder = new Order("Vendor1", "Order description", price, "2005-06-07");
      double result = newOrder.Price;
      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void SetPrice_SetPrice_Double()
    {
      double price = 5.79;
      Order newOrder = new Order("Vendor1", "Order description", price, "2005-06-07");
      
      double updatedPrice = 10;
      newOrder.Price = updatedPrice;
      double result = newOrder.Price;
      Assert.AreEqual(updatedPrice, result);
    }

    [TestMethod]
    public void GetDate_ReturnsDate_String()
    {
      string date = "2020-10-14";
      Order newOrder = new Order("Vendor1", "Order description", 12, date);
      string result = newOrder.Date;
      Assert.AreEqual(date, result);
    }

    [TestMethod]
    public void SetDate_SetDate_String()
    {
      string date = "2020-10-14";
      Order newOrder = new Order("Vendor1", "Order description", 12, date);
      
      string updatedDate = "2022-11-09";
      newOrder.Date = updatedDate;
      string result = newOrder.Date;
      Assert.AreEqual(updatedDate, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrdersList()
    {
      List<Order> newList = new List<Order> {};
      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }
  }
}