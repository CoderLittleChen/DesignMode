using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07适配器模式
{
    public class BinarySearchHelper
    {
        //二分查找的具体实现方式  
        public int BinarySearch(int[] array, int key)
        {
            int low = 0;
            int height = array.Length - 1;
            while (low <= height)
            {
                int mid = (low + height) / 2;
                int midVal = array[mid];
                if (midVal < key)
                {
                    low = mid + 1;
                }
                else if (midVal > key)
                {
                    height = mid - 1;
                }
                else
                {
                    return 1;
                }
            }
            return -1;

        }
    }
}
