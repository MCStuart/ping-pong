using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPong;

namespace PingPong.Tests
{
  [TestClass]
  public class PingPongTest
  {
    [TestMethod]
    public void IsPingPong_DivisibleByThree_True()
    {
        PingPong testPingPong = new PingPong();
        Assert.AreEqual(true, testPingPong.IsPingPong(9));
    }

    [TestMethod]
    public void IsPingPong_DivisibleByFive_True()
    {
        PingPong testPingPong = new PingPong();
        Assert.AreEqual(true, testPingPong.IsPingPong(10));
    }

    [TestMethod]
    public void IsPingPongThreeAndFive_DivisibleByThreeAndFive_True()
    {
        PingPong testPingPong = new PingPong();
        Assert.AreEqual(true, testPingPong.IsPingPongThreeAndFive(15));
    }
  }
}
