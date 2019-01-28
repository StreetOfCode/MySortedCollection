using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace MySortedCollection.Tests
{
    [TestClass()]
    public class SortedCollectionTests
    {
        [TestMethod()]
        public void ConstructorWithList_SortsList()
        {
            //ARRANGE
            var numbers = new List<int> { 6, 3, 7, 1, 2, 8 };

            //ACT
            var sortedCollection = new SortedCollection(numbers);
            var collectionString = sortedCollection.ToString();

            //ASSERT
            var expectedCollectionString = "1,2,3,6,7,8";
            Assert.AreEqual(expectedCollectionString, collectionString);
        }
    }
}