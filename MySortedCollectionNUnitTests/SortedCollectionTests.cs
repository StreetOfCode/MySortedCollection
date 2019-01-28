using MySortedCollection;
using NUnit.Framework;
using System.Collections.Generic;

namespace MySortedCollectionNUnitTests
{
    [TestFixture]
    public class SortedCollectionTests
    {
        [Test]
        public void ConstructorWithList_SortsList_NUnit()
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
