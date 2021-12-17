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
  }  
}