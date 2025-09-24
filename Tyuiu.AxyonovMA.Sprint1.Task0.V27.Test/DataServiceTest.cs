using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AksyonovMA.Sprint1.Task0.V27.Lib;

namespace Tyuiu.AksyonovMA.Sprint1.Task0.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            var result = ds.Calculate();
            Assert.AreEqual(22, result);
        }
    }
}