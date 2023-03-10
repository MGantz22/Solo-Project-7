using Microsoft.VisualStudio.TestTools.UnitTesting;
using GantzBakery.Models;

namespace GantzBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadClass_MathThirdFree_Bread()
    {
      int orderBread = 1;
      Assert.AreEqual(5, Bread.BreadTotal(orderBread));
    }
    [TestMethod]
    public void BreadClass_MathThirdFree2_Bread()
    {
      int orderBread = 2;
      Assert.AreEqual(10, Bread.BreadTotal(orderBread));
    }
    [TestMethod]
    public void BreadClass_MathThirdFree3_Bread()
    {
      int orderBread = 3;
      Assert.AreEqual(10, Bread.BreadTotal(orderBread));
    }
    [TestMethod]
    public void BreadClass_MathThirdFree4_Bread()
    {
      int orderBread = 4;
      Assert.AreEqual(15, Bread.BreadTotal(orderBread));
    }
    [TestMethod]
    public void BreadClass_MathThirdFree5_Bread()
    {
      int orderBread = 5;
      Assert.AreEqual(20, Bread.BreadTotal(orderBread));
    }
    [TestMethod]
    public void BreadClass_MathThirdFree6_Bread()
    {
      int orderBread = 6;
      Assert.AreEqual(20, Bread.BreadTotal(orderBread));
    }
    [TestMethod]
    public void BreadClass_MathThirdFree7_Bread()
    {
      int orderBread = 7;
      Assert.AreEqual(25, Bread.BreadTotal(orderBread));
    }
  }
}