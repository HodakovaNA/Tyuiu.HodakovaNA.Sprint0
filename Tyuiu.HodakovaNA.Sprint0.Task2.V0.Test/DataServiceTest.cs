using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.HodakovaNA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.HodakovaNA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Надежда";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет..., Надежда", res);
        }
    }
}
