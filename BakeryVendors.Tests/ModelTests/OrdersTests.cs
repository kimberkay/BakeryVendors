using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using BakeryVendors.Models;
using System;

namespace BakeryVendors.Tests
{
  
  [TestClass]
    public class OrderTests
    {

      [TestMethod]
      public void OrderConstructor_CreatesInstancOfOrder_Order()
      {
        Order addOrder = new Order("weekly", "baguettes", 50, "1/1/2021");
        Assert.AreEqual(typeof(Order), addOrder.GetType());
      }
      }
    
  }
  


  



