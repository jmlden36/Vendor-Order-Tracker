using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("Vendor1", "Vendor1 description");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Vendor1";
      Vendor newVendor = new Vendor(name, "Vendor1 description");
      string result = newVendor.Name;
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string description = "Vendor1 description";
      Vendor newVendor = new Vendor("Vendor1", description);
      string result = newVendor.Description;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      string name = "Vendor1";
      string description = "Vendor1 description";
      Vendor newVendor = new Vendor(name, description);

      int result = newVendor.Id;

      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllCategoryObjects_CategoryList()
    {

      string name01 = "Vendor1";
      string description01 = "Vendor1 description";
      string name02 = "Vendor2";
      string description02 = "Vendor2 description";
      Vendor newVendor01 = new Vendor(name01, description01);
      Vendor newVendor02 = new Vendor(name02, description02);
      List<Vendor> newList = new List<Vendor> { newVendor01, newVendor02 };

      List<Vendor> result = Vendor.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string name01 = "Vendor1";
      string description01 = "Vendor1 description";
      string name02 = "Vendor2";
      string description02 = "Vendor2 description";
      Vendor newVendor01 = new Vendor(name01, description01);
      Vendor newVendor02 = new Vendor(name02, description02);

      Vendor result = Vendor.Find(2);

      Assert.AreEqual(newVendor02, result);
    }
  }
}