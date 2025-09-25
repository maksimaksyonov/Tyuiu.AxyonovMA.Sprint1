using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AxyonovMA.Sprint1.Task5.V7.Lib;

namespace Tyuiu.AxyonovMA.Sprint1.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidAngleToHours()
        {
            DataService ds = new DataService();
            double f = 90.0;
            int result = ds.AngleToHours(f);
            int wait = 3;
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidAngleToHours2()
        {
            DataService ds = new DataService();
            double f = 180.0;
            int result = ds.AngleToHours(f);
            int wait = 6;
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidAngleToHours3()
        {
            DataService ds = new DataService();
            double f = 45.5;
            int result = ds.AngleToHours(f);
            int wait = 1;
            Assert.AreEqual(wait, result);
        }
    }
}