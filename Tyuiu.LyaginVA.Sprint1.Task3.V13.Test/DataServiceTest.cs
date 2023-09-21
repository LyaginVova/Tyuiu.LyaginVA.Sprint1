﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LyaginVA.Sprint1.Task3.V13.Lib;

namespace Tyuiu.LyaginVA.Sprint1.Task3.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double number = 2;

            double wait = 8;
            var res = ds.MultiplyOfDigits(number);
            Assert.AreEqual(wait, res);
        }
    }
}
