using Tyuiu.FrankoVA.Sprint3.Task1.V18.Lib;
namespace Tyuiu.FrankoVA.Sprint3.Task1.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 15;
            double res = ds.GetSumSeries(startValue, stopValue);
            double wait = 1;
            Assert.AreEqual(res, wait);
        }
    }
}