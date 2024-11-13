using Tyuiu.AkhtarievaNR.Sprint4.Task1.V13.Lib;

namespace Tyuiu.AkhtarievaNR.Sprint4.Task1.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[] numsarray = { 8, 1, 5, 4, 2, 1, 2, 7, 6, 1 };

            int res = ds.Calculate(numsarray);
            int wait = 22;

            Assert.AreEqual(res, wait);
        }
    }
}