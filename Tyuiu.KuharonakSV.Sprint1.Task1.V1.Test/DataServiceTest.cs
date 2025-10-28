using Tyuiu.KuharonakSV.Sprint1.Task1.V1.Lib;
namespace Tyuiu.KuharonakSV.Sprint1.Task1.V1.Test

{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService ();
            double x = 9.0;
            double y = 2.0;
            double a = 1.0;
            var res =  ds.Calculate(x, y, a);
            Assert.AreEqual(54.67, res);



              
        }
    }
}
