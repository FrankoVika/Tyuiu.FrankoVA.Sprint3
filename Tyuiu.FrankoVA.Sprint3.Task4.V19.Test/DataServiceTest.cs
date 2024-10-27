using Tyuiu.FrankoVA.Sprint3.Task4.V19.Lib;
namespace Tyuiu.FrankoVA.Sprint3.Task4.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double res = ds.Calculate(startValue, stopValue);
            double wait = 8.175;
            Assert.AreEqual(res, wait);
        }
    }
}