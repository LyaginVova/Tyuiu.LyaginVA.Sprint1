using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LyaginVA.Sprint1.Task6.V3.Lib;

namespace Tyuiu.LyaginVA.Sprint1.Task6.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string str = "привет, дом, книга";
            DataService ds = new DataService();
            string res = ds.LastLetterWord(str);
            string wait = "тма";
            Assert.AreEqual(wait, res);

        }
    }
}
