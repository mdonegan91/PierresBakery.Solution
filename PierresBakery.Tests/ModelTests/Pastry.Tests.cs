using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
  
    [TestMethod]
    public void TotalCost_ReturnCostOfOnePastry_PriceForOnePastry()
    {
      // Pastry newPastry = new Pastry();
      Assert.AreEqual(2, Pastry.TotalCost(1));
    }
  }
}