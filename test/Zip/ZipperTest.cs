using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using src.Zip;

namespace test.Zip
{
    [TestClass]
    public class ZipMeTest
    {

        private List<String> capitals;
        private List<String> states;

        [TestInitialize]
        public void SetUp()
        {
            capitals = new List<string> { "Bangalore", "Chennai", "Hyderabad" };
            states = new List<string> { "Karnataka", "Tamil Nadu", "Andhra Pradesh" };
        }

        [TestMethod]
        public void TestShouldZipTwoCollectionsIntoOne()
        {
            List<List<String>> zipped = Zipper.Zip(capitals, states);

            CollectionAssert.AreEqual(new List<string>{"Bangalore", "Karnataka"}, zipped[0]);
            CollectionAssert.AreEqual(new List<string> { "Chennai", "Tamil Nadu" }, zipped[1]);
            CollectionAssert.AreEqual(new List<string> { "Hyderabad", "Andhra Pradesh" }, zipped[2]);
        }

        [TestMethod]
        public void TestDoubleInvocationOfZipGivesOriginalLists()
        {
            List<List<String>> intermediate = Zipper.Zip(capitals, states);
            List<string>[] arrayOfLists = intermediate.ToArray();
            List<List<String>> unzipped = Zipper.Zip(arrayOfLists);

            CollectionAssert.AreEqual(capitals, unzipped[0]);
            CollectionAssert.AreEqual(states, unzipped[1]);
        }

        [TestMethod]
        public void TestZippedListIsAsLongAsTheShortestListInTheCollection()
        {
            
            List<String> smallerCapitals = capitals.Skip(0).Take(3).ToList();
            List<String> localities = new List<String>();
            localities.Add("Koramangala");

            List<List<String>> zipped = Zipper.Zip(localities, smallerCapitals, states);

            Assert.AreEqual(1, zipped.Count);
            CollectionAssert.AreEqual(new List<string> {"Koramangala", "Bangalore", "Karnataka"}, zipped[0]);
        }
    }
}
