using Microsoft.VisualStudio.TestTools.UnitTesting;
using deploy_core.Models;
using System.Linq;
using deploy_coreTests.Mocks;

namespace deploy_core.Controllers.Tests
{
    [TestClass()]
    public class BusControllerTests
    {
        [TestMethod()]
        public void GetBusTest_傳入頁數及索引回傳車站資訊()
        {
            //arrange
            var sut = new PTX(new MyRestSharpMock());
            var query = "七張站";
            var limit = 1;
            var offset = 1;

            var expected = "七張站";
            //act
            var actual = sut.Get(query, limit, offset);

            //assert
            Assert.AreEqual(actual.First().Station, expected);
        }
    }
}