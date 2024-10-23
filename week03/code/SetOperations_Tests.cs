using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace SetOperationsTests
{
    [TestClass]
    public class SetOperationsTests
    {
        [TestMethod]
        public void TestIntersection_BothSetsHaveCommonElements()
        {
            HashSet<int> setA = new HashSet<int> { 1, 2, 3 };
            HashSet<int> setB = new HashSet<int> { 2, 3, 4 };

            HashSet<int> expected = new HashSet<int> { 2, 3 };

            HashSet<int> result = SetOperations.Intersection(setA, setB);

            CollectionAssert.AreEquivalent(new List<int>(expected), new List<int>(result));
        }

        [TestMethod]
        public void TestIntersection_BothSetsHaveAtLeastOneCommonElements()
        {
            HashSet<int> setA = new HashSet<int> { 1, 2, 3 };
            HashSet<int> setB = new HashSet<int> { 2, 2, 2 };

            HashSet<int> expected = new HashSet<int> { 2 };

            HashSet<int> result = SetOperations.Intersection(setA, setB);

            CollectionAssert.AreEquivalent(new List<int>(expected), new List<int>(result));
        }

        [TestMethod]
        public void TestIntersection_NoCommonElements()
        {
            HashSet<int> setA = new HashSet<int> { 1, 2, 3 };
            HashSet<int> setB = new HashSet<int> { 4, 5, 6 };

            HashSet<int> expected = new HashSet<int>();

            HashSet<int> result = SetOperations.Intersection(setA, setB);

            CollectionAssert.AreEquivalent(new List<int>(expected), new List<int>(result));
        }

        [TestMethod]
        public void TestUnion_DifferentElements()
        {
            HashSet<int> setA = new HashSet<int> { 1, 2, 3 };
            HashSet<int> setB = new HashSet<int> { 3, 4, 5 };

            HashSet<int> expected = new HashSet<int> { 1, 2, 3, 4, 5 };

            HashSet<int> result = SetOperations.Union(setA, setB);

            CollectionAssert.AreEquivalent(new List<int>(expected), new List<int>(result));
        }

        [TestMethod]
        public void TestUnion_OneSetIsEmpty()
        {
            HashSet<int> setA = new HashSet<int> { 1, 2, 3 };
            HashSet<int> setB = new HashSet<int>();

            HashSet<int> expected = new HashSet<int> { 1, 2, 3 };

            HashSet<int> result = SetOperations.Union(setA, setB);

            CollectionAssert.AreEquivalent(new List<int>(expected), new List<int>(result));
        }

        [TestMethod]
        public void TestUnion_BothSetsAreEmpty()
        {
            HashSet<int> setA = new HashSet<int>();
            HashSet<int> setB = new HashSet<int>();

            HashSet<int> expected = new HashSet<int>();

            HashSet<int> result = SetOperations.Union(setA, setB);

            CollectionAssert.AreEquivalent(new List<int>(expected), new List<int>(result));
        }
    }
}
