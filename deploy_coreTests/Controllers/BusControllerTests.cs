using Microsoft.VisualStudio.TestTools.UnitTesting;
using deploy_core.Models;
using System.Linq;
using NSubstitute;
using Utities.NetTools;
using System.Text;

namespace deploy_core.Controllers.Tests
{
    [TestClass()]
    public class BusControllerTests
    {
        [TestMethod()]
        public void GetBusTest_傳入頁數及索引回傳車站資訊()
        {
            //arrange
            //透過NSubstitute跟它說你想Mock實作的Interface
            var NsubRestSharpMock = Substitute.For<IRestSharp>();
            var sut = new PTX(NSubstitute);

            var sb = new StringBuilder(12766);
            sb.AppendLine(@"{""result"":{""limit"":1,""offset"":1,""count"":90,""sort"":"""",""results"":[{""_full_count"":""90"",""Bus"":""252,648"",""Destination"":""台北車站"",""rank"":0.0573088,""Station"":""七張站"",""Outlet"":""A.捷運七張站"",""_id"":1,""Nearby"":""出口1""}]}}");

            NsubRestSharpMock.Get("https://data.taipei/opendata/datalist/apiAccess?scope=resourceAquire&rid=9099acc7-9b9e-4a99-8c0f-3c85cd578a97&q=七張站&limit=1&offset=1")
                            .Returns(sb.ToString());

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