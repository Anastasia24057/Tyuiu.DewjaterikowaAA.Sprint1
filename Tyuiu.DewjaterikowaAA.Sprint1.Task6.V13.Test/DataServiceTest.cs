using Newtonsoft.Json.Linq;
using Tyuiu.DewjaterikowaAA.Sprint1.Task6.V13.Lib;

namespace Tyuiu.DewjaterikowaAA.Sprint1.Task6.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            DataService ds = new DataService();
            string x = "abcde";
            var res = ds.CheckWordsAlphabet(x);
            Assert.AreEqual(true, res);


        }
    }
}
