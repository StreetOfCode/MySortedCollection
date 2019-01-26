using System;
using System.Collections.Generic;

namespace MySortedCollection
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var numbers = new List<int> { 6, 3, 7, 1, 2, 8 };
            var sortedCollection = new SortedCollection(numbers);

            Console.WriteLine(sortedCollection);
        }
    }
}
