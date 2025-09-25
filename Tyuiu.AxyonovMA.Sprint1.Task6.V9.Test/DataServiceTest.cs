using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AxyonovMA.Sprint1.Task6.V9.Lib;

namespace Tyuiu.AxyonovMA.Sprint1.Task6.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidMoveLastLetterToStart()
        {
            DataService ds = new DataService();
            string value = "привет мир";
            string result = ds.MoveLastLetterToStart(value);
            string wait = "тприве рим";
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidMoveLastLetterToStart_SingleWord()
        {
            DataService ds = new DataService();
            string value = "программирование";
            string result = ds.MoveLastLetterToStart(value);
            string wait = "епрограммировани";
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidMoveLastLetterToStart_ShortWords()
        {
            DataService ds = new DataService();
            string value = "я и ты";
            string result = ds.MoveLastLetterToStart(value);
            string wait = "я и ыт";
            Assert.AreEqual(wait, result);
        }
    }
}