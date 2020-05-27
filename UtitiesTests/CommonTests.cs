using Utities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace Utities.Tests
{
    [TestClass()]
    public class CommonTests
    {
        [TestMethod()]
        public void GetBaseNumberTest_呼叫時應回傳結果為7()
        {
            // arrange 準備受測物件、參數、預期結果
            var Sut = new Common();
            var expected = 4;

            //act 執行受測方法
            var actual = Sut.GetBaseNumber();

            //assert 驗證執行結果與預測結果是否一致
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetBaseNumberAddTest()
        {
            var Sut = new Common();
            var expected = 10;

            //act
            var actual = Sut.GetBaseNumberAdd();

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}