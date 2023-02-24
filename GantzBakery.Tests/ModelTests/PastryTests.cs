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
    [TestMethod]
    public void PastryClass_MathFourthFree3_Pastry()
    {
      int orderPastry = 3;
      Assert.AreEqual(6, Pastry.PastryTotal(orderPastry));
    }
    [TestMethod]
    public void PastryClass_MathFourthFree4_Pastry()
    {
      int orderPastry = 5;
      Assert.AreEqual(8, Pastry.PastryTotal(orderPastry));
    }
    [TestMethod]
    public void PastryClass_MathFourthFree5_Pastry()
    {
      int orderPastry = 6;
      Assert.AreEqual(10, Pastry.PastryTotal(orderPastry));
    }
    [TestMethod]
    public void PastryClass_MathFourthFree6_Pastry()
    {
      int orderPastry = 7;
      Assert.AreEqual(12, Pastry.PastryTotal(orderPastry));
    }
    [TestMethod]
    public void PastryClass_MathFourthFree7_Pastry()
    {
      int orderPastry = 8;
      Assert.AreEqual(12, Pastry.PastryTotal(orderPastry));
    }
    [TestMethod]
    public void PastryClass_MathFourthFree8_Pastry()
    {
      int orderPastry = 9;
      Assert.AreEqual(14, Pastry.PastryTotal(orderPastry));
    }

  }
}