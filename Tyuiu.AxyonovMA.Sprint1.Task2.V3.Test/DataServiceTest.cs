using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AxyonovMA.Sprint1.Task2.V3.Lib;

namespace Tyuiu.AxyonovMA.Sprint1.Task2.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidConvertHoursToMinutes()
        {
            DataService ds = new DataService();
            int value = 2;
            int result = ds.ConvertHoursToMinutes(value);
            int wait = 120;
            Assert.AreEqual(wait, result);
        }
    }
}