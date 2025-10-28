using Tyuiu.KuharonakSV.Sprint1.Task2.V19.Lib;
namespace Tyuiu.KuharonakSV.Sprint1.Task2.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            var DataService = new DataService();
            int x = 10;
            var res = DataService.ConvertInchToKm(x);
            Assert.AreEqual(0.254, res);

        }
    }
}
