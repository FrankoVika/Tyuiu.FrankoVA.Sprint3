using Tyuiu.FrankoVA.Sprint3.Task6.V7.Lib;
namespace Tyuiu.FrankoVA.Sprint3.Task6.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            
            int startValue = 17;
            int stopValue = 26;
            
            double res = ds.GetSumTheDivisors(startValue, stopValue);

            double wait =344;
            Assert.AreEqual(wait, res);
        }
    }
}