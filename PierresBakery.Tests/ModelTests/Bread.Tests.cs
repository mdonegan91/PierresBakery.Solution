using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
  
    [TestMethod]
    public void TotalCost_ReturnCostOfOneLoafOfBread_PriceForOneLoaf()
    { 
      Bread newBread = new Bread();
      Assert.AreEqual(5, newBread.TotalCost(1));
    }

    [TestMethod]
    public void TotalCost_ReturnCostOfTwoLoavesOfBread_PriceForTwoLoaves()
    {
      Bread newBread = new Bread();
      Assert.AreEqual(10, newBread.TotalCost(2));
    }
  }
}



//     [TestMethod]
//     public void TotalCost_ShouldReturnTotalCostOfOneLoafOfBread_PriceForOneLoaf()
//     {
//       Bread testBread = new Bread();
//       Assert.AreEqual(5, testBread.TotalCost(1));
//     }

//     public void TotalCost_ShouldReturnTotalCostOfTwoLoafsOfBread_PriceForTwoLoafs()
//     {
//       Bread testBread = new Bread();
//       Assert.AreEqual(5, testBread.TotalCost(2));
//     }
//   }
// }