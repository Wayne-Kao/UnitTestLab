using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.NUnitIntroduction
{
    [TestFixture]
    public class AssertExceptionSample
    {
        [Test]
        public void AssertException_DontDoThis()
        {
            var expected = "嘗試以零除。";
            var actual = "";
            try
            {
                var zero = 0;
                var result = 1 / zero;
            }
            catch (DivideByZeroException ex)
            {
                actual = ex.Message;
            }

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void 該怎麼驗證Exception1()
        {
            var zero = 0;
            void test() { var result = 1 / zero; }
            var ex = Assert.Throws<DivideByZeroException>(test);
            Assert.That(ex.Message, Is.EqualTo("嘗試以零除。"));
        }

        [Test]
        public void 該怎麼驗證Exception2()
        {
            var zero = 0;
            void test() { var result = 1 / zero; }
            Assert.That(test, Throws.Exception.TypeOf<DivideByZeroException>().
                With.Property("Message").EqualTo("嘗試以零除。"));
        }
    }
}
