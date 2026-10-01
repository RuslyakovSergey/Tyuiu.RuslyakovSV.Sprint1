using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.RuslyakovSV.Sprint1.Task4.V9.Lib;

namespace Tyuiu.RuslyakovSV.Sprint1.Task4.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 1;
            var res = ds.Calculate(x, y);

            Assert.AreEqual(1.183, res);
        }
    }
}
