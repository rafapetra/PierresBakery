using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class OrderTests
  {

    [TestMethod]
    public void BreadConstructor_CreateInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(2);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void GetBreadAmount_ReturnsAmount_Int()

    {
      int GetAmount = 2;
      Bread newBread = new Bread(GetAmount);
      int result = newBread.Amount;
      Assert.AreEqual(GetAmount, result);
    }

    [TestMethod]
    public void PastryConstructor_CreateInstanceOfPastry_Bread()
    {
      Pastry newPastry = new Pastry(2);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

        [TestMethod]
    public void GetPastryAmount_ReturnsAmount_Int()

    {
      int GetAmount = 2;
      Pastry newPastry = new Pastry(GetAmount);
      int result = newPastry.Amount;
      Assert.AreEqual(GetAmount, result);
    }
  }
}