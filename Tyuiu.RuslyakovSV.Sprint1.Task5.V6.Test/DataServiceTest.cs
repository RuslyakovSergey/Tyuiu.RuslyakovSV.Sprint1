using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.RuslyakovSV.Sprint1.Task5.V6.Lib;

namespace Tyuiu.RuslyakovSV.Sprint1.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int k = 15;
            var res = ds.Calculate(k);

            Assert.AreEqual(1, res);
        }
    }
}
