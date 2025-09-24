using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AxyonovMA.Sprint1.Task3.V1.Lib;

namespace Tyuiu.AxyonovMA.Sprint1.Task3.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCylinderVolume()
        {
            DataService ds = new DataService();
            double r = 2.0;
            double h = 5.0;
            double result = ds.CylinderVolume(r, h);
            double wait = 62.832;
            Assert.AreEqual(wait, result);
        }
    }
}