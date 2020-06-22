using arraycompare_csharp;
using Microsoft.VisualBasic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace arraycompare_tests
{
    [TestClass]
    public class ArrayCompareServiceTests
    {
        [TestMethod]
        public void Compare_TwoIntersectingArrays()
        {
            var service = new ArrayCompareService();
            var arr1 = new List<string> { "a", "b", "c", "e", "f" };
            var arr2 = new List<string> { "c", "d", "e", "f", "g" };

            var res = service.Compare(arr1, arr2);

            CollectionAssert.AreEqual(new List<string> { "c", "e", "f" }, res.Same);
            CollectionAssert.AreEqual(new List<string> { "a", "b" }, res.InA);
            CollectionAssert.AreEqual(new List<string> { "d", "g" }, res.InB);
        }
    }
}
