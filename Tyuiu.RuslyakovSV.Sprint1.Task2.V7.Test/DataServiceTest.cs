using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.RuslyakovSV.Sprint1.Task2.V7.Lib;

namespace Tyuiu.RuslyakovSV.Sprint1.Task2.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 2;
            var res = ds.Sqr(x);

            Assert.AreEqual(4, res);
        }
    }
}
