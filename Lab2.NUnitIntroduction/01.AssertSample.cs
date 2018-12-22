using System;
using NUnit.Framework;
using ExpectedObjects;
using Lab2.NUnitIntroduction.Models;
using System.Collections.Generic;

namespace Lab2.NUnitIntroduction
{
    [TestFixture]
    public class AssertSample
    {
        [Test]
        public void Test_OrderEquals_ByAssertEquals()
        {
            var expected = new Order()
            {
                Id = 1,
                Price = 10
            };

            var actual = new Order()
            {
                Id = 1,
                Price = 10
            };
            Assert.That(actual, Is.EqualTo(expected));
            Assert.That(actual, Is.SameAs(expected));
        }

        [Test]
        public void Test_OrderInfoEqual_ByAssertEqual()
        {
            var expected = new OrderInfo()
            {
                Id = 1,
                Price = 10
            };

            var actual = new OrderInfo()
            {
                Id = 1,
                Price = 10
            };

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_OrderEqual_WithExpectedObjects()
        {
            var expected = new Order()
            {
                Id = 1,
                Price = 10
            };

            var actaul = new Order()
            {
                Id = 1,
                Price = 10
            };

            expected.ToExpectedObject().ShouldEqual(actaul);
        }

        [Test]
        public void Test_OrderCollection_WithExpectedObjects()
        {
            var expected = new List<Order>()
            {
                new Order() { Id = 1, Price = 10},
                new Order() { Id = 2, Price = 20},
                new Order() { Id = 3, Price = 30}
            };

            var actual = new List<Order>()
            {
                new Order() { Id = 1, Price = 10},
                new Order() { Id = 2, Price = 20},
                new Order() { Id = 3, Price = 30}
            };

            expected.ToExpectedObject().ShouldEqual(actual);
        }

        [Test]
        public void Test_ComposedPerson_WithExpectedObjects()
        {
            var expected = new Person()
            {
                Id = 1,
                Name = "Wayne",
                Age = 18,
                Order = new Order()
                {
                    Id = 10,
                    Price = 99
                }
            };

            var actual = new Person()
            {
                Id = 1,
                Name = "Wayne",
                Age = 18,
                Order = new Order()
                {
                    Id = 10,
                    Price = 99
                }
            };

            expected.ToExpectedObject().ShouldEqual(actual);
        }

        [Test]
        public void Test_PartialCompare_Person_WithExpectedObjects()
        {
            var expected = new
            {
                Id = 1,
                Age = 18,
                Order = new
                {
                    Id = 10
                }
            };

            var actual = new Person()
            {
                Id = 1,
                Name = "Wayne",
                Age = 18,
                Order = new Order()
                {
                    Id = 10,
                    Price = 99
                }
            };

            expected.ToExpectedObject().ShouldMatch(actual);
        }
    }
}
