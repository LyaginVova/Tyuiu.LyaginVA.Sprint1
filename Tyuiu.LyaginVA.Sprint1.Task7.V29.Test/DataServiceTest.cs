using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LyaginVA.Sprint1.Task7.V29.Lib;

namespace Tyuiu.LyaginVA.Sprint1.Task7.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 120;
            double y = 180;
            double wait = 120;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);

        }
    }
}
