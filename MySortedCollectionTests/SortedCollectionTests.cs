using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace MySortedCollection.Tests
{
    [TestClass()]
    public class SortedCollectionTests
    {
        private List<int> numbers;
        private SortedCollection sortedCollection;

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {

        }

        [TestInitialize]
        public void TestInitialize()
        {
            numbers = new List<int> { 6, 3, 7, 1, 2, 8 };
            sortedCollection = new SortedCollection(numbers);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            numbers = null;
            sortedCollection = null;
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {

        }

        [TestMethod()]
        public void ConstructorWithList_SortsList()
        {
            //ACT
            var collectionString = sortedCollection.ToString();

            //ASSERT
            var expectedCollectionString = "1,2,3,6,7,8";
            Assert.AreEqual(expectedCollectionString, collectionString);
        }

        [DataTestMethod]
        [DataRow(0, "0,1,2,3,6,7,8")]
        [DataRow(9, "1,2,3,6,7,8,9")]
        [DataRow(4, "1,2,3,4,6,7,8")]
        [DataRow(5, "1,2,3,5,6,7,8")]
        public void Add_VariousNumber(int numberToAdd, string expectedCollectionString)
        {
            //ACT
            sortedCollection.Add(numberToAdd);
            var collectionString = sortedCollection.ToString();

            //ASSERT
            Assert.AreEqual(expectedCollectionString, collectionString);
        }

        [DataTestMethod]
        [DataRow(new[] { 0, 9, 4 }, "0,1,2,3,4,6,7,8,9")]
        [DataRow(new[] { 0, 9, 4, -1 }, "-1,0,1,2,3,4,6,7,8,9")]
        public void Add_VariousNumbers(int[] numbersToAdd, string expectedCollectionString)
        {
            //ACT
            foreach (var numberToAdd in numbersToAdd)
            {
                sortedCollection.Add(numberToAdd);
            }
            var collectionString = sortedCollection.ToString();

            //ASSERT
            Assert.AreEqual(expectedCollectionString, collectionString);
        }
    }
}