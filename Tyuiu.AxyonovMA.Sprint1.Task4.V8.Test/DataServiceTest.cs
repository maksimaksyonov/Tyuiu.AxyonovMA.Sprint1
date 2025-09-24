using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AxyonovMA.Sprint1.Task4.V8.Lib;

namespace Tyuiu.AxyonovMA.Sprint1.Task4.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double x = 2.0;
            double y = 1.0;
            double result = ds.Calculate(x, y);
            double wait = 1.155;
            Assert.AreEqual(wait, result);
        }
    }
}