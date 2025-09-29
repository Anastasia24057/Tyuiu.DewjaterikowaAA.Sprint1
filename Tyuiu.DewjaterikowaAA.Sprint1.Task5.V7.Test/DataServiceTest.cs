using Tyuiu.DewjaterikowaAA.Sprint1.Task5.V7.Lib;

namespace Tyuiu.DewjaterikowaAA.Sprint1.Task5.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double f = 90;
            DataService ds = new DataService();
            double res = ds.AngleToHoursMinutes(f);

            int result = Convert.ToInt32(res);

            int wait = 3;
            Assert.AreEqual(wait, result);
        }
    }
}
