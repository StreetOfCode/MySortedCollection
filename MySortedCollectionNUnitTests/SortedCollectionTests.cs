using MySortedCollection;
using NUnit.Framework;
using System.Collections.Generic;

namespace MySortedCollectionNUnitTests
{
    [TestFixture]
    public class SortedCollectionTests
    {
        private List<int> numbers;
        private SortedCollection sortedCollection;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {

        }

        [SetUp]
        public void SetUp()
        {
            numbers = new List<int> { 6, 3, 7, 1, 2, 8 };
            sortedCollection = new SortedCollection(numbers);
        }

        [TearDown]
        public void TearDown()
        {
            numbers = null;
            sortedCollection = null;
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {

        }

        [Test]
        public void ConstructorWithList_SortsList_NUnit()
        {
            //ACT
            //var collectionString = sortedCollection.ToString();

            //ASSERT
            var expectedCollectionString = "1,2,3,6,7,8";
            AssertCollection(expectedCollectionString);
        }

        [TestCase(0, "0,1,2,3,6,7,8")]
        [TestCase(9, "1,2,3,6,7,8,9")]
        [TestCase(4, "1,2,3,4,6,7,8")]
        [TestCase(5, "1,2,3,5,6,7,8")]
        public void Add_VariousNumber(int numberToAdd, string expectedCollectionString)
        {
            //ACT
            sortedCollection.Add(numberToAdd);

            AssertCollection(expectedCollectionString);
        }

        [TestCase(new[] { 0, 9, 4 }, "0,1,2,3,4,6,7,8,9")]
        [TestCase(new[] { 0, 9, 4, -1 }, "-1,0,1,2,3,4,6,7,8,9")]
        public void Add_VariousNumbers(int[] numbersToAdd, string expectedCollectionString)
        {
            //ACT
            foreach (var numberToAdd in numbersToAdd)
            {
                sortedCollection.Add(numberToAdd);
            }

            AssertCollection(expectedCollectionString);
        }

        private void AssertCollection(string expectedCollectionString)
        {
            var collectionString = sortedCollection.ToString();
            Assert.AreEqual(expectedCollectionString, collectionString);
        }
    }
}
