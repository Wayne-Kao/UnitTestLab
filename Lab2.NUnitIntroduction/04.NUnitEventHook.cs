using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.NUnitIntroduction
{
    [SetUpFixture]
    public class NUnitEventHook
    {
        [OneTimeSetUp]
        public void RunBeforeAnyTests()
        {
            Console.WriteLine("Run Before All Tests");
        }

        [OneTimeTearDown]
        public void RunAfterAnyTests()
        {
            Console.WriteLine("Run After All Tests");
        }
    }

    [TestFixture]
    public class SuccessTests
    {
        [OneTimeSetUp]
        public void InitOnce()
        {
            Console.WriteLine("Run Once Before Any Tests In A Fixture");
        }

        [OneTimeTearDown]
        public void CleanupOnce()
        {
            Console.WriteLine("Run Once After Any Tests In A Fixture");
        }

        [SetUp]
        public void Init()
        {
            Console.WriteLine("Run Before Each Tests");
        }

        [TearDown]
        public void Cleanup()
        {
            Console.WriteLine("Run After Each Tests");
        }

        [Test]
        public void TestCase1()
        {
            Console.WriteLine("Run TestCase 1");
        }

        [Test]
        public void TestCase2()
        {
            Console.WriteLine("Run TestCase 2");
        }
    }
}
