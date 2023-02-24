using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System.Collections.Generic;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
  
    [TestMethod]
    public void TotalCost_ReturnCostOfOneLoafOfBread_PriceForOneLoaf()
    { 
      Assert.AreEqual(5, Bread.TotalCost(1));
    }

    [TestMethod]
    public void TotalCost_ReturnCostOfTwoLoavesOfBread_PriceForTwoLoaves()
    {
      Assert.AreEqual(10, Bread.TotalCost(2));
    }
  }
}