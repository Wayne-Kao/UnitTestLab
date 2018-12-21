using NUnit.Framework;
using Lab1.UnitTestDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.UnitTestDemo.Tests
{
    [TestFixture()]
    public class SimpleCalculatorTests
    {
        [Test()]
        public void Sum_Input1And2_Return3()
        {
            //arrange
            var first = 1;
            var second = 2;
            var target = new SimpleCalculator();
            var expected = 3;

            //act
            var result = target.Sum(first, second);

            //assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}