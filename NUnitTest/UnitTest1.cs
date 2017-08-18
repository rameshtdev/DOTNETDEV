using System;
using NUnit.Framework;
using NUnit.Compatibility;
using NSubstitute;
using SampleLibrary;

namespace NUnitTest
{
    [TestFixture]
    public class UnitTest1
    {
        private Calculator CObj;

        [SetUp]
        public void setup()
        {
            
            CObj = new Calculator(new DataClass());
        }

        [Test]
        public void TestTheInstance()
        {
            Assert.IsInstanceOf(typeof(Calculator), CObj);
        }

        [Test]
        [Ignore("function depreciated")]
        public void CheckCallingAddMethod()
        {
            Assert.IsNotNull(CObj.AddNumbers(2, 3));
        }

        [Test]
        [TestCase(2,3,5)]
        [TestCase(5, 3, 8)]
        [TestCase(6, 4, 10)]
        [TestCase(3, 6, 9)]
        public void CheckAddResults(int x, int y, int expectedoutput)
        {
            var result = CObj.AddNumbers(x, y);
            Assert.AreEqual(result, expectedoutput);
        }

        [Test]
        public void CheckException()
        {
            Assert.Throws(typeof(IndexOutOfRangeException),()=> { CObj.AddNumbers(-1, -2); });
        }

        [Test]
        public void MockExample()
        {
            var dataclassSub = NSubstitute.Substitute.For<IDataClass>();
            dataclassSub.AddNumbers(1, 2).Returns(3);
            var obj = new Calculator(dataclassSub);
            var result = obj.AddNumbers(1, 2);
            Assert.AreEqual(result, 3);
        }

        [TearDown]
        public void Clear()
        {
            //Do something
            CObj = null;
        }
    }
}
