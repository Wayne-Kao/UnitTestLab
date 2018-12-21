using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.NUnitIntroduction
{
    [TestFixture]
    public class CollectionAssertSample
    {
        [Test]
        public void 驗證Collection_集合內按照順序_每個項目是否相等()
        {
            var expected = new int[] { 1, 3, 5 };
            var actual = new int[] { 1, 3, 5 };

            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void 驗證Collection_集合內容是否相等_不管順序()
        {
            // 兩個集合個數一樣，順序不一樣
            var expected = new int[] { 3, 5, 1 };
            var actual = new int[] { 1, 3, 5 };

            CollectionAssert.AreEquivalent(expected, actual);
            Assert.That(actual, Is.EquivalentTo(expected));
        }

        [Test]
        public void 驗證Collection_是否為子集合()
        {
            var superset = new int[] { 1, 3, 5 };
            var subset = new int[] { 5, 3 };

            CollectionAssert.IsSubsetOf(subset, superset);
            Assert.That(subset, Is.SubsetOf(superset));
        }

        [Test]
        public void 驗證Collection_集合內項目是否唯一()
        {
            var actual = new int[] { 1, 1, 3, 5 };

            CollectionAssert.AllItemsAreUnique(actual);
            Assert.That(actual, Is.Unique);
        }
    }
}
