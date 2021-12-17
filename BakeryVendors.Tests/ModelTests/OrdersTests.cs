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

      //public Order(string orderTitle, string description, int price, string date)

      [TestMethod]
      public void GetOrder_ReturnsInstanceOfAnOrder_Order()
      {
        string orderTitle = "weekly";
        string description = "baguettes";
        int price = 50;
        string date = "1/1/2021";

        Order newOrder = new Order(orderTitle, description, price, date);
        string resultTitle = newOrder.OrderTitle;
        string resultDescription = newOrder.Description;
        int resultPrice = newOrder.Price;
        string resultDate = newOrder.Date;

        Assert.AreEqual(orderTitle, resultTitle);
        Assert.AreEqual(description, resultDescription);
        Assert.AreEqual(price, resultPrice);
        Assert.AreEqual(date, resultDate);
      }
    }
    
  }
  


  



