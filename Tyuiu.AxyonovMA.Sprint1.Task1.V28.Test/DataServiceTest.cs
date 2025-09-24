using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AksyonovMA.Sprint1.Task1.V28.Lib;

namespace Tyuiu.AksyonovMA.Sprint1.Task1.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double result = ds.Calculate(x);
            double wait = 1.0;
            Assert.AreEqual(wait, result);
        }
    }
}