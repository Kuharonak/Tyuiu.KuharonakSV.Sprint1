using Tyuiu.KuharonakSV.Sprint1.Task7.V20.Lib;
namespace Tyuiu.KuharonakSV.Sprint1.Task7.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 2;
            double z = 4.917;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(z, res);
        }
    }
}
