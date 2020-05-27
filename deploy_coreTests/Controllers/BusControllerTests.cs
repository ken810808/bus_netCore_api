using Microsoft.VisualStudio.TestTools.UnitTesting;
using deploy_core.Controllers;
using System;
using System.Collections.Generic;
using System.Text;
using deploy_core.Models;
using System.Linq;

namespace deploy_core.Controllers.Tests
{
    [TestClass()]
    public class BusControllerTests
    {
        [TestMethod()]
        public void GetBusTest_傳入頁數及索引回傳車站資訊()
        {
            //arrange
            var Sut = new PTX();
            var query = "七張站";
            var limit = 10;
            var offset = 1;

            var expected = "七張站";
            //act
            var actual = Sut.Get(query,limit, offset);

            //assert
            Assert.AreEqual(actual.First().Station, expected);
        }
    }
}