using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AxyonovMA.Sprint1.Task7.V12.Lib;

namespace Tyuiu.AxyonovMA.Sprint1.Task7.V12.Test
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
            double wait = 27.0;
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidCalculate2()
        {
            DataService ds = new DataService();
            double x = 3.0;
            double y = 2.0;
            double result = ds.Calculate(x, y);
            double wait = 154.125;
            Assert.AreEqual(wait, result, 0.001);
        }

        [TestMethod]
        public void ValidCalculate3()
        {
            DataService ds = new DataService();
            double x = 1.5;
            double y = 0.5;
            double result = ds.Calculate(x, y);
            double wait = 7.593 + 4.5; // Проверка расчета
            Assert.AreEqual(wait, result, 0.001);
        }
    }
}