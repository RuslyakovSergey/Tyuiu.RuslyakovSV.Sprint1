using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.RuslyakovSV.Sprint1.Task6.V9.Lib;

namespace Tyuiu.RuslyakovSV.Sprint1.Task6.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string res = ds.MoveLetterToStart("hello world");

            Assert.AreEqual("ohell dworl", res);
        }
    }
}
