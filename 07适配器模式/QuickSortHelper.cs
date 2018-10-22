using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07适配器模式
{
    public class QuickSortHelper
    {
        public int[] QuickSort(int[] array)
        {
            Sort(array, 0, array.Length - 1);
            return array;
        }

        public void Sort(int[] array, int p, int r)
        {
            int q = 0;
            if (p < r)
            {
                q = Partition(array, p, r);
                Sort(array, p, q - 1);
                Sort(array, q + 1, r);
            }
        }

        public int Partition(int[] array, int p, int r)
        {
            int x = array[r];
            int j = p - 1;

            for (int i = p; i <= r - 1; i++)
            {
                if (array[i] <= x)
                {
                    j++;
                    Swap(array, j, i);
                }
            }

            Swap(array, j + 1, r);
            return j + 1;
        }


        /// <summary>
        /// 交换数组中的指定元素
        /// </summary>
        /// <param name="array"></param>
        /// <param name="i"></param>
        /// <param name="j"></param>
        public void Swap(int[]  array,int i,int  j)
        {
            int t = array[i];
            array[i] = array[j];
            array[j] = t;
        }

    }
}
