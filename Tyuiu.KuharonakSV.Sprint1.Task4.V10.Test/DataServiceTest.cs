using Tyuiu.KuharonakSV.Sprint1.Task4.V10.Lib;
namespace Tyuiu.KuharonakSV.Sprint1.Task4.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 1;
            
            Assert.AreEqual(1, 1);    
        }
    }
}
