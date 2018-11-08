using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07适配器模式
{
    public class OperationAdapter : IScoreOperation
    {
        //这个类是适配者模式的关键          

        private QuickSortHelper sortTarget;
        private BinarySearchHelper searchTarget;
        public OperationAdapter()  
        {
            sortTarget = new QuickSortHelper();
            searchTarget = new BinarySearchHelper();
        }

        public int Search(int[] array, int key)
        {
            return searchTarget.BinarySearch(array, key);
        }

        public int[]  Sort(int[]  array)
        {
            return sortTarget.QuickSort(array);
        }

    }
}
