using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryVendors.Models;
using System.Collections.Generic;
using System;

namespace BakeryVendors.Tests
{
  [TestClass]
  public class VendorTests
  {

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test", "test");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetNameAndDescription_ReturnsNameandDescription_NameDescription()
    {
      string name = "Todd's Coffee";
      string vendorDescription = "coffee shop";
      Vendor newVendor = new Vendor(name, vendorDescription);

      string resultName = newVendor.Name;
      string resultDesc = newVendor.VendorDescription;

      Assert.AreEqual(name, resultName);
      Assert.AreEqual(vendorDescription, resultDesc);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      string name = "Test Vendor";
      string vendorDescription = "Test Description";
      Vendor newVendor = new Vendor(name, vendorDescription);
    }


      // [TestMethod]
      // public void GetAll_ReturnsAllVendorObjects_VendorsList()
      // {
      //   string name = "Todd's Coffee";
      //   string vendorDescription = "coffee shop";

      //   string name2 = "Martha's Corner";
      //   string vendorDescription2 = "specialty market";

      //   Vendor newVendor = new Vendor(name, vendorDescription);
      //   Vendor newVendor2 = new Vendor(name2, vendorDescription2);
      //   List<Vendor> newList = new List<Vendor> { newVendor, newVendor2 };

      //   List<Vendor> result = Vendor.GetAll();

      //   CollectionAssert.AreEqual(newList, result);


        
      // }

    }
  }  
