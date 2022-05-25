using Microsoft.VisualStudio.TestTools.UnitTesting;
using Temperatura_Dia1;

namespace Temperatura_Dia1.Tests
{
    [TestClass]
    public class TemperatureTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var a = new Temperature(30, (TemperatureScale)0);
            var b = new Temperature(50, (TemperatureScale)1);
            float result = a.Add(b);
            Assert.AreEqual(result, -193, 14999389648438);
        }
        [TestMethod]
        public void TestMethod2()
        {
            var a = new Temperature(30, (TemperatureScale)0);
            var b = new Temperature(50, (TemperatureScale)2);
            float result = a.Add(b);
            Assert.AreEqual(result, 40); //Should be 40
        }
        //[TestMethod]
        //public void TestMethod3()
        //{
        //}
        //[TestMethod]
        //public void TestMethod4()
        //{
        //}
    }
}
