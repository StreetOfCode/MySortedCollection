using System.Collections.Generic;
using System.Linq;

namespace MySortedCollection
{
    public class SortedCollection
    {
        private List<int> items;

        public SortedCollection()
        {

        }

        public SortedCollection(List<int> items)
        {
            this.items = items.ToList(); // "clone"
            BubbleSort();
        }

        public SortedCollection(int[] items)
        {
            this.items = items.ToList();
            BubbleSort();
        }

        public void BubbleSort()
        {
            for (var i = 0; i < items.Count; i++)
            {
                for (var j = 0; j < items.Count - 1; j++)
                {
                    if (items[j] > items[j + 1])
                    {
                        var tmp = items[j];
                        items[j] = items[j + 1];
                        items[j + 1] = tmp;
                    }
                }
            }
        }

        public override string ToString()
        {
            return string.Join(",", items);
        }
    }
}
