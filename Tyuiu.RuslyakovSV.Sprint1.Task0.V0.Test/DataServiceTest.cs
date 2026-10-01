using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.RuslyakovSV.Sprint1.Task0.V0.Lib;

namespace Tyuiu.RuslyakovSV.Sprint1.Task0.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(2, res);
        }
    }
}
