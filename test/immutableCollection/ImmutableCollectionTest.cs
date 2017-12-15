using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using src.ImmutableCollection;

namespace test.ImmutableCollection
{
    /**
     * Test for @{@link ImmutableCollectionImpl}
     * A collection once created,never changes again !!
     * No one can mess around with this collection not even multiple threads.
     */
    [TestClass]
    public class ImmutableCollectionTest
    {

        [TestMethod]
        public void ShouldAddNewElementToImmutableCollection()
        {
            var elements = new List<string> { "Element1", "Element2" };
            IImmutableCollection<String> immutableCollection = new ImmutableCollection<String>(elements);
            IImmutableCollection<String> newImmutableCollection = immutableCollection.Add("newElement");
            Assert.Equals(2, immutableCollection.Size());
            Assert.Equals(3, newImmutableCollection.Size());
        }

        [TestMethod]
        public void ShouldBeAbleToRemoveAnElementFromImmutableCollection()
        {
            var elements = new List<string> { "Element1", "Element2" };
            IImmutableCollection<String> immutableCollection = new ImmutableCollection<String>(elements);
            IImmutableCollection<String> newImmutableCollection = immutableCollection.Remove("Element1");
            Assert.Equals(2, immutableCollection.Size());
            Assert.Equals(1, newImmutableCollection.Size());
        }
    }

}
