using Microsoft.VisualStudio.TestTools.UnitTesting;
using GantzBakery.Models;


namespace GantzBakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryClass_MathFourthFree_Pastry()
    {
      int orderPastry = 1;
      Assert.AreEqual(2, Pastry.PastryTotal(orderPastry));
    }
    [TestMethod]
    public void PastryClass_MathFourthFree2_Pastry()
    {
      int orderPastry = 2;
      Assert.AreEqual(4, Pastry.PastryTotal(orderPastry));
    }

  }
}