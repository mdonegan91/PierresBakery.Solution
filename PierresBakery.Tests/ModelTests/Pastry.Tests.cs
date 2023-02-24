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
      Pastry newPastry = new Pastry();
      Assert.AreEqual(2, newPastry.TotalCost(1));
    }

    [TestMethod]
    public void TotalCost_ReturnCostOfThreePastries_PriceForThreePastries()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(6, newPastry.TotalCost(3));
    }
  }
}