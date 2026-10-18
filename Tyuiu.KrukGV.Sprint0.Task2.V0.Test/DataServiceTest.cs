using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KrukGV.Sprint0.Task2.V0.Lib;

namespace Tyuiu.KrukGV.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Глеб";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет..., Глеб", res);
        }
    }
}
