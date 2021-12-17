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
  }
}