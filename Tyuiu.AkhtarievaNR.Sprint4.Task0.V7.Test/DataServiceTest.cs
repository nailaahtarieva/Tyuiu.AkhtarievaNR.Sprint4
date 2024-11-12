using Tyuiu.AkhtarievaNR.Sprint4.Task0.V7.Lib;

namespace Tyuiu.AkhtarievaNR.Sprint4.Task0.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultOddArrEl()
        {
            DataService ds = new DataService();

            int[] numsarray = { 9, 8, 7, 9, 5, 4, 3, 2, 3, 7 };
            int res = ds.GetMultOddArrEl(numsarray);
            int wait = 178605;
            Assert.AreEqual(wait, res);
        }
    }
}