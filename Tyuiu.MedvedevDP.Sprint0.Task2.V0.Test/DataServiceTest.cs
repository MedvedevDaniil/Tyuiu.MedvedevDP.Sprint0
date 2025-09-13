using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MedvedevDP.Sprint0.Task2.V0.Lib;

namespace Tyuiu.MedvedevDP.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Daniil";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Privet, Daniil", res);
        }
    }
}
