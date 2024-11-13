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

            int[] numsarray = { 5, 1, 5, 4, 2, 1, 2, 3, 6, 1 };

            int res = ds.Calculate(numsarray);
            int wait = 14;

            Assert.AreEqual(res, wait);
        }
    }
}