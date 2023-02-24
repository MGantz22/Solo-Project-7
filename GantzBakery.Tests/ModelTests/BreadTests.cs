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
  
  }
}